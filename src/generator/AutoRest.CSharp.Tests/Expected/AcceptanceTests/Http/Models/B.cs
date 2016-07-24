// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsHttp.Models
{
    using System.Linq;

    public partial class B : A
    {
        /// <summary>
        /// Initializes a new instance of the B class.
        /// </summary>
        public B() { }

        /// <summary>
        /// Initializes a new instance of the B class.
        /// </summary>
        public B(System.String statusCode = default(System.String), System.String textStatusCode = default(System.String))
            : base(statusCode)
        {
            TextStatusCode = textStatusCode;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "textStatusCode")]
        public System.String TextStatusCode { get; set; }

    }
}
