import { DataStore } from "@azure-tools/datastore";
import { AutorestDiagnostic, EnhancedLogInfo } from ".";
import { LogSourceEnhancer } from "./log-source-enhancer";
import { AutorestLoggerBase } from "./logger";
import { LoggingSession } from "./logging-session";
import { AutorestLogger, LogInfo } from "./types";

export interface AutorestCoreLoggerOptions {
  logger: AutorestLogger;
}

export class AutorestCoreLogger extends AutorestLoggerBase {
  private logInfoEnhancer: LogSourceEnhancer;
  private innerLogger: AutorestLogger;

  public constructor(
    options: AutorestCoreLoggerOptions,
    private asyncLogManager: LoggingSession,
    dataStore: DataStore,
  ) {
    super();
    this.logInfoEnhancer = new LogSourceEnhancer(dataStore);
    this.innerLogger = options.logger;
  }

  public log(log: LogInfo) {
    this.asyncLogManager.registerLog(() => this.logMessageAsync(log));
  }

  public override trackDiagnostic(diagnostic: AutorestDiagnostic) {
    this.asyncLogManager.registerLog(() => this.trackDiagnosticAsync(diagnostic));
  }

  private async logMessageAsync(log: LogInfo) {
    const enhancedLog = await this.logInfoEnhancer.process(log);
    // eslint-disable-next-line no-console
    this.innerLogger.log(enhancedLog as any);
  }

  private async trackDiagnosticAsync(diagnostic: AutorestDiagnostic) {
    const enhancedDiag = await this.logInfoEnhancer.process(diagnostic);
    // eslint-disable-next-line no-console
    this.innerLogger.log(enhancedDiag as any);
    this.diagnostics.push(enhancedDiag as any);
  }
}
