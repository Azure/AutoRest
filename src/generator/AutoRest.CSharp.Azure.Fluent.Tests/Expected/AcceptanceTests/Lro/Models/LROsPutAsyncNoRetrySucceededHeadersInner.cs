// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsLro.Models
{
    using Azure;
    using AcceptanceTestsLro;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for putAsyncNoRetrySucceeded operation.
    /// </summary>
    public partial class LROsPutAsyncNoRetrySucceededHeadersInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LROsPutAsyncNoRetrySucceededHeadersInner class.
        /// </summary>
        public LROsPutAsyncNoRetrySucceededHeadersInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// LROsPutAsyncNoRetrySucceededHeadersInner class.
        /// </summary>
        /// <param name="azureAsyncOperation">Location to poll for result
        /// status: will be set to
        /// /lro/putasync/noretry/succeeded/operationResults/200</param>
        /// <param name="location">Location to poll for result status: will be
        /// set to /lro/putasync/noretry/succeeded/operationResults/200</param>
        public LROsPutAsyncNoRetrySucceededHeadersInner(string azureAsyncOperation = default(string), string location = default(string))
        {
            AzureAsyncOperation = azureAsyncOperation;
            Location = location;
        }

        /// <summary>
        /// Gets or sets location to poll for result status: will be set to
        /// /lro/putasync/noretry/succeeded/operationResults/200
        /// </summary>
        [JsonProperty(PropertyName = "Azure-AsyncOperation")]
        public string AzureAsyncOperation { get; set; }

        /// <summary>
        /// Gets or sets location to poll for result status: will be set to
        /// /lro/putasync/noretry/succeeded/operationResults/200
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}

