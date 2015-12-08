// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsHeader.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Defines headers for responseDuration operation.
    /// </summary>
    public partial class HeaderResponseDurationHeaders
    {
        /// <summary>
        /// Initializes a new instance of the HeaderResponseDurationHeaders
        /// class.
        /// </summary>
        public HeaderResponseDurationHeaders() { }

        /// <summary>
        /// Initializes a new instance of the HeaderResponseDurationHeaders
        /// class.
        /// </summary>
        public HeaderResponseDurationHeaders(TimeSpan? value = default(TimeSpan?))
        {
            Value = value;
        }

        /// <summary>
        /// response with header values "P123DT22H14M12.011S"
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public TimeSpan? Value { get; set; }

    }
}
