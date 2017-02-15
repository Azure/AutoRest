// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsHttp
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HttpRetry.
    /// </summary>
    public static partial class HttpRetryExtensions
    {
            /// <summary>
            /// Return 408 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Head408(this IHttpRetry operations)
            {
                operations.Head408Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 408 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Head408Async(this IHttpRetry operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.Head408WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Return 500 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Put500(this IHttpRetry operations, bool? booleanValue = default(bool?))
            {
                operations.Put500Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 500 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Put500Async(this IHttpRetry operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.Put500WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Return 500 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Patch500(this IHttpRetry operations, bool? booleanValue = default(bool?))
            {
                operations.Patch500Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 500 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Patch500Async(this IHttpRetry operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.Patch500WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Return 502 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void Get502(this IHttpRetry operations)
            {
                operations.Get502Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 502 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Get502Async(this IHttpRetry operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.Get502WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Return 503 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Post503(this IHttpRetry operations, bool? booleanValue = default(bool?))
            {
                operations.Post503Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 503 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Post503Async(this IHttpRetry operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.Post503WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Return 503 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Delete503(this IHttpRetry operations, bool? booleanValue = default(bool?))
            {
                operations.Delete503Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 503 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Delete503Async(this IHttpRetry operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.Delete503WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Return 504 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Put504(this IHttpRetry operations, bool? booleanValue = default(bool?))
            {
                operations.Put504Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 504 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Put504Async(this IHttpRetry operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.Put504WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Return 504 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            public static void Patch504(this IHttpRetry operations, bool? booleanValue = default(bool?))
            {
                operations.Patch504Async(booleanValue).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Return 504 status code, then 200 after retry
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='booleanValue'>
            /// Simple boolean value true
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Patch504Async(this IHttpRetry operations, bool? booleanValue = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.Patch504WithHttpMessagesAsync(booleanValue, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}

