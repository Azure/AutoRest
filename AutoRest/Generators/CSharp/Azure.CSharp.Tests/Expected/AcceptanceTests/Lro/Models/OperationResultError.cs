// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsLro.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class OperationResultError
    {
        /// <summary>
        /// Initializes a new instance of the OperationResultError class.
        /// </summary>
        public OperationResultError() { }

        /// <summary>
        /// Initializes a new instance of the OperationResultError class.
        /// </summary>
        public OperationResultError(int? code = default(int?), string message = default(string))
        {
            Code = code;
            Message = message;
        }

        /// <summary>
        /// The error code for an operation failure
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public int? Code { get; set; }

        /// <summary>
        /// The detailed arror message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
