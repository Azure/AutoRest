// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsLro.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for deleteAsyncNoRetrySucceeded operation.
    /// </summary>
    public partial class LROsDeleteAsyncNoRetrySucceededHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LROsDeleteAsyncNoRetrySucceededHeaders class.
        /// </summary>
        public LROsDeleteAsyncNoRetrySucceededHeaders() { }

        /// <summary>
        /// Initializes a new instance of the
        /// LROsDeleteAsyncNoRetrySucceededHeaders class.
        /// </summary>
        /// <param name="azureAsyncOperation">Location to poll for result
        /// status: will be set to
        /// /lro/deleteasync/noretry/succeeded/operationResults/200</param>
        /// <param name="location">Location to poll for result status: will be
        /// set to
        /// /lro/deleteasync/noretry/succeeded/operationResults/200</param>
        /// <param name="retryAfter">Number of milliseconds until the next
        /// poll should be sent, will be set to zero</param>
        public LROsDeleteAsyncNoRetrySucceededHeaders(System.String azureAsyncOperation = default(System.String), System.String location = default(System.String), System.Int32? retryAfter = default(System.Int32?))
        {
            AzureAsyncOperation = azureAsyncOperation;
            Location = location;
            RetryAfter = retryAfter;
        }

        /// <summary>
        /// Gets or sets location to poll for result status: will be set to
        /// /lro/deleteasync/noretry/succeeded/operationResults/200
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Azure-AsyncOperation")]
        public System.String AzureAsyncOperation { get; set; }

        /// <summary>
        /// Gets or sets location to poll for result status: will be set to
        /// /lro/deleteasync/noretry/succeeded/operationResults/200
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Location")]
        public System.String Location { get; set; }

        /// <summary>
        /// Gets or sets number of milliseconds until the next poll should be
        /// sent, will be set to zero
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Retry-After")]
        public System.Int32? RetryAfter { get; set; }

    }
}
