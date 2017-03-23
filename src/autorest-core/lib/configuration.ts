/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import {
  DataHandleRead,
  DataHandleWrite,
  DataStore,
  DataStoreFileView,
  DataStoreViewReadonly
} from './data-store/data-store';

import { EventEmitter, IEvent } from './events';
import { CodeBlock, Parse as ParseLiterateYaml, ParseCodeBlocks } from './parsing/literate-yaml';
import { EnsureIsFolderUri, ResolveUri } from './ref/uri';
import { From, Enumerable as IEnumerable } from "./ref/linq";
import { IFileSystem } from "./file-system"
import * as Constants from './constants';
import { Message } from "./message";
import { CancellationTokenSource, CancellationToken } from "./ref/cancallation";

export interface AutoRestConfigurationSwitches {
  [key: string]: string | null;
}

export interface AutoRestConfigurationSpecials {
  infoSectionOverride?: any; // from composite swagger file, no equivalent (yet) in config file; IF DOING THAT: also make sure source maps are pulling it! (see "composite swagger" method)
  codeGenerator?: string;
  azureValidator?: boolean;
  header?: string | null;
  namespace?: string;
  payloadFlatteningThreshold?: number;
  syncMethods?: "all" | "essential" | "none";
  addCredentials?: boolean;
  rubyPackageName?: string;
}

export interface AutoRestConfigurationImpl {
  [key: string]: any;
  __info?: string | null;
  __specials?: AutoRestConfigurationSpecials;
  "input-file": string[] | string;
  "output-folder"?: string;
  "base-folder"?: string;
}

// protected static CreateDefaultConfiguration(): AutoRestConfigurationImpl {
//   return {
//     "input-file": []
//   };
// }

/*
function key(target: string) {
  return (target, propertyKey) => {

    @key("base-folder") baseFolder: string;
    @key("output-folder") outputFolder: string;

  };
};
*/

export class ConfigurationView extends EventEmitter {

  /* @internal */ constructor(
    /* @internal */
    private configFileFolderUri: string,
    ...configs: Array<AutoRestConfigurationImpl>
  ) {
    super();
    this.DataStore = new DataStore(this.CancellationToken);
    // TODO: fix configuration loading, note that there was no point in passing that DataStore used 
    // for loading in here as all connection to the sources is lost when passing `Array<AutoRestConfigurationImpl>` instead of `DataHandleRead`s...
    // theoretically the `ValuesOf` approach and such won't support blaming (who to blame if $.directives[3] sucks? which code block was it from)
    // long term, we simply gotta write a `Merge` method that adheres to the rules we need in here.
    this.config = configs;
    this.Debug.Dispatch({ Text: `Creating ConfigurationView : ${configs.length} sections.` });
  }

  /* @internal */
  public readonly DataStore: DataStore;

  private cancellationTokenSource = new CancellationTokenSource();
  /* @internal */
  public get CancellationTokenSource(): CancellationTokenSource { return this.cancellationTokenSource; }
  /* @internal */
  public get CancellationToken(): CancellationToken { return this.cancellationTokenSource.token; }

  @EventEmitter.Event public Information: IEvent<ConfigurationView, Message>;
  @EventEmitter.Event public Warning: IEvent<ConfigurationView, Message>;
  @EventEmitter.Event public Error: IEvent<ConfigurationView, Message>;
  @EventEmitter.Event public Debug: IEvent<ConfigurationView, Message>;
  @EventEmitter.Event public Verbose: IEvent<ConfigurationView, Message>;
  @EventEmitter.Event public Fatal: IEvent<ConfigurationView, Message>;

  private config: Array<AutoRestConfigurationImpl>;

  private ValuesOf(fieldName: string): IEnumerable<any> {
    return From<AutoRestConfigurationImpl>(this.config).Select(config => config[fieldName]);
  }

  private SingleValue<T>(fieldName: string): T | null {
    return this.ValuesOf(fieldName).FirstOrDefault();
  }

  private *MultipleValues<T>(fieldName: string): Iterable<T> {
    for (const each of this.ValuesOf(fieldName)) {
      if (each != undefined && each != null) {
        if (typeof each === "string") {
          yield <T><any>each;
        } else if (each[Symbol.iterator]) {
          yield* each;
        } else {
          yield each;
        }
      }
    }
  }

  private ResolveAsFolder(path: string): string {
    return EnsureIsFolderUri(ResolveUri(this.configFileFolderUri, path));
  }

  private ResolveAsPath(path: string): string {
    return ResolveUri(this.baseFolderUri, path);
  }

  private get baseFolderUri(): string {
    return this.ResolveAsFolder(this.SingleValue<string>("base-folder") || "");
  }

  // public methods

  public get inputFileUris(): Iterable<string> {
    return From<string>(this.MultipleValues<string>("input-file"))
      .Select(each => this.ResolveAsPath(each));
  }

  public get outputFolderUri(): string {
    return this.ResolveAsFolder(this.SingleValue<string>("output-folder") || "generated")
  }

  public get __specials(): AutoRestConfigurationSpecials {
    return this.ValuesOf("__specials").FirstOrDefault() || {};
  }

  // TODO: stuff like generator specific settings (= YAML merging root with generator's section)
}


export class Configuration {
  public async CreateView(...configs: Array<any>): Promise<ConfigurationView> {
    const workingScope: DataStore = new DataStore();
    const configFileUri = this.fileSystem && this.uriToConfigFileOrWorkingFolder
      ? await Configuration.DetectConfigurationFile(this.fileSystem, this.uriToConfigFileOrWorkingFolder)
      : null;

    const defaults = require("../resources/default-configuration.json");

    if (configFileUri === null) {
      return new ConfigurationView("file:///", defaults, ...configs);
    } else {
      const inputView = workingScope.CreateScope("input").AsFileScopeReadThroughFileSystem(this.fileSystem as IFileSystem);

      // load config
      const hConfig = await ParseCodeBlocks(
        await inputView.ReadStrict(configFileUri),
        workingScope.CreateScope("config"));

      const blocks = await Promise.all(From<CodeBlock>(hConfig).Select(async each => {
        const block = await each.data.ReadObject<AutoRestConfigurationImpl>();
        block.__info = each.info;
        return block;
      }));

      return new ConfigurationView(ResolveUri(configFileUri, "."), defaults, ...configs, ...blocks);
    }
  }

  public constructor(
    private fileSystem?: IFileSystem,
    private uriToConfigFileOrWorkingFolder?: string
  ) {
    this.FileChanged();
  }

  public FileChanged() {
  }

  public static async DetectConfigurationFile(fileSystem: IFileSystem, uriToConfigFileOrWorkingFolder: string): Promise<string | null> {
    if (!uriToConfigFileOrWorkingFolder.endsWith("/")) {
      return uriToConfigFileOrWorkingFolder;
    }

    // scan the filesystem items for the configuration.
    const configFiles = new Map<string, string>();

    for await (const name of fileSystem.EnumerateFileUris(uriToConfigFileOrWorkingFolder)) {
      const content = await fileSystem.ReadFile(name);
      if (content.indexOf(Constants.MagicString) > -1) {
        configFiles.set(name, content);
      }
    }

    if (configFiles.size === 0) {
      return null;
    }

    // it's the readme.md or the shortest filename.
    let found =
      From<string>(configFiles.keys()).FirstOrDefault(each => each.toLowerCase().endsWith("/" + Constants.DefaultConfiguratiion)) ||
      From<string>(configFiles.keys()).OrderBy(each => each.length).First();

    return found;
  }

  // public async HasConfiguration(): Promise<boolean> {
  //   return await this.DetectConfigurationFile() !== null;
  // }
}
