// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsCustomBaseUriMoreOptions
{
    using Models;
    using Newtonsoft.Json;
    using System.Net.Http;

    /// <summary>
    /// Test Infrastructure for AutoRest
    /// </summary>
    public partial interface IAutoRestParameterizedCustomHostTestClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// The subscription id with value 'test12'.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// A string value that is used as a global part of the parameterized
        /// host. Default value 'host'.
        /// </summary>
        string DnsSuffix { get; set; }


        /// <summary>
        /// Gets the IPaths.
        /// </summary>
        IPaths Paths { get; }

    }
}
