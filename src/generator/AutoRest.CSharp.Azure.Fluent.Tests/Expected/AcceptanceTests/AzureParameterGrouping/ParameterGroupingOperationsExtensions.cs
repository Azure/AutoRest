// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureParameterGrouping
{
    using Fixtures.Azure;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ParameterGroupingOperations.
    /// </summary>
    public static partial class ParameterGroupingOperationsExtensions
    {
            /// <summary>
            /// Post a bunch of required parameters grouped
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameterGroupingPostRequiredParameters'>
            /// Additional parameters for the operation
            /// </param>
            public static void PostRequired(this IParameterGroupingOperations operations, ParameterGroupingPostRequiredParametersInner parameterGroupingPostRequiredParameters)
            {
                operations.PostRequiredAsync(parameterGroupingPostRequiredParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post a bunch of required parameters grouped
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameterGroupingPostRequiredParameters'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostRequiredAsync(this IParameterGroupingOperations operations, ParameterGroupingPostRequiredParametersInner parameterGroupingPostRequiredParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostRequiredWithHttpMessagesAsync(parameterGroupingPostRequiredParameters, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Post a bunch of optional parameters grouped
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameterGroupingPostOptionalParameters'>
            /// Additional parameters for the operation
            /// </param>
            public static void PostOptional(this IParameterGroupingOperations operations, ParameterGroupingPostOptionalParametersInner parameterGroupingPostOptionalParameters = default(ParameterGroupingPostOptionalParametersInner))
            {
                operations.PostOptionalAsync(parameterGroupingPostOptionalParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post a bunch of optional parameters grouped
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameterGroupingPostOptionalParameters'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostOptionalAsync(this IParameterGroupingOperations operations, ParameterGroupingPostOptionalParametersInner parameterGroupingPostOptionalParameters = default(ParameterGroupingPostOptionalParametersInner), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostOptionalWithHttpMessagesAsync(parameterGroupingPostOptionalParameters, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Post parameters from multiple different parameter groups
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='firstParameterGroup'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='parameterGroupingPostMultiParamGroupsSecondParamGroup'>
            /// Additional parameters for the operation
            /// </param>
            public static void PostMultiParamGroups(this IParameterGroupingOperations operations, FirstParameterGroupInner firstParameterGroup = default(FirstParameterGroupInner), ParameterGroupingPostMultiParamGroupsSecondParamGroupInner parameterGroupingPostMultiParamGroupsSecondParamGroup = default(ParameterGroupingPostMultiParamGroupsSecondParamGroupInner))
            {
                operations.PostMultiParamGroupsAsync(firstParameterGroup, parameterGroupingPostMultiParamGroupsSecondParamGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post parameters from multiple different parameter groups
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='firstParameterGroup'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='parameterGroupingPostMultiParamGroupsSecondParamGroup'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostMultiParamGroupsAsync(this IParameterGroupingOperations operations, FirstParameterGroupInner firstParameterGroup = default(FirstParameterGroupInner), ParameterGroupingPostMultiParamGroupsSecondParamGroupInner parameterGroupingPostMultiParamGroupsSecondParamGroup = default(ParameterGroupingPostMultiParamGroupsSecondParamGroupInner), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostMultiParamGroupsWithHttpMessagesAsync(firstParameterGroup, parameterGroupingPostMultiParamGroupsSecondParamGroup, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Post parameters with a shared parameter group object
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='firstParameterGroup'>
            /// Additional parameters for the operation
            /// </param>
            public static void PostSharedParameterGroupObject(this IParameterGroupingOperations operations, FirstParameterGroupInner firstParameterGroup = default(FirstParameterGroupInner))
            {
                operations.PostSharedParameterGroupObjectAsync(firstParameterGroup).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post parameters with a shared parameter group object
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='firstParameterGroup'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostSharedParameterGroupObjectAsync(this IParameterGroupingOperations operations, FirstParameterGroupInner firstParameterGroup = default(FirstParameterGroupInner), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostSharedParameterGroupObjectWithHttpMessagesAsync(firstParameterGroup, null, cancellationToken).ConfigureAwait(false);
            }

    }
}

