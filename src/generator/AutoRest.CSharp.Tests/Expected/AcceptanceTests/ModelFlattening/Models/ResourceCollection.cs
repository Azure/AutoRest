// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsModelFlattening.Models
{
    using AcceptanceTestsModelFlattening;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ResourceCollection
    {
        /// <summary>
        /// Initializes a new instance of the ResourceCollection class.
        /// </summary>
        public ResourceCollection() { }

        /// <summary>
        /// Initializes a new instance of the ResourceCollection class.
        /// </summary>
        public ResourceCollection(FlattenedProduct productresource = default(FlattenedProduct), IList<FlattenedProduct> arrayofresources = default(IList<FlattenedProduct>), IDictionary<string, FlattenedProduct> dictionaryofresources = default(IDictionary<string, FlattenedProduct>))
        {
            Productresource = productresource;
            Arrayofresources = arrayofresources;
            Dictionaryofresources = dictionaryofresources;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productresource")]
        public FlattenedProduct Productresource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "arrayofresources")]
        public IList<FlattenedProduct> Arrayofresources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dictionaryofresources")]
        public IDictionary<string, FlattenedProduct> Dictionaryofresources { get; set; }

    }
}

