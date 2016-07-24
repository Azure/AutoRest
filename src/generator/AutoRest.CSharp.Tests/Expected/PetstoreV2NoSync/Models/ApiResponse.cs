// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.PetstoreV2NoSync.Models
{
    using System.Linq;

    public partial class ApiResponse
    {
        /// <summary>
        /// Initializes a new instance of the ApiResponse class.
        /// </summary>
        public ApiResponse() { }

        /// <summary>
        /// Initializes a new instance of the ApiResponse class.
        /// </summary>
        public ApiResponse(System.Int32? code = default(System.Int32?), System.String type = default(System.String), System.String message = default(System.String))
        {
            Code = code;
            Type = type;
            Message = message;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public System.Int32? Code { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public System.String Type { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public System.String Message { get; set; }

    }
}
