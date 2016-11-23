﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using AutoRest.Core.Model;
using AutoRest.Core.Extensibility;
using AutoRest.Core.Logging;
using AutoRest.Core.Properties;
using AutoRest.Core.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IAnyPlugin = AutoRest.Core.Extensibility.IPlugin<AutoRest.Core.Extensibility.IGeneratorSettings, AutoRest.Core.IModelSerializer<AutoRest.Core.Model.CodeModel>, AutoRest.Core.ITransformer, AutoRest.Core.CodeGenerator, AutoRest.Core.CodeNamer, AutoRest.Core.Model.CodeModel>;

namespace AutoRest.Core
{
    /// <summary>
    /// Entry point for invoking code generation.
    /// </summary>
    public static class AutoRestController
    {
        /// <summary>
        /// Returns the version of this instance of AutoRest.
        /// </summary>
        public static string Version
        {
            get
            {
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo((typeof(Settings)).Assembly.Location);
                return fvi.FileVersion;
            }
        }

        /// <summary>
        /// Generates client using provided settings.
        /// </summary>
        public static async Task Generate()
        {
            if (Settings.Instance == null)
            {
                throw new ArgumentNullException("settings");
            }
            Logger.Entries.Clear();
            Logger.LogInfo(Resources.AutoRestCore, Version);
            Settings.Instance.Validate();
            if (string.IsNullOrWhiteSpace(Settings.Instance.Input))
            {
                throw ErrorManager.CreateError(Resources.InputRequired);
            }

            IAnyPlugin plugin = ExtensionsLoader.GetPlugin();
            Logger.WriteOutput(plugin.CodeGenerator.UsageInstructions);
            var validator = new RecursiveObjectValidator(PropertyNameResolver.JsonName);

            // FIXED SCHEDULE
            var messages = new List<ValidationMessage>();
            var schedule = Schedule.FromLinearPipeline(
                ExtensionsLoader.GetParser(),
                new ActionTransformer<object>("SwaggerValidation", serviceDefinition => messages.AddRange(validator.GetValidationExceptions(serviceDefinition))),
                new ActionTransformer<object>("Logging", codeModel =>
                {
                    foreach (var message in messages)
                    {
                        Logger.Entries.Add(new LogEntry(message.Severity, message.ToString()));
                    }

                    if (messages.Any(entry => entry.Severity >= Settings.Instance.ValidationLevel))
                    {
                        throw ErrorManager.CreateError(null, Resources.ErrorGeneratingClientModel,
                            "Errors found during Swagger validation");
                    }
                }),
                ExtensionsLoader.GetModeler(),
                new ActionTransformer<CodeModel>("update plugin", _ => Settings.PopulateSettings(plugin.Settings, Settings.Instance.CustomSettings)),
                new FuncTransformer<CodeModel, string>("model2json", codeModel => new ModelSerializer<CodeModel>().ToJson(codeModel)),
                new FuncTransformer<string, CodeModel>("json2model", json => plugin.Serializer.Load(json)).WithPlugin(plugin),
                plugin.Transformer.WithPlugin(plugin),
                new ActionTransformer<CodeModel>("generate code", plugin.CodeGenerator.Generate).WithPlugin(plugin)
                // TODO: return MemoryFS containing code
            );

                    
            //Logger.LogInfo(Resources.ParsingSwagger);
            var input = Settings.Instance.FileSystem.ReadFileAsText(Settings.Instance.Input);

            await schedule.Run(input);
            // TODO: write MemoryFS out
        }

        /// <summary>
        /// Compares two specifications.
        /// </summary>
        public static void Compare()
        {
            if (Settings.Instance == null)
            {
                throw new ArgumentNullException("settings");
            }
            Logger.Entries.Clear();
            Logger.LogInfo(Resources.AutoRestCore, Version);
            Modeler modeler = ExtensionsLoader.GetModeler();

            try
            {
                IEnumerable<ComparisonMessage> messages = modeler.Compare();

                foreach (var message in messages)
                {
                    Logger.Entries.Add(new LogEntry(message.Severity, message.ToString()));
                }

            }
            catch (Exception exception)
            {
                throw ErrorManager.CreateError(exception, Resources.ErrorGeneratingClientModel, exception.Message);
            }

        }
    }
}
