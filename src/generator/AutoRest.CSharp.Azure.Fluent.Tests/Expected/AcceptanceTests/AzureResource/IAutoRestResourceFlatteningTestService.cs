// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureResource
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Resource Flattening for AutoRest
    /// </summary>
    public partial interface IAutoRestResourceFlatteningTestService : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        Microsoft.Rest.ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is
        /// generated and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


            /// <summary>
        /// Put External Resource as an Array
        /// </summary>
        /// <param name='resourceArray'>
        /// External Resource as an Array to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> PutArrayWithHttpMessagesAsync(System.Collections.Generic.IList<ResourceInner> resourceArray = default(System.Collections.Generic.IList<ResourceInner>), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get External Resource as an Array
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<System.Collections.Generic.IList<FlattenedProductInner>>> GetArrayWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Put External Resource as a Dictionary
        /// </summary>
        /// <param name='resourceDictionary'>
        /// External Resource as a Dictionary to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> PutDictionaryWithHttpMessagesAsync(System.Collections.Generic.IDictionary<string, FlattenedProductInner> resourceDictionary = default(System.Collections.Generic.IDictionary<string, FlattenedProductInner>), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get External Resource as a Dictionary
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<System.Collections.Generic.IDictionary<string, FlattenedProductInner>>> GetDictionaryWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Put External Resource as a ResourceCollection
        /// </summary>
        /// <param name='resourceComplexObject'>
        /// External Resource as a ResourceCollection to put
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> PutResourceCollectionWithHttpMessagesAsync(ResourceCollectionInner resourceComplexObject = default(ResourceCollectionInner), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get External Resource as a ResourceCollection
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ResourceCollectionInner>> GetResourceCollectionWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}
