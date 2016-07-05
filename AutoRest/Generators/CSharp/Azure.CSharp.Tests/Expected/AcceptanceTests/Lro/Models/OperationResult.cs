// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
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

    public partial class OperationResult
    {
        /// <summary>
        /// Initializes a new instance of the OperationResult class.
        /// </summary>
        public OperationResult() { }

        /// <summary>
        /// Initializes a new instance of the OperationResult class.
        /// </summary>
        /// <param name="status">The status of the request. Possible values
        /// include: 'Succeeded', 'Failed', 'canceled', 'Accepted',
        /// 'Creating', 'Created', 'Updating', 'Updated', 'Deleting',
        /// 'Deleted', 'OK'</param>
        public OperationResult(string status = default(string), OperationResultError error = default(OperationResultError))
        {
            Status = status;
            Error = error;
        }

        /// <summary>
        /// Gets or sets the status of the request. Possible values include:
        /// 'Succeeded', 'Failed', 'canceled', 'Accepted', 'Creating',
        /// 'Created', 'Updating', 'Updated', 'Deleting', 'Deleted', 'OK'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public OperationResultError Error { get; set; }

    }
}
