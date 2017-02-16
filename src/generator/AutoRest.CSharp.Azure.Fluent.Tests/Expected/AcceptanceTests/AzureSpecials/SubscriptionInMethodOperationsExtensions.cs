// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using Fixtures.Azure;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SubscriptionInMethodOperations.
    /// </summary>
    public static partial class SubscriptionInMethodOperationsExtensions
    {
            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = '1234-5678-9012-3456' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// This should appear as a method parameter, use value '1234-5678-9012-3456'
            /// </param>
            public static void PostMethodLocalValid(this ISubscriptionInMethodOperations operations, string subscriptionId)
            {
                operations.PostMethodLocalValidAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = '1234-5678-9012-3456' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// This should appear as a method parameter, use value '1234-5678-9012-3456'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostMethodLocalValidAsync(this ISubscriptionInMethodOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostMethodLocalValidWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = null, client-side validation should prevent you from
            /// making this call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// This should appear as a method parameter, use value null, client-side
            /// validation should prvenet the call
            /// </param>
            public static void PostMethodLocalNull(this ISubscriptionInMethodOperations operations, string subscriptionId)
            {
                operations.PostMethodLocalNullAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = null, client-side validation should prevent you from
            /// making this call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// This should appear as a method parameter, use value null, client-side
            /// validation should prvenet the call
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostMethodLocalNullAsync(this ISubscriptionInMethodOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostMethodLocalNullWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = '1234-5678-9012-3456' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Should appear as a method parameter -use value '1234-5678-9012-3456'
            /// </param>
            public static void PostPathLocalValid(this ISubscriptionInMethodOperations operations, string subscriptionId)
            {
                operations.PostPathLocalValidAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = '1234-5678-9012-3456' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Should appear as a method parameter -use value '1234-5678-9012-3456'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostPathLocalValidAsync(this ISubscriptionInMethodOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostPathLocalValidWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = '1234-5678-9012-3456' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The subscriptionId, which appears in the path, the value is always
            /// '1234-5678-9012-3456'
            /// </param>
            public static void PostSwaggerLocalValid(this ISubscriptionInMethodOperations operations, string subscriptionId)
            {
                operations.PostSwaggerLocalValidAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// POST method with subscriptionId modeled in the method.  pass in
            /// subscription id = '1234-5678-9012-3456' to succeed
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// The subscriptionId, which appears in the path, the value is always
            /// '1234-5678-9012-3456'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostSwaggerLocalValidAsync(this ISubscriptionInMethodOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PostSwaggerLocalValidWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
