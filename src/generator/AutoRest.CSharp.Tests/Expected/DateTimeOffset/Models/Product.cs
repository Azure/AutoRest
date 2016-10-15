// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.DateTimeOffset.Models
{
    using System.Linq;

    [System.Runtime.Serialization.DataContract]
    public partial class Product
    {
        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product() { }


        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateJsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "date")]
        [System.Runtime.Serialization.DataMember(Name = "date", EmitDefaultValue = false)]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dateTime")]
        [System.Runtime.Serialization.DataMember(Name = "dateTime", EmitDefaultValue = false)]
        public System.DateTimeOffset? DateTime { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dateArray")]
        [System.Runtime.Serialization.DataMember(Name = "dateArray", EmitDefaultValue = false)]
        public System.Collections.Generic.IList<System.DateTime?> DateArray { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dateTimeArray")]
        [System.Runtime.Serialization.DataMember(Name = "dateTimeArray", EmitDefaultValue = false)]
        public System.Collections.Generic.IList<System.DateTimeOffset?> DateTimeArray { get; set; }

    }
}
