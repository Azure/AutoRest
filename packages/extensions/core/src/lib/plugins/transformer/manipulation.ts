/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { DataHandle, DataSink, nodes } from "@azure-tools/datastore";
import { YieldCPU } from "@azure-tools/tasks";
import { AutorestContext } from "../../autorest-core";
import { Channel, Message, SourceLocation } from "../../message";
import { manipulateObject } from "./object-manipulator";
import { evalDirectiveTest, evalDirectiveTransform } from "./eval";
import { ResolvedDirective, resolveDirectives } from "@autorest/configuration";

export class Manipulator {
  private transformations: ResolvedDirective[];

  public constructor(private context: AutorestContext) {
    this.transformations = resolveDirectives(
      context.config,
      (directive) => directive.from.length > 0 && directive.transform.length > 0 && directive.where.length > 0,
    );
  }

  private matchesSourceFilter(document: string, transform: ResolvedDirective, artifact: string | null): boolean {
    document = "/" + document;
    return transform.from.find((x) => artifact === x || document.endsWith("/" + x)) !== undefined;
  }

  private async processInternal(data: DataHandle, sink: DataSink, documentId?: string): Promise<DataHandle> {
    for (const directive of this.transformations) {
      data = await this.processDirective(directive, data, sink, documentId);
    }

    return data;
  }

  private async processDirective(directive: ResolvedDirective, data: DataHandle, sink: DataSink, documentId?: string) {
    const match = this.matchesSourceFilter(documentId || data.key, directive, data.artifactType);

    if (directive.debug) {
      const action = match ? "will" : "will not";
      this.context.debug(
        `Directive \`${directive.name}\` **${action}** run on document \`${data.description} (${data.artifactType})\``,
      );
    }
    // matches filter?
    if (!match) {
      return data;
    }

    try {
      for (const where of directive.where) {
        // transform
        for (const transformCode of directive.transform) {
          await YieldCPU();
          if (directive.debug) {
            this.context.debug(`Running \`${where}\` transform:\n------------\n ${transformCode}\n----------------`);
          }
          const result = await this.processDirectiveTransform(data, sink, where, transformCode, directive.debug);
          data = result.result;
        }

        // test
        for (const testCode of directive.test) {
          const doc = await data.readObject<any>();
          const allHits = nodes(doc, where);
          for (const hit of allHits) {
            const testResults = evalDirectiveTest(testCode, {
              value: hit.value,
              doc: doc,
              path: hit.path,
            });

            for (const testResult of testResults) {
              if (testResult === false || typeof testResult !== "boolean") {
                const messageText = typeof testResult === "string" ? testResult : "Custom test failed";
                const message = (<Message>testResult).Text
                  ? <Message>testResult
                  : <Message>{ Text: messageText, Channel: Channel.Warning, Details: testResult };
                message.Source = message.Source || [<SourceLocation>{ Position: { path: hit.path } }];
                for (const src of message.Source) {
                  src.document = src.document || data.key;
                }
                this.context.Message(message);
              }
            }
          }
        }
      }
    } catch {
      // TODO: Temporary comment. First I will make the modifiers for PowerShell work. It shouldn't fail with PowerShell modifiers.
      // throw Error(`Directive given has something wrong. - ${JSON.stringify(trans['directive'], null, 2)} - It could be badly formatted or not being declared. Please check your configuration file. `);
    }

    return data;
  }

  private processDirectiveTransform(
    data: DataHandle,
    sink: DataSink,
    where: string,
    transformCode: string,
    debug: boolean,
  ): Promise<{ anyHit: boolean; result: DataHandle }> {
    return manipulateObject(
      data,
      sink,
      where,
      (doc, obj, path) =>
        evalDirectiveTransform(transformCode, {
          config: this.context,
          value: obj,
          doc: doc,
          path: path,
          documentPath: data.originalFullPath,
        }),
      this.context,
      transformCode,
      debug,
    );
  }

  public async process(data: DataHandle, sink: DataSink, isObject: boolean, documentId?: string): Promise<DataHandle> {
    const trans1 = !isObject
      ? await sink.writeObject(`trans_input?${data.key}`, await data.readData(), data.identity, data.artifactType)
      : data;
    const result = await this.processInternal(trans1, sink, documentId);
    return !isObject
      ? sink.writeData(`trans_output?${data.key}`, await result.readObject<string>(), data.identity, data.artifactType)
      : result;
  }
}
