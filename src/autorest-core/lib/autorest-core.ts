import { SmartPosition, Position } from './ref/source-map';
import { DataStore, Metadata } from './data-store/data-store';
import { IEnumerable, From } from './ref/linq';
import { IEvent, EventDispatcher, EventEmitter } from "./events";
import { IFileSystem } from "./file-system";
import { Configuration, ConfigurationView, FileSystemConfiguration } from './configuration';
import { DocumentType } from "./document-type";
export { ConfigurationView } from './configuration';
import { Message } from './message';
import * as Constants from './constants';

export class AutoRest extends EventEmitter {
  private _configurations = new Array<any>();
  private _view: ConfigurationView | undefined;
  public get view(): Promise<ConfigurationView> {
    return new Promise<ConfigurationView>(async (r, j) => {
      if (!this._view) {
        this._view = await new FileSystemConfiguration(this.fileSystem).CreateView(...this._configurations)

        // subscribe to the events for the current configuration view 
        this._view.Debug.Subscribe((cfg, message) => this.Debug.Dispatch(message));
        this._view.Verbose.Subscribe((cfg, message) => this.Verbose.Dispatch(message));
        this._view.Fatal.Subscribe((cfg, message) => this.Fatal.Dispatch(message));
        this._view.Information.Subscribe((cfg, message) => this.Information.Dispatch(message));
        this._view.Error.Subscribe((cfg, message) => this.Error.Dispatch(message));
        this._view.Warning.Subscribe((cfg, message) => this.Warning.Dispatch(message));
      }
      r(this._view);
    })
  }
  /**
   * 
   * @param rootUri The rootUri of the workspace. Is null if no workspace is open.
   * @param fileSystem The implementation of the filesystem to load and save files from the host application.
   */
  public constructor(private fileSystem: IFileSystem) {
    super();
  }

  /**
   *  Given a file's content, does this represent a swagger file of some sort?
   *
   * @param content - the file content to evaluate
   */
  public static async IsSwaggerFile(documentType: DocumentType, content: string): Promise<boolean> {
    // this checks to see if the document is a 
    return true;
  }

  public static async IsConfigurationFile(content: string): Promise<boolean> {
    // this checks to see if the document is an autorest markdown configuration file
    return content.indexOf(Constants.MagicString) > -1
  }

  public async FindDocumentRoot(documentPath: string): Promise<string> {
    return "null";
  }

  public Invalidate() {
    this._view = undefined;
  }

  public async AddConfiguration(configuratuion: any): Promise<void> {
    this._configurations.push(configuratuion);
    this.Invalidate();
  }

  public async ResetConfiguration(): Promise<void> {
    // clear the configuratiion array.
    this._configurations.length = 0;
    this.Invalidate();
  }

  public get HasConfiguration(): Promise<boolean> {
    return new Promise(async (r, f) => {
      (await this.view);
      r(false);
    });
  }

  /**
   * Called to start processing of the files.
   */
  public Start(): void {
    try {
      // implement RunPipeline here.

      // finished cleanly
      this.Finished.Dispatch(true);
    }
    catch (e) {
      // finished not cleanly
      this.Finished.Dispatch(false);
    }
    finally {
      this.Invalidate();
    }
  }

  /**
   * Called to stop the processing.
   */
  public Stop(): void {
    // or better excuse to cancel.
  }


  @EventEmitter.Event public Finished: IEvent<AutoRest, boolean>;

  @EventEmitter.Event public Information: IEvent<AutoRest, Message>;
  @EventEmitter.Event public Warning: IEvent<AutoRest, Message>;
  @EventEmitter.Event public Error: IEvent<AutoRest, Message>;
  /**
   * Event: Signals when a debug message is sent from AutoRest
   */
  @EventEmitter.Event public Debug: IEvent<AutoRest, Message>;
  @EventEmitter.Event public Verbose: IEvent<AutoRest, Message>;
  @EventEmitter.Event public Fatal: IEvent<AutoRest, Message>;


}
