// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials.Models
{
    using Azure;
    using AcceptanceTestsAzureSpecials;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class OdataFilter
    {
        /// <summary>
        /// Initializes a new instance of the OdataFilter class.
        /// </summary>
        public OdataFilter() { }

        /// <summary>
        /// Initializes a new instance of the OdataFilter class.
        /// </summary>
        public OdataFilter(int? id = default(int?), string name = default(string))
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}

