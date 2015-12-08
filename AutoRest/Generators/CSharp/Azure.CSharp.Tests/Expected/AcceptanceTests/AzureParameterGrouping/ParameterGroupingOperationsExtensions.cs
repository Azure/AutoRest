// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureParameterGrouping
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

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
            public static void PostRequired(this IParameterGroupingOperations operations, ParameterGroupingPostRequiredParameters parameterGroupingPostRequiredParameters)
            {
                Task.Factory.StartNew(s => ((IParameterGroupingOperations)s).PostRequiredAsync(parameterGroupingPostRequiredParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            public static async Task PostRequiredAsync( this IParameterGroupingOperations operations, ParameterGroupingPostRequiredParameters parameterGroupingPostRequiredParameters, CancellationToken cancellationToken = default(CancellationToken))
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
            public static void PostOptional(this IParameterGroupingOperations operations, ParameterGroupingPostOptionalParameters parameterGroupingPostOptionalParameters = default(ParameterGroupingPostOptionalParameters))
            {
                Task.Factory.StartNew(s => ((IParameterGroupingOperations)s).PostOptionalAsync(parameterGroupingPostOptionalParameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            public static async Task PostOptionalAsync( this IParameterGroupingOperations operations, ParameterGroupingPostOptionalParameters parameterGroupingPostOptionalParameters = default(ParameterGroupingPostOptionalParameters), CancellationToken cancellationToken = default(CancellationToken))
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
            /// <param name='parameterGroupingPostMultipleParameterGroupsSecondParameterGroup'>
            /// Additional parameters for the operation
            /// </param>
            public static void PostMultipleParameterGroups(this IParameterGroupingOperations operations, FirstParameterGroup firstParameterGroup = default(FirstParameterGroup), ParameterGroupingPostMultipleParameterGroupsSecondParameterGroup parameterGroupingPostMultipleParameterGroupsSecondParameterGroup = default(ParameterGroupingPostMultipleParameterGroupsSecondParameterGroup))
            {
                Task.Factory.StartNew(s => ((IParameterGroupingOperations)s).PostMultipleParameterGroupsAsync(firstParameterGroup, parameterGroupingPostMultipleParameterGroupsSecondParameterGroup), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            /// <param name='parameterGroupingPostMultipleParameterGroupsSecondParameterGroup'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostMultipleParameterGroupsAsync( this IParameterGroupingOperations operations, FirstParameterGroup firstParameterGroup = default(FirstParameterGroup), ParameterGroupingPostMultipleParameterGroupsSecondParameterGroup parameterGroupingPostMultipleParameterGroupsSecondParameterGroup = default(ParameterGroupingPostMultipleParameterGroupsSecondParameterGroup), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostMultipleParameterGroupsWithHttpMessagesAsync(firstParameterGroup, parameterGroupingPostMultipleParameterGroupsSecondParameterGroup, null, cancellationToken).ConfigureAwait(false);
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
            public static void PostSharedParameterGroupObject(this IParameterGroupingOperations operations, FirstParameterGroup firstParameterGroup = default(FirstParameterGroup))
            {
                Task.Factory.StartNew(s => ((IParameterGroupingOperations)s).PostSharedParameterGroupObjectAsync(firstParameterGroup), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            public static async Task PostSharedParameterGroupObjectAsync( this IParameterGroupingOperations operations, FirstParameterGroup firstParameterGroup = default(FirstParameterGroup), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostSharedParameterGroupObjectWithHttpMessagesAsync(firstParameterGroup, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
