// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsHeadExceptions
{
    using Fixtures.Azure;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HeadExceptionOperations.
    /// </summary>
    public static partial class HeadExceptionOperationsExtensions
    {
            /// <summary>
            /// Return 200 status code if successful
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Head200(this IHeadExceptionOperations operations)
            {
                operations.Head200Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 200 status code if successful
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Head200Async(this IHeadExceptionOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Head200WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Return 204 status code if successful
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Head204(this IHeadExceptionOperations operations)
            {
                operations.Head204Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 204 status code if successful
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Head204Async(this IHeadExceptionOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Head204WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Return 404 status code if successful
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Head404(this IHeadExceptionOperations operations)
            {
                operations.Head404Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 404 status code if successful
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Head404Async(this IHeadExceptionOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Head404WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

    }
}

