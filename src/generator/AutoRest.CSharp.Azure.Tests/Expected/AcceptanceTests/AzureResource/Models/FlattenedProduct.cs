// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureResource.Models
{
    using System.Linq;

    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class FlattenedProduct : Resource
    {
        /// <summary>
        /// Initializes a new instance of the FlattenedProduct class.
        /// </summary>
        public FlattenedProduct() { }

        /// <summary>
        /// Initializes a new instance of the FlattenedProduct class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="type">Resource Type</param>
        /// <param name="location">Resource Location</param>
        /// <param name="name">Resource Name</param>
        public FlattenedProduct(System.String id = default(System.String), System.String type = default(System.String), System.Collections.Generic.IDictionary<System.String, System.String> tags = default(System.Collections.Generic.IDictionary<System.String, System.String>), System.String location = default(System.String), System.String name = default(System.String), System.String pname = default(System.String), System.Int32? lsize = default(System.Int32?), System.String provisioningState = default(System.String))
            : base(id, type, tags, location, name)
        {
            Pname = pname;
            Lsize = lsize;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.pname")]
        public System.String Pname { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.lsize")]
        public System.Int32? Lsize { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public System.String ProvisioningState { get; set; }

    }
}
