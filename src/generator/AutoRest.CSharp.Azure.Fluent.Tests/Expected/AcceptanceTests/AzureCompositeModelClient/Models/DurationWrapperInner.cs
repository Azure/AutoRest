// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient.Models
{
    using Fixtures.AcceptanceTestsAzureCompositeModelClient;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DurationWrapperInner
    {
        /// <summary>
        /// Initializes a new instance of the DurationWrapperInner class.
        /// </summary>
        public DurationWrapperInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DurationWrapperInner class.
        /// </summary>
        public DurationWrapperInner(System.TimeSpan? field = default(System.TimeSpan?))
        {
            Field = field;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "field")]
        public System.TimeSpan? Field { get; set; }

    }
}
