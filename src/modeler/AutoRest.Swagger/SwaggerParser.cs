﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Globalization;
using System.Threading.Tasks;
using AutoRest.Core;
using AutoRest.Core.Logging;
using AutoRest.Swagger.JsonConverters;
using AutoRest.Swagger.Model;
using AutoRest.Swagger.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AutoRest.Swagger
{
    public class SwaggerParser : Transformer<string, ServiceDefinition>
    {
        public override Task<ServiceDefinition> TransformAsync(string swaggerDocument)
        {
            try
            {
                swaggerDocument = swaggerDocument.EnsureYamlIsJson();
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.None,
                    MetadataPropertyHandling = MetadataPropertyHandling.Ignore
                };
                settings.Converters.Add(new ResponseRefConverter(swaggerDocument));
                settings.Converters.Add(new PathItemRefConverter(swaggerDocument));
                settings.Converters.Add(new PathLevelParameterConverter(swaggerDocument));
                settings.Converters.Add(new SchemaRequiredItemConverter());
                settings.Converters.Add(new SecurityDefinitionConverter());
                var swaggerService = JsonConvert.DeserializeObject<ServiceDefinition>(swaggerDocument, settings);

                // Extract all external references
                JObject jObject = JObject.Parse(swaggerDocument);
                foreach (JValue value in jObject.SelectTokens("$..$ref"))
                {
                    var path = (string)value;
                    if (path != null && path.Split(new[] {'#'}, StringSplitOptions.RemoveEmptyEntries).Length == 2)
                    {
                        swaggerService.ExternalReferences.Add(path);
                    }
                }

                return Task.FromResult(swaggerService);
            }
            catch (JsonException ex)
            {
                throw ErrorManager.CreateError(string.Format(CultureInfo.InvariantCulture, "{0}. {1}",
                    Resources.ErrorParsingSpec, ex.Message), ex);
            }
        }

        public ServiceDefinition GetServiceDefinition()
        {
            return TransformAsync(Settings.Instance.FileSystem.ReadFileAsText(Settings.Instance.Input)).GetAwaiter().GetResult();
        }
    }
}