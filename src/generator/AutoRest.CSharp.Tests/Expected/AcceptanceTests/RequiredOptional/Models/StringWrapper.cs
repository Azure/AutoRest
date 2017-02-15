// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsRequiredOptional.Models
{
    using Fixtures.AcceptanceTestsRequiredOptional;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class StringWrapper
    {
        /// <summary>
        /// Initializes a new instance of the StringWrapper class.
        /// </summary>
        public StringWrapper() { }

        /// <summary>
        /// Initializes a new instance of the StringWrapper class.
        /// </summary>
        public StringWrapper(string value)
        {
            Value = value;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}

