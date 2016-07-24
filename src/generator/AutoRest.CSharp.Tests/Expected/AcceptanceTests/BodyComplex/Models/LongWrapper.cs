// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsBodyComplex.Models
{
    using System.Linq;

    public partial class LongWrapper
    {
        /// <summary>
        /// Initializes a new instance of the LongWrapper class.
        /// </summary>
        public LongWrapper() { }

        /// <summary>
        /// Initializes a new instance of the LongWrapper class.
        /// </summary>
        public LongWrapper(System.Int64? field1 = default(System.Int64?), System.Int64? field2 = default(System.Int64?))
        {
            Field1 = field1;
            Field2 = field2;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "field1")]
        public System.Int64? Field1 { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "field2")]
        public System.Int64? Field2 { get; set; }

    }
}
