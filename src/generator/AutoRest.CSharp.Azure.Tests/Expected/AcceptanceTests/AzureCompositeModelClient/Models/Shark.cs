// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using System.Linq;

    [Newtonsoft.Json.JsonObject("shark")]
    public partial class Shark : Fish
    {
        /// <summary>
        /// Initializes a new instance of the Shark class.
        /// </summary>
        public Shark() { }

        /// <summary>
        /// Initializes a new instance of the Shark class.
        /// </summary>
        public Shark(System.Double length, System.DateTime birthday, System.String species = default(System.String), System.Collections.Generic.IList<Fish> siblings = default(System.Collections.Generic.IList<Fish>), System.Int32? age = default(System.Int32?))
            : base(length, species, siblings)
        {
            Age = age;
            Birthday = birthday;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "age")]
        public System.Int32? Age { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "birthday")]
        public System.DateTime Birthday { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
