﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using AutoRest.Core.Logging;
using AutoRest.Core.Validation;
using AutoRest.Swagger.Model.Utilities;
using System.Collections.Generic;
using AutoRest.Swagger.Model;
using System.Text.RegularExpressions;
using System.Linq;

namespace AutoRest.Swagger.Validation
{
    public class TrackedResourcePatchOperationValidation : TypedRule<Dictionary<string, Schema>>
    {
        private readonly Regex resNames = new Regex(@"(RESOURCE|TRACKEDRESOURCE)$", RegexOptions.IgnoreCase);
        
        /// <summary>
        /// The template message for this Rule. 
        /// </summary>
        /// <remarks>
        /// This may contain placeholders '{0}' for parameterized messages.
        /// </remarks>
        public override string MessageTemplate => "Tracked resource {0} must have patch operation that at least supports the update of tags.";

        /// <summary>
        /// The severity of this message (ie, debug/info/warning/error/fatal, etc)
        /// </summary>
        public override Category Severity => Category.Warning;

        /// <summary>
        /// Overridable method that lets a child rule return multiple validation messages for the <paramref name="entity"/>
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public override IEnumerable<ValidationMessage> GetValidationMessages(Dictionary<string, Schema> definitions, RuleContext context)
        {
            List<Operation> patchOperations = ValidationUtilities.GetOperationsByRequestMethod("patch", (ServiceDefinition)context.Root);
            foreach (KeyValuePair<string, Schema> definition in definitions)
            {
                if (resNames.IsMatch(definition.Key) || ValidationUtilities.IsTrackedResource(definition.Value, definitions))
                {
                    if(!patchOperations.Any(op => (op.Responses["200"].Schema?.Reference?.StripDefinitionPath()??string.Empty) == definition.Key))
                    {
                        // if no patch operation returns current tracked resource as a response, 
                        // the tracked resource does not have a corresponding patch operation, grounds to call
                        // the swagger invalid!
                        yield return new ValidationMessage(new FileObjectPath(context.File, context.Path), this, definition.Key.StripDefinitionPath());
                    }
                }
            }
        }
    }
}
