﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using AutoRest.Swagger;
using AutoRest.Core.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using AutoRest.Swagger.Validation;

namespace AutoRest.Swagger.Model.Utilities
{
    public static class ValidationUtilities
    {
        private static readonly string XmsPageable = "x-ms-pageable";
        private static readonly Regex UrlResRegEx = new Regex(@".+/Resource$", RegexOptions.IgnoreCase);
        private static readonly Regex ResNameRegEx = new Regex(@"Resource$", RegexOptions.IgnoreCase);

        public static bool IsTrackedResource(Schema schema, Dictionary<string, Schema> definitions)
        {
            if (schema.AllOf != null)
            {
                foreach (Schema item in schema.AllOf)
                {
                    if (UrlResRegEx.IsMatch(item.Reference))
                    {
                        return true;
                    }
                    else
                    {
                        return IsTrackedResource(Schema.FindReferencedSchema(item.Reference, definitions), definitions);
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Checks whether a model definition has the properties "id, name and type" (which are "Resource" type properties)
        /// anywhere in its heirarchy
        /// </summary>
        /// <param name="modelName">model for which to check the resource properties</param>
        /// <param name="definitions">dictionary of model definitions</param>
        /// <param name="propertyList">List of properties to be checked for in a model heirarchy</param>
        /// <returns>true if the model heirarchy contains all of the resource model properties</returns>
        private static bool ContainsResourceModelProperties(string modelName, Dictionary<string, Schema> definitions, IEnumerable<string> propertyList)
        {
            if (!definitions.ContainsKey(modelName)) return false;
            var modelSchema = definitions[modelName];

            propertyList = propertyList.Except(modelSchema.Properties.Keys);
            if (!propertyList.Any()) return false;

            if (modelSchema.AllOf?.Any() != true) return false;

            var modelRefNames = modelSchema.AllOf.Select(modelRefSchema => modelRefSchema.Reference?.StripDefinitionPath())
                                    .Where(modelRef=>!string.IsNullOrEmpty(modelRef) && definitions.ContainsKey(modelRef));

            foreach (var modelRef in modelRefNames)
            {
                if (ContainsResourceModelProperties(modelRef, definitions, propertyList)) return true;
            }
            
            return false;
        }

        /// <summary>
        /// Populates a list of 'Resource' models found in the service definition
        /// </summary>
        /// <param name="serviceDefinition">serviceDefinition for which to populate the resources</param>
        /// <returns>List of resource models</returns>
        public static IEnumerable<string> GetResourceModels(ServiceDefinition serviceDefinition)
        {
            // Get all models that are returned by PUT operations (200 response)
            var putOperations = GetOperationsByRequestMethod("put", serviceDefinition)
                                    .Where(op => op.Responses?.ContainsKey("200")==true);
            var putResponseModelNames = putOperations.Select(op => op.Responses["200"]?.Schema?.Reference?.StripDefinitionPath())
                                            .Where(modelName => !string.IsNullOrEmpty(modelName));
            // for each putResponseModel, check if the properties "id, type and name" exist anywhere in its heirarchy
            putResponseModelNames = putResponseModelNames.Where(putRespModel => ContainsResourceModelProperties(putRespModel, serviceDefinition.Definitions, new List<string>() { "id", "name", "type"}));

            // Get all models that 'allOf' on models that are named 'Resource' and are returned by any GET operation
            var getOperationsResponseModels = GetOperationsByRequestMethod("get", serviceDefinition)
                                                .Where(op => op.Responses?.ContainsKey("200") == true)
                                                .Select(op => op.Responses["200"]?.Schema?.Reference?.StripDefinitionPath())
                                                .Where(modelName => !string.IsNullOrEmpty(modelName));

            var modelsAllOfOnResource =
                getOperationsResponseModels.Where(modelName => serviceDefinition.Definitions.ContainsKey(modelName))
                                           .Where(modelName => IsAllOfOnModelNamedResource(modelName, serviceDefinition.Definitions));
            
            // Get all models that have the "x-ms-azure-resource" extension set on them
            var xmsAzureResourceModels =
                serviceDefinition.Definitions
                    .Where(defPair =>
                            defPair.Value.Extensions?.ContainsKey("x-ms-azure-resource") == true &&
                            defPair.Value.Extensions["x-ms-azure-resource"].Equals(true))
                    .Select(defPair => defPair.Key);

            // set of base resource models is the union of all three aboce
            var baseResourceModels = putResponseModelNames.Union(modelsAllOfOnResource).Union(xmsAzureResourceModels);

            // for every model in definitions, recurse its allOfs and discover if there is a baseResourceModel reference
            foreach (var modelName in serviceDefinition.Definitions.Keys)
            {
                // make sure we are excluding models which have the x-ms-azure-resource extension set on them
                if (!xmsAzureResourceModels.Contains(modelName) 
                    && IsAllOfOnResourceTypeModel(modelName, serviceDefinition.Definitions, baseResourceModels)
                    && ResNameRegEx.IsMatch(modelName))
                {
                    yield return modelName;
                }
            }
        }

        /// <summary>
        /// For a given model determines if it allOfs on a model named 'Resource'
        /// </summary>
        /// <param name="modelName">model for which to check the allOfs</param>
        /// <param name="definitions">dictionary of model definitions</param>
        /// <returns>List of resource models</returns>
        public static bool IsAllOfOnModelNamedResource(string modelName, Dictionary<string, Schema> definitions)
        {
            if (!definitions.ContainsKey(modelName)) return false;

            var modelSchema = definitions[modelName];

            if (modelSchema.AllOf?.Any() != true) return false;

            foreach (Schema item in modelSchema.AllOf)
            {
                if (UrlResRegEx.IsMatch(item.Reference))
                {
                    return true;
                }
                else
                {
                    return IsAllOfOnModelNamedResource(item.Reference, definitions);
                }
            }
            return false;
        }

        /// <summary>
        /// For a given model, recursively traverses its allOfs and checks if any of them refer to 
        /// the base resourceModels
        /// </summary>
        /// <param name="modelName">model for which to determine if it is resource model type</param>
        /// <param name="definitions">dictionary that contains model definitions</param>
        /// <param name="baseResourceModels">the list of base resource models</param>
        /// <returns>true if model is of resource model type</returns>
        public static bool IsAllOfOnResourceTypeModel(string modelName, Dictionary<string, Schema> definitions, IEnumerable<string> baseResourceModels)
        {
            // if the model itself is a base resource model, return true
            // there is separate check to weed out resources which
            // a. have x-ms-azure-resource extension set to true
            // b. have the name "Resource"
            if (baseResourceModels.Contains(modelName)) return true;

            // if model can't be found in definitions we can't verify
            if (!definitions.ContainsKey(modelName)) return false;
            
            // if model does not have any allOfs, return early 
            if (definitions[modelName]?.AllOf?.Any() != true) return false;

            // if model allOfs on a base resource type, return true
            if (definitions[modelName].AllOf.Select(modelRef => modelRef.Reference.StripDefinitionPath()).Intersect(baseResourceModels).Any()) return true;

            // recurse into allOfed references
            foreach (var modelRef in definitions[modelName].AllOf.Select(allofModel => allofModel.Reference?.StripDefinitionPath()).Where(allOfModel => !string.IsNullOrEmpty(allOfModel)))
            {
                if (IsAllOfOnResourceTypeModel(modelRef, definitions, baseResourceModels)) return true;
            }

            // if all else fails return false
            return false;
        }


        /// <summary>
        /// For a given set of resource models evaluates which models are tracked and returns those
        /// </summary>
        /// <param name="resourceModels">list of resourceModels from which to evaluate the tracked resources</param>
        /// <param name="definitions">the dictionary of model definitions</param>
        /// <returns>list of tracked resources</returns>
        public static IEnumerable<string> GetTrackedResources(IEnumerable<string> resourceModels, Dictionary<string, Schema> definitions) 
            => resourceModels.Where(resModel => ContainsLocationProperty(resModel, definitions));



        /// <summary>
        /// For a given set of resource models evaluates which models are tracked and returns those
        /// </summary>
        /// <param name="modelName">model for which to check the 'location' property</param>
        /// <param name="definitions">dictionary containing the model definitions</param>
        /// <returns>list of tracked resources</returns>
        private static bool ContainsLocationProperty(string modelName, Dictionary<string, Schema> definitions)
        {
            // if model name is null or empty or not found in definitions, return false
            if (string.IsNullOrEmpty(modelName) || !definitions.ContainsKey(modelName)) return false;

            // if model schema is null, return false
            var modelSchema = definitions[modelName];
            if (modelSchema == null) return false;

            // if model properties has a property named location, return true
            if (modelSchema.Properties?.ContainsKey("location") == true)  return true;

            var allOfedModels = modelSchema.AllOf?.Select(modelRef => modelRef.Reference).Where(modelRef=>!string.IsNullOrEmpty(modelRef));
            if (allOfedModels != null && allOfedModels.Any())
            {
                foreach (var modelRef in allOfedModels)
                {
                    // if any of the allOfed models have a property named location, return true
                    if (ContainsLocationProperty(modelRef.StripDefinitionPath(), definitions)) return true;
                }
            }

            // when all else fails, return false
            return false;
        }

        // determine if an operation is xms pageable operation
        public static bool IsXmsPageableOperation(Operation op)
        {
            // if xmspageable type, return true
            return (op.Extensions.GetValue<object>(XmsPageable) != null);
        }

        // determine if an operation returns an object of array type
        public static bool IsArrayResponseOperation(Operation op, ServiceDefinition entity)
        {
            // if a success response is not defined, we have nothing to check, return false
            if (op.Responses?.ContainsKey("200") != true) return false;

            // if we have a non-null response schema, and the schema is of type array, return true
            if (op.Responses["200"]?.Schema?.Reference?.Equals(string.Empty) == false)
            {
                var modelLink = op.Responses["200"].Schema.Reference;
                // if the object has more than 2 properties, we can assume its a composite object
                // that does not represent a collection of some type
                if ((entity.Definitions[modelLink.StripDefinitionPath()].Properties?.Values?.Count ?? 2) >= 2)
                {
                    return false;
                }

                // if the object is an allof on some other object, let's consider it to be a composite object
                if (entity.Definitions[modelLink.StripDefinitionPath()].AllOf != null)
                {
                    return false;
                }

                if (entity.Definitions[modelLink.StripDefinitionPath()].Properties?.Values?.Any(type => type.Type == DataType.Array) ?? false)
                {
                    return true;
                }
            }

            return false;
        }

        // determine if the operation is xms pageable or returns an object of array type
        public static bool IsXmsPageableOrArrayResponseOperation(Operation op, ServiceDefinition entity)
        {
            if (IsXmsPageableOperation(op) || IsArrayResponseOperation(op, entity))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Returns all operations that match the httpverb (from all paths in service definitions)
        /// </summary>
        /// <param name="id">httpverb to check for</param>
        /// <param name="serviceDefinition">service definition in which to find the operations</param>
        /// <param name="includeCustomPaths">whether to include the x-ms-paths</param>
        /// <returns>list if operations that match the httpverb</returns>
        public static IEnumerable<Operation> GetOperationsByRequestMethod(string id, ServiceDefinition serviceDefinition, bool includeCustomPaths = true)
        {
            var pathOperations = SelectOperationsFromPaths(id, serviceDefinition.Paths);
            if (includeCustomPaths)
            {
                pathOperations.Concat(SelectOperationsFromPaths(id, serviceDefinition.CustomPaths));
            }
            return pathOperations;
        }

        /// <summary>
        /// Returns all operations that match the httpverb
        /// </summary>
        /// <param name="id">httpverb to check for</param>
        /// <param name="paths">paths in which to find the operations with given verb</param>
        /// <returns>list if operations that match the httpverb</returns>
        private static IEnumerable<Operation> SelectOperationsFromPaths(string id, Dictionary<string, Dictionary<string, Operation>> paths)
            => paths.Values.SelectMany(pathObjs=>pathObjs.Where(pair => pair.Key.ToLower().Equals(id.ToLower())).Select(pair => pair.Value));

        /// <summary>
        /// Returns whether a string follows camel case style.
        /// </summary>
        /// <param name="name">String to check for style</param>
        /// <returns>true if "name" follows camel case style, false otherwise.</returns>
        public static bool isNameCamelCase(string name)
        {
            Regex propNameRegEx = new Regex(@"^[a-z0-9]+([A-Z][a-z0-9]+)+|^[a-z0-9]+$|^[a-z0-9]+[A-Z]$");
            return (propNameRegEx.IsMatch(name));
        }

        /// <summary>
        /// Returns a suggestion of camel case styled string based on the string passed as parameter.
        /// </summary>
        /// <param name="name">String to convert to camel case style</param>
        /// <returns>A string that conforms with camel case style based on the string passed as parameter.</returns>
        public static string ToCamelCase(string name)
        {
            StringBuilder sb = new StringBuilder(name);
            if (sb.Length > 0)
            {
                sb[0] = sb[0].ToString().ToLower()[0];
            }
            bool firstUpper = true;
            for (int i = 1; i < name.Length; i++)
            {
                if (char.IsUpper(sb[i]) && firstUpper)
                {
                    firstUpper = false;
                }
                else
                {
                    firstUpper = true;
                    if (char.IsUpper(sb[i]))
                    {
                        sb[i] = sb[i].ToString().ToLower()[0];
                    }
                }
            }
            return sb.ToString();
        }

        public static IEnumerable<KeyValuePair<string, Schema>> GetArmResources(ServiceDefinition serviceDefinition)
        {
            return serviceDefinition.Definitions.Where(defPair=> defPair.Value.Extensions?.ContainsKey("x-ms-azure-resource")==true && (bool?)defPair.Value.Extensions["x-ms-azure-resource"] == true);
        }

        /// <summary>
        /// Evaluates if the reference is of the provided data type.
        /// </summary>
        /// <param name="reference">reference to evaluate</param>
        /// <param name="definitions">definition list</param>
        /// <param name="dataType">Datatype value to evaluate</param>
        /// <returns>true if the reference is of the provided data type. False otherwise.</returns>
        public static bool IsReferenceOfType(string reference, Dictionary<string, Schema> definitions, Model.DataType dataType)
        {
            if (reference == null)
            {
                return false;
            }

            string definitionName = Extensions.StripDefinitionPath(reference);
            Schema schema = definitions.GetValueOrNull(definitionName);
            if (schema == null)
            {
                return false;
            }

            if (schema.Type == dataType || (schema.Type == null && schema.Reference != null && IsReferenceOfType(schema.Reference, definitions, dataType)))
            {
                return true;
            }

            return false;
        }
    }
}
