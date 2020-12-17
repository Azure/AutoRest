/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
declare const isDebuggerEnabled: boolean;
const cwd = process.cwd();

import { isFile } from "@azure-tools/async-io";
import chalk from "chalk";
import { dirname } from "path";
import {
  newCorePackage,
  ensureAutorestHome,
  extensionManager,
  networkEnabled,
  pkgVersion,
  resolvePathForLocalVersion,
  rootFolder,
  selectVersion,
  tryRequire,
  resolveEntrypoint,
  runCoreOutOfProc,
} from "./autorest-as-a-service";
import { color } from "./coloring";
import * as vm from "vm";
import { ResolveUri, ReadUri, EnumerateFiles } from "@azure-tools/uri";
import { parseArgs } from "./args";
import { resetAutorest, showAvailableCoreVersions, showInstalledExtensions } from "./commands";
import { checkForAutoRestUpdate, clearTempData } from "./actions";

const launchCore = isDebuggerEnabled ? tryRequire : runCoreOutOfProc;

// aliases, round one.
if (process.argv.indexOf("--no-upgrade-check") !== -1) {
  process.argv.push("--skip-upgrade-check");
}

if (process.argv.indexOf("--json") !== -1) {
  process.argv.push("--message-format=json");
}

if (process.argv.indexOf("--yaml") !== -1) {
  process.argv.push("--message-format=yaml");
}

const args = parseArgs(process.argv);
console.error("Args", args);
(<any>global).__args = args;

// aliases
args["info"] = args["info"] || args["list-installed"];
args["preview"] = args["preview"] || args["prerelease"];
if (args["v3"] && !args["version"]) {
  // --v3 without --version infers --version:~3.0.6212 +
  // args["version"] = "~3.0.6212";
}

// Suppress the banner if the message-format is set to something other than regular.
if (!args["message-format"] || args["message-format"] === "regular") {
  console.log(
    chalk.green.bold.underline(
      `AutoRest code generation utility [cli version: ${chalk.white.bold(pkgVersion)}; node: ${chalk.white.bold(
        process.version,
      )}, max-memory: ${
        Math.round(require("v8").getHeapStatistics().heap_size_limit / (1024 * 1024)) & 0xffffffff00
      } MB]`,
    ),
  );
  console.log(color("(C) 2018 **Microsoft Corporation.**"));
  console.log(chalk.blue.bold.underline("https://aka.ms/autorest"));
}

// argument tweakin'
args.info = args.version === "" || args.info; // show --info if they use unparameterized --version.
const listAvailable: boolean = args["list-available"] || false;
const force = args.force || false;

async function configurationSpecifiedVersion(selectedVersion: any) {
  try {
    // we can either have a selectedVerison object or a path. See if we can find the AutoRest API
    const autorestApi = await resolveEntrypoint(
      typeof selectedVersion === "string" ? selectedVersion : await selectedVersion.modulePath,
      "main",
    );

    // things we need in the sandbox.
    const sandbox = {
      require,
      console,
      rfs: {
        EnumerateFileUris: async (folderUri: string): Promise<Array<string>> => {
          return EnumerateFiles(folderUri, ["readme.md"]);
        },
        ReadFile: async (uri: string): Promise<string> => {
          return ReadUri(uri);
        },
        WriteFile: async (uri: string, content: string): Promise<void> => {
          //return WriteString(uri, content);
        },
      },
      cfgfile: ResolveUri(cwd, args.configFileOrFolder || "."),
      switches: args,
    };

    // *sigh* ... there's a bug in most versions of autorest-core that to use the API you have to
    // have the current directory set to the package location. We'll fix this in the future versions.
    process.chdir(dirname(autorestApi));
    const configSpecifiedVersion = await vm.runInNewContext(
      `
          async function go() {
            // load the autorest api library
            const r = require('${autorestApi}');
            const api = new r.AutoRest(rfs,cfgfile);
            // don't let the version from the cmdline affect this!
            delete switches.version;
            api.AddConfiguration(switches);

            // resolve the configuration and return the version if there is one.
            return (await api.view).rawConfig.version;              
          }
          go();
          `,
      sandbox,
    );

    // if we got back a result, lets return that.
    if (configSpecifiedVersion) {
      selectedVersion = await selectVersion(configSpecifiedVersion, false);
      console.log(
        chalk.yellow(
          `NOTE: AutoRest core version selected from configuration: ${chalk.yellow.bold(configSpecifiedVersion)}.`,
        ),
      );
    }
    return selectedVersion;
  } catch {
    return undefined;
  }
}

/** Main Entrypoint for AutoRest Bootstrapper */
async function main() {
  try {
    // did they ask for what is available?
    if (listAvailable) {
      process.exit(await showAvailableCoreVersions(args));
    }

    // show what we have.
    if (args.info) {
      process.exit(await showInstalledExtensions(args));
    }

    try {
      /* make sure we have a .autorest folder */
      await ensureAutorestHome();

      if (args.reset || args["clear-temp"]) {
        // clear out all the temp-data too
        await clearTempData();
      }

      // if we have an autorest home folder, --reset may mean something.
      // if it's not there, --reset won't do anything.
      if (args.reset) {
        process.exit(await resetAutorest(args));
      }
    } catch {
      // We have a chance to fail again later if this proves problematic.
    }

    let requestedVersion: string =
      args.version || (args.latest && "latest") || (args.preview && "preview") || "latest-installed";
    
    // check to see if local installed core is available.
    let localVersion = resolvePathForLocalVersion(args.version ? requestedVersion : null);

    if (!args.version && localVersion) {
      
      // they never specified a version on the cmdline, but we might have one in configuration
      const cfgVersion = (await configurationSpecifiedVersion(localVersion))?.version;

      // if we got one back, we're going to set the requestedVersion to whatever they asked for.
      if (cfgVersion) {
        args.version = requestedVersion = cfgVersion;

        // and not use the local version
        localVersion = undefined;
      }
    }
    
    // if this is still valid, then we're not overriding it from configuration.
    if (localVersion) {
      process.chdir(cwd);

      if (await launchCore(localVersion, "app.js")) {
        return;
      }
    }

    // if the resolved local version is actually a file, we'll try that as a package when we get there.
    if (await isFile(localVersion)) {
      // this should try to install the file.
      if (args.debug) {
        console.log(`Found local core package file: '${localVersion}'`);
      }
      requestedVersion = localVersion;
    }

    // failing that, we'll continue on and see if NPM can do something with the version.
    if (args.debug) {
      console.log(`Network Enabled: ${await networkEnabled}`);
    }

    // wait for the bootstrapper check to finish.
    await checkForAutoRestUpdate(args);

    // logic to resolve and optionally install a autorest core package.
    // will throw if it's not doable.
    let selectedVersion = await selectVersion(requestedVersion, force);

    // let's strip the extra stuff from the command line before we require the core module.
    const oldArgs = process.argv;
    const newArgs = new Array<string>();

    for (const each of process.argv) {
      let keep = true;
      for (const discard of [
        "--version",
        "--list-installed",
        "--list-available",
        "--reset",
        "--latest",
        "--latest-release",
        "--runtime-id",
      ]) {
        if (each === discard || each.startsWith(`${discard}=`) || each.startsWith(`${discard}:`)) {
          keep = false;
        }
      }
      if (keep) {
        newArgs.push(each);
      }
    }
    process.argv = newArgs;

    // use this to make the core aware that this run may be legal even without any inputs
    // this is a valid scenario for "preparation calls" to autorest like `autorest --reset` or `autorest --latest`
    if (args.reset || args.latest || args.version == "latest") {
      // if there is *any* other argument left, that's an indicator that the core is supposed to do something
      process.argv.push("--allow-no-input");
    }

    // if they never said the version on the command line, we should make a check for the config version.
    if (!args.version) {
      selectedVersion = (await configurationSpecifiedVersion(selectedVersion)) || selectedVersion;
    }

    if (args.debug) {
      console.log(`Starting ${newCorePackage} from ${await selectedVersion.location}`);
    }

    // reset the working folder to the correct place.
    process.chdir(cwd);

    const result = await launchCore(await selectedVersion.modulePath, "app.js");
    if (!result) {
      throw new Error(`Unable to start AutoRest Core from ${await selectedVersion.modulePath}`);
    }
  } catch (exception) {
    console.log(chalk.redBright("Failure:"));
    console.error(chalk.bold(exception));
    console.error(chalk.bold((<Error>exception).stack));
    process.exit(1);
  }
}

main();
