﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using AutoRest.Core.Logging;
using AutoRest.Core.Properties;
using AutoRest.Swagger.Model.Utilities;
using System.Collections.Generic;
using AutoRest.Swagger.Model;
using System.Linq;
using AutoRest.Swagger.Validation.Core;

namespace AutoRest.Swagger.Validation
{
    public class TrackedResourceGetOperationValidation : TypedRule<Dictionary<string, Schema>>
    {
        /// <summary>
        /// Id of the Rule.
        /// </summary>
        public override string Id => "M3027";

        /// <summary>
        /// Violation category of the Rule.
        /// </summary>
        public override ValidationCategory ValidationCategory => ValidationCategory.RPCViolation;

        /// <summary>
        /// The template message for this Rule. 
        /// </summary>
        /// <remarks>
        /// This may contain placeholders '{0}' for parameterized messages.
        /// </remarks>
        public override string MessageTemplate => Resources.TrackedResourceGetOperationMissing;

        /// <summary>
        /// The severity of this message (ie, debug/info/warning/error/fatal, etc)
        /// </summary>
        public override Category Severity => Category.Error;

        // Verifies if a tracked resource has a corresponding get operation
        public override bool IsValid(Dictionary<string, Schema> definitions, RuleContext context, out object[] formatParameters)
        {
            // Retrieve the list of TrackedResources
            IEnumerable<string> trackedResources = context.TrackedResourceModels;

            // Retrieve the list of getOperations
            IEnumerable<Operation> getOperations = ValidationUtilities.GetOperationsByRequestMethod("get", context.Root);

            foreach (string trackedResource in trackedResources)
            {
                // check for 200 status response models since they correspond to a successful get operation
                if (!getOperations.Any(op => op.Responses.ContainsKey("200") && (op.Responses["200"]?.Schema?.Reference?.StripDefinitionPath()).Equals(trackedResource)))
                {
                    formatParameters = new object[1];
                    formatParameters[0] = trackedResource;
                    return false;
                }
            }

            formatParameters = new object[0];
            return true;
        }
    }
}
