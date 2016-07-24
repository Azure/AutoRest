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
    /// Defines headers for delete202NonRetry400 operation.
    /// </summary>
    public partial class LROSADsDelete202NonRetry400Headers
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LROSADsDelete202NonRetry400Headers class.
        /// </summary>
        public LROSADsDelete202NonRetry400Headers() { }

        /// <summary>
        /// Initializes a new instance of the
        /// LROSADsDelete202NonRetry400Headers class.
        /// </summary>
        /// <param name="location">Location to poll for result status: will be
        /// set to /lro/retryerror/delete/202/retry/200</param>
        /// <param name="retryAfter">Number of milliseconds until the next
        /// poll should be sent, will be set to zero</param>
        public LROSADsDelete202NonRetry400Headers(System.String location = default(System.String), System.Int32? retryAfter = default(System.Int32?))
        {
            Location = location;
            RetryAfter = retryAfter;
        }

        /// <summary>
        /// Gets or sets location to poll for result status: will be set to
        /// /lro/retryerror/delete/202/retry/200
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
