// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureParameterGrouping
{
    using Azure;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ParameterGroupingOperations operations.
    /// </summary>
    public partial interface IParameterGroupingOperations
    {
        /// <summary>
        /// Post a bunch of required parameters grouped
        /// </summary>
        /// <param name='parameterGroupingPostRequiredParameters'>
        /// Additional parameters for the operation
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
        Task<AzureOperationResponse> PostRequiredWithHttpMessagesAsync(ParameterGroupingPostRequiredParameters parameterGroupingPostRequiredParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Post a bunch of optional parameters grouped
        /// </summary>
        /// <param name='parameterGroupingPostOptionalParameters'>
        /// Additional parameters for the operation
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
        Task<AzureOperationResponse> PostOptionalWithHttpMessagesAsync(ParameterGroupingPostOptionalParameters parameterGroupingPostOptionalParameters = default(ParameterGroupingPostOptionalParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Post parameters from multiple different parameter groups
        /// </summary>
        /// <param name='firstParameterGroup'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='parameterGroupingPostMultiParamGroupsSecondParamGroup'>
        /// Additional parameters for the operation
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
        Task<AzureOperationResponse> PostMultiParamGroupsWithHttpMessagesAsync(FirstParameterGroup firstParameterGroup = default(FirstParameterGroup), ParameterGroupingPostMultiParamGroupsSecondParamGroup parameterGroupingPostMultiParamGroupsSecondParamGroup = default(ParameterGroupingPostMultiParamGroupsSecondParamGroup), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Post parameters with a shared parameter group object
        /// </summary>
        /// <param name='firstParameterGroup'>
        /// Additional parameters for the operation
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
        Task<AzureOperationResponse> PostSharedParameterGroupObjectWithHttpMessagesAsync(FirstParameterGroup firstParameterGroup = default(FirstParameterGroup), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
