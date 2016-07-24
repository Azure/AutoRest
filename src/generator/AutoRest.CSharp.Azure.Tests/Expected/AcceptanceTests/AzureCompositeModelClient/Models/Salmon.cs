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

    [Newtonsoft.Json.JsonObject("salmon")]
    public partial class Salmon : Fish
    {
        /// <summary>
        /// Initializes a new instance of the Salmon class.
        /// </summary>
        public Salmon() { }

        /// <summary>
        /// Initializes a new instance of the Salmon class.
        /// </summary>
        public Salmon(System.Double length, System.String species = default(System.String), System.Collections.Generic.IList<Fish> siblings = default(System.Collections.Generic.IList<Fish>), System.String location = default(System.String), System.Boolean? iswild = default(System.Boolean?))
            : base(length, species, siblings)
        {
            Location = location;
            Iswild = iswild;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public System.String Location { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "iswild")]
        public System.Boolean? Iswild { get; set; }

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
