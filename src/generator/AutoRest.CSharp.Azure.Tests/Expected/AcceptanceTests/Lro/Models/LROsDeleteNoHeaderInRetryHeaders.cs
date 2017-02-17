// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsLro.Models
{
    using Fixtures.Azure;
    using Fixtures.Azure.AcceptanceTestsLro;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for deleteNoHeaderInRetry operation.
    /// </summary>
    public partial class LROsDeleteNoHeaderInRetryHeaders
    {
        /// <summary>
        /// Initializes a new instance of the LROsDeleteNoHeaderInRetryHeaders
        /// class.
        /// </summary>
        public LROsDeleteNoHeaderInRetryHeaders() { }

        /// <summary>
        /// Initializes a new instance of the LROsDeleteNoHeaderInRetryHeaders
        /// class.
        /// </summary>
        /// <param name="location">Location to poll for result status: will be
        /// set to /lro/put/noheader/202/204/operationresults</param>
        public LROsDeleteNoHeaderInRetryHeaders(string location = default(string))
        {
            Location = location;
        }

        /// <summary>
        /// Gets or sets location to poll for result status: will be set to
        /// /lro/put/noheader/202/204/operationresults
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
