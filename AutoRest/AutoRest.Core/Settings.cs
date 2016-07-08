﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Rest.Generator.Logging;
using Microsoft.Rest.Generator.Properties;
using Microsoft.Rest.Generator.Utilities;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.Rest.Generator
{
    public class Settings : BaseSettings
    {
        public const string DefaultCodeGenerationHeader = @"Code generated by Microsoft (R) AutoRest Code Generator {0}
Changes may cause incorrect behavior and will be lost if the code is regenerated.";

        public const string DefaultCodeGenerationHeaderWithoutVersion = @"Code generated by Microsoft (R) AutoRest Code Generator.
Changes may cause incorrect behavior and will be lost if the code is regenerated.";

        public const string MicrosoftApacheLicenseHeader = @"Copyright (c) Microsoft and contributors.  All rights reserved.

Licensed under the Apache License, Version 2.0 (the ""License"");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
  http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an ""AS IS"" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

See the License for the specific language governing permissions and
limitations under the License.
";

        public const string MicrosoftMitLicenseHeader = @"Copyright (c) Microsoft Corporation. All rights reserved.
Licensed under the MIT License. See License.txt in the project root for license information.
";

        private string _header;

        public Settings()
        {
            OutputDirectory = Path.Combine(Environment.CurrentDirectory, "Generated");
            Header = string.Format(CultureInfo.InvariantCulture, DefaultCodeGenerationHeader, AutoRest.Version);
            CodeGenerator = "CSharp";
        }

        // The CommandLineInfo attribute is reflected to display help.
        // Prefer to show required properties before optional.
        // Although not guaranteed by the Framework, the iteration order matches the
        // order of definition.

        #region ordered_properties

        /// <summary>
        /// Gets or sets a base namespace for generated code.
        /// </summary>
        [SettingsInfo("The namespace to use for generated code.")]
        [SettingsAlias("n")]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or sets the output directory for generated files. If not specified, uses 'Generated' as the default.
        /// </summary>
        [SettingsInfo("The location for generated files. If not specified, uses \"Generated\" as the default.")]
        [SettingsAlias("o")]
        [SettingsAlias("output")]
        public string OutputDirectory { get; set; }

        /// <summary>
        /// Gets or sets the code generation language.
        /// </summary>
        [SettingsInfo("The code generator language. If not specified, defaults to CSharp.")]
        [SettingsAlias("g")]
        public string CodeGenerator { get; set; }

        #endregion

        /// <summary>
        /// Gets or sets a name of the generated client type. If not specified, will use
        /// a value from the specification. For Swagger specifications,
        /// the value of the 'Title' field is used.
        /// </summary>
        [SettingsInfo("Name to use for the generated client type. By default, uses " +
                      "the value of the 'Title' field from the Swagger input.")]
        [SettingsAlias("name")]
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of properties in the request body.
        /// If the number of properties in the request body is less than or
        /// equal to this value, then these properties will be represented as method arguments.
        /// </summary>
        [SettingsInfo("The maximum number of properties in the request body. " +
                      "If the number of properties in the request body is less " +
                      "than or equal to this value, these properties will " +
                      "be represented as method arguments.")]
        [SettingsAlias("ft")]
        public int PayloadFlatteningThreshold { get; set; }

        /// <summary>
        /// Gets or sets a comment header to include in each generated file.
        /// </summary>
        [SettingsInfo("Text to include as a header comment in generated files. " +
                      "Use NONE to suppress the default header.")]
        [SettingsAlias("header")]
        public string Header
        {
            get { return _header; }
            set
            {
                if (value == "MICROSOFT_MIT")
                {
                    _header = MicrosoftMitLicenseHeader + Environment.NewLine + string.Format(CultureInfo.InvariantCulture, DefaultCodeGenerationHeader, AutoRest.Version);
                }
                else if (value == "MICROSOFT_APACHE")
                {
                    _header = MicrosoftApacheLicenseHeader + Environment.NewLine + string.Format(CultureInfo.InvariantCulture, DefaultCodeGenerationHeader, AutoRest.Version);
                }
                else if (value == "MICROSOFT_MIT_NO_VERSION")
                {
                    _header = MicrosoftMitLicenseHeader + Environment.NewLine + DefaultCodeGenerationHeaderWithoutVersion;
                }
                else if (value == "MICROSOFT_APACHE_NO_VERSION")
                {
                    _header = MicrosoftApacheLicenseHeader + Environment.NewLine + DefaultCodeGenerationHeaderWithoutVersion;
                }
                else if (value == "MICROSOFT_MIT_NO_CODEGEN")
                {
                    _header = MicrosoftMitLicenseHeader;
                }
                else if (value == "NONE")
                {
                    _header = String.Empty;
                }
                else
                {
                    _header = value;
                }
            }
        }

        /// <summary>
        /// If set to true, generate client with a ServiceClientCredentials property and optional constructor parameter.
        /// </summary>
        [SettingsInfo(
            "If true, the generated client includes a ServiceClientCredentials property and constructor parameter. " +
            "Authentication behaviors are implemented by extending the ServiceClientCredentials type.")]
        public bool AddCredentials { get; set; }

        /// <summary>
        /// If set, will cause generated code to be output to a single file. Not supported by all code generators.
        /// </summary>
        [SettingsInfo(
            "If set, will cause generated code to be output to a single file. Not supported by all code generators.")]
        public string OutputFileName { get; set; }

        /// <summary>
        /// If set to true, print out all messages.
        /// </summary>
        [SettingsAlias("verbose")]
        public bool Verbose { get; set; }

        /// <summary>
        /// PackageName of then generated code package. Should be then names wanted for the package in then package manager.
        /// </summary>
        [SettingsAlias("pn")]
        [SettingsInfo("Package name of then generated code package. Should be then names wanted for the package in then package manager.")]
        public string PackageName { get; set; }

        /// <summary>
        /// PackageName of then generated code package. Should be then names wanted for the package in then package manager.
        /// </summary>
        [SettingsAlias("pv")]
        [SettingsInfo("Package version of then generated code package. Should be then version wanted for the package in then package manager.")]
        public string PackageVersion { get; set; }

        [SettingsAlias("cgs")]
        [SettingsInfo("The path for a json file containing code generation settings.")]
        public string CodeGenSettings { get; set; }
        /// <summary>
        /// Factory method to generate CodeGenerationSettings from command line arguments.
        /// Matches dictionary keys to the settings properties.
        /// </summary>
        /// <param name="arguments">Command line arguments</param>
        /// <returns>CodeGenerationSettings</returns>
        public new static Settings Create(string[] arguments)
        {
            var argsDictionary = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            if (arguments != null && arguments.Length > 0)
            {
                string key = null;
                string value = null;
                for (int i = 0; i < arguments.Length; i++)
                {
                    string argument = arguments[i] ?? String.Empty;
                    argument = argument.Trim();

                    if (argument.StartsWith("-", StringComparison.OrdinalIgnoreCase))
                    {
                        if (key != null)
                        {
                            AddArgumentToDictionary(key, value, argsDictionary);
                            value = null;
                        }
                        key = argument.TrimStart('-');
                    }
                    else
                    {
                        value = argument;
                    }
                }
                AddArgumentToDictionary(key, value, argsDictionary);
            }
            else
            {
                argsDictionary["?"] = String.Empty;
            }

            return Create(argsDictionary);
        }

        /// <summary>
        /// Factory method to generate Settings from a dictionary. Matches dictionary
        /// keys to the settings properties.
        /// </summary>
        /// <param name="settings">Dictionary of settings</param>
        /// <returns>Settings</returns>
        public new static Settings Create(IDictionary<string, object> settings)
        {
            var autoRestSettings = new Settings();
            if (settings == null || settings.Count == 0)
            {
                autoRestSettings.ShowHelp = true;
            }

            PopulateSettings(autoRestSettings, settings);

            autoRestSettings.CustomSettings = settings;
            
            if (!string.IsNullOrEmpty(autoRestSettings.CodeGenSettings))
            {
                var settingsContent = autoRestSettings.FileSystem.ReadFileAsText(autoRestSettings.CodeGenSettings);
                var codeGenSettingsDictionary =
                    JsonConvert.DeserializeObject<Dictionary<string, object>>(settingsContent);
                foreach (var pair in codeGenSettingsDictionary)
                {
                    autoRestSettings.CustomSettings[pair.Key] = pair.Value;
                }
            }
            
            return autoRestSettings;
        }

        /// <summary>
        /// Sets object properties from the dictionary matching keys to property names or aliases.
        /// </summary>
        /// <param name="entityToPopulate">Object to populate from dictionary.</param>
        /// <param name="settings">Dictionary of settings.Settings that are populated get removed from the dictionary.</param>
        /// <returns>Dictionary of settings that were not matched.</returns>
        public new static void PopulateSettings(object entityToPopulate, IDictionary<string, object> settings)
        {
            if (entityToPopulate == null)
            {
                throw new ArgumentNullException("entityToPopulate");
            }

            if (settings != null && settings.Count > 0)
            {
                // Setting property value from dictionary
                foreach (var setting in settings.ToArray())
                {
                    PropertyInfo property = entityToPopulate.GetType().GetProperties()
                        .FirstOrDefault(p => setting.Key.Equals(p.Name, StringComparison.OrdinalIgnoreCase) ||
                                             CustomAttributeExtensions.GetCustomAttributes<SettingsAliasAttribute>(p)
                                                .Any(a => setting.Key.Equals(a.Alias, StringComparison.OrdinalIgnoreCase)));

                    if (property != null)
                    {
                        try
                        {
                            if (property.PropertyType == typeof(bool) && (setting.Value == null || setting.Value.ToString().IsNullOrEmpty()))
                            {
                                property.SetValue(entityToPopulate, true);
                            }
                            else if (property.PropertyType.IsEnum)
                            {
                                property.SetValue(entityToPopulate, Enum.Parse(property.PropertyType, setting.Value.ToString(), true));
                            }
                            else if (property.PropertyType.IsArray && setting.Value.GetType() == typeof(JArray))
                            {
                                var elementType = property.PropertyType.GetElementType();
                                if (elementType == typeof(string))
                                {
                                    var stringArray = ((JArray) setting.Value).Children().
                                    Select(
                                        c => c.ToString())
                                    .ToArray();
  
                                    property.SetValue(entityToPopulate, stringArray);
                                }
                                else if (elementType == typeof (int))
                                {
                                    var intValues = ((JArray)setting.Value).Children().
                                         Select(c => (int)Convert.ChangeType(c, elementType, CultureInfo.InvariantCulture))
                                         .ToArray();
                                    property.SetValue(entityToPopulate, intValues);
                                }
                            }
                            else
                            {
                                property.SetValue(entityToPopulate,
                                    Convert.ChangeType(setting.Value, property.PropertyType, CultureInfo.InvariantCulture), null);
                            }

                            settings.Remove(setting.Key);
                        }
                        catch (Exception exception)
                        {
                            throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Resources.ParameterValueIsNotValid,
                                setting.Key, property.GetType().Name), exception);
                        }
                    }
                }
            }
        }

        public void Validate()
        {
            foreach (PropertyInfo property in (typeof (Settings)).GetProperties())
            {
                // If property value is not set - throw exception.
                var doc = CustomAttributeExtensions.GetCustomAttributes<SettingsInfoAttribute>(property).FirstOrDefault();
                if (doc != null && doc.IsRequired && property.GetValue(this) == null)
                {
                    Logger.LogError(new ArgumentException(property.Name),
                        Resources.ParameterValueIsMissing, property.Name);
                }
            }

            if (CustomSettings != null)
            {
                foreach (var unmatchedSetting in CustomSettings.Keys)
                {
                    Logger.LogWarning(Resources.ParameterIsNotValid, unmatchedSetting);
                }
            }
            ErrorManager.ThrowErrors();
        }
    }
}
