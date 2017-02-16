// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsHttp.Models
{
    using Fixtures.AcceptanceTestsHttp;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class C
    {
        /// <summary>
        /// Initializes a new instance of the C class.
        /// </summary>
        public C() { }

        /// <summary>
        /// Initializes a new instance of the C class.
        /// </summary>
        public C(string httpCode = default(string))
        {
            HttpCode = httpCode;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpCode")]
        public string HttpCode { get; set; }

    }
}
