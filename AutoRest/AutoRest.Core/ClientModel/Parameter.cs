﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.Rest.Generator.ClientModel
{
    /// <summary>
    /// Defines an HTTP method parameter.
    /// </summary>
    public class Parameter
    {
        public Parameter()
        {
            Constraints = new Dictionary<Constraint, string>();
            Extensions = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or sets the parameter name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the parameter name on the wire.
        /// </summary>
        public string SerializedName { get; set; }

        // TODO: disambiguate Type and System.Type, rename IType to IModelType and Type to ModelType
        /// <summary>
        /// Gets or sets the model type.
        /// </summary>
        public IType Type { get; set; }

        /// <summary>
        /// Indicates whether the parameter is required.
        /// </summary>
        public bool IsRequired { get; set; }

        /// <summary>
        /// Reference to the global Property that provides value for the parameter.
        /// </summary>
        public Property GlobalProperty { get; set; }

        /// <summary>
        /// Gets or sets the constraints.
        /// </summary>
        public Dictionary<Constraint, string> Constraints { get; private set; }

        /// <summary>
        /// Gets or sets collection format for array parameters.
        /// </summary>
        public CollectionFormat CollectionFormat { get; set; }

        /// <summary>
        /// Gets or sets parameter location.
        /// </summary>
        public ParameterLocation Location { get; set; }

        /// <summary>
        /// Gets or sets the documentation.
        /// </summary>
        public string Documentation { get; set; }


        /// <summary>
        /// Gets vendor extensions dictionary.
        /// </summary>
        public Dictionary<string, object> Extensions { get; private set; }

        /// <summary>
        /// Returns a string representation of the Parameter object.
        /// </summary>
        /// <returns>
        /// A string representation of the Parameter object.
        /// </returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} {1}", Type, Name);
        }

        /// <summary>
        /// Performs a deep clone of a parameter.
        /// </summary>
        /// <returns>A deep clone of current object.</returns>
        public object Clone()
        {
            Parameter param = (Parameter)this.MemberwiseClone();

            if (param.GlobalProperty != null)
            {
                param.GlobalProperty = (Property)this.GlobalProperty.Clone();    
            }            

            return param;
        }
    }
}