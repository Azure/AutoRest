// polyfill for the AsyncIterator support
require("./lib/polyfill.min.js")

// exports the public AutoRest definitions
export { Installer } from "./installer";
export { IFileSystem, Message, AutoRest as IAutoRest } from 'autorest-core';

// the local class definition of the AutoRest Interface
import { AutoRest as IAutoRest } from 'autorest-core';

// export the selected implementation of the AutoRest interface.
import { Installer } from "./installer"

let modulePath = /(\\||\/)src(\\||\/)autorest(\\||\/)/.test(__dirname) ? `${__dirname}/../autorest-core` : Installer.AutorestImplementationPath
let impl = require(modulePath);

export const AutoRest: typeof IAutoRest = <typeof IAutoRest><any>impl.AutoRest
export declare type AutoRest = IAutoRest;
