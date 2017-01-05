// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsPaging.Models
{
    using Azure;
    using AcceptanceTestsPaging;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ProductInner
    {
        /// <summary>
        /// Initializes a new instance of the ProductInner class.
        /// </summary>
        public ProductInner() { }

        /// <summary>
        /// Initializes a new instance of the ProductInner class.
        /// </summary>
        public ProductInner(ProductProperties properties = default(ProductProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ProductProperties Properties { get; set; }

    }
}

