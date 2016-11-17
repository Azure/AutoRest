// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsSubscriptionIdApiVersion
{
    using Azure;
    using Microsoft.Rest;
   using Microsoft.Rest.Azure;
   using Models;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GroupOperations.
    /// </summary>
    public static partial class GroupOperationsExtensions
    {
            /// <summary>
            /// Provides a resouce group with name 'testgroup101' and location 'West US'.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource Group name 'testgroup101'.
            /// </param>
            public static SampleResourceGroup GetSampleResourceGroup(this IGroupOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IGroupOperations)s).GetSampleResourceGroupAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides a resouce group with name 'testgroup101' and location 'West US'.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource Group name 'testgroup101'.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SampleResourceGroup> GetSampleResourceGroupAsync(this IGroupOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSampleResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
