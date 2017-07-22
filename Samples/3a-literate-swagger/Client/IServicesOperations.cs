// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Swagger
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ServicesOperations operations.
    /// </summary>
    public partial interface IServicesOperations
    {
        /// <summary>
        /// Creates or updates a Search service in the given resource group.
        /// If the Search service already exists, all properties will be
        /// updated with the given values.
        /// <see href="https://msdn.microsoft.com/library/azure/dn832687.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Search service to operate on.
        /// </param>
        /// <param name='parameters'>
        /// The properties to set or update on the Search service.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SearchServiceResource>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, SearchServiceCreateOrUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a Search service in the given resource group, along with
        /// its associated resources.
        /// <see href="https://msdn.microsoft.com/library/azure/dn832692.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the Search service to operate on.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string serviceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of all Search services in the given resource group.
        /// <see href="https://msdn.microsoft.com/library/azure/dn832688.aspx" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group within the current subscription.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SearchServiceListResult>> ListWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
