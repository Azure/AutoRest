// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsPaging
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for PagingOperations.
    /// </summary>
    public static partial class PagingOperationsExtensions
    {
            /// <summary>
            /// A paging operation that finishes on the first call without a nextlink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetSinglePages(this IPagingOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetSinglePagesAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that finishes on the first call without a nextlink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetSinglePagesAsync(this IPagingOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetSinglePagesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientRequestId'>
            /// </param>
            /// <param name='pagingGetMultiplePagesOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetMultiplePages(this IPagingOperations operations, System.String clientRequestId = default(System.String), PagingGetMultiplePagesOptions pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesAsync(clientRequestId, pagingGetMultiplePagesOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientRequestId'>
            /// </param>
            /// <param name='pagingGetMultiplePagesOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetMultiplePagesAsync(this IPagingOperations operations, System.String clientRequestId = default(System.String), PagingGetMultiplePagesOptions pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMultiplePagesWithHttpMessagesAsync(clientRequestId, pagingGetMultiplePagesOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that includes a nextLink in odata format that has 10
            /// pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientRequestId'>
            /// </param>
            /// <param name='pagingGetOdataMultiplePagesOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetOdataMultiplePages(this IPagingOperations operations, System.String clientRequestId = default(System.String), PagingGetOdataMultiplePagesOptions pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetOdataMultiplePagesAsync(clientRequestId, pagingGetOdataMultiplePagesOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that includes a nextLink in odata format that has 10
            /// pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientRequestId'>
            /// </param>
            /// <param name='pagingGetOdataMultiplePagesOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetOdataMultiplePagesAsync(this IPagingOperations operations, System.String clientRequestId = default(System.String), PagingGetOdataMultiplePagesOptions pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetOdataMultiplePagesWithHttpMessagesAsync(clientRequestId, pagingGetOdataMultiplePagesOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pagingGetMultiplePagesWithOffsetOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='clientRequestId'>
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetMultiplePagesWithOffset(this IPagingOperations operations, PagingGetMultiplePagesWithOffsetOptions pagingGetMultiplePagesWithOffsetOptions, System.String clientRequestId = default(System.String))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesWithOffsetAsync(pagingGetMultiplePagesWithOffsetOptions, clientRequestId), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pagingGetMultiplePagesWithOffsetOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='clientRequestId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetMultiplePagesWithOffsetAsync(this IPagingOperations operations, PagingGetMultiplePagesWithOffsetOptions pagingGetMultiplePagesWithOffsetOptions, System.String clientRequestId = default(System.String), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMultiplePagesWithOffsetWithHttpMessagesAsync(pagingGetMultiplePagesWithOffsetOptions, clientRequestId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that fails on the first call with 500 and then retries
            /// and then get a response including a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetMultiplePagesRetryFirst(this IPagingOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesRetryFirstAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that fails on the first call with 500 and then retries
            /// and then get a response including a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetMultiplePagesRetryFirstAsync(this IPagingOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMultiplePagesRetryFirstWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages, of which
            /// the 2nd call fails first with 500. The client should retry and finish all
            /// 10 pages eventually.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetMultiplePagesRetrySecond(this IPagingOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesRetrySecondAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages, of which
            /// the 2nd call fails first with 500. The client should retry and finish all
            /// 10 pages eventually.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetMultiplePagesRetrySecondAsync(this IPagingOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMultiplePagesRetrySecondWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that receives a 400 on the first call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetSinglePagesFailure(this IPagingOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetSinglePagesFailureAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that receives a 400 on the first call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetSinglePagesFailureAsync(this IPagingOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetSinglePagesFailureWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that receives a 400 on the second call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetMultiplePagesFailure(this IPagingOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesFailureAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that receives a 400 on the second call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetMultiplePagesFailureAsync(this IPagingOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMultiplePagesFailureWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that receives an invalid nextLink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetMultiplePagesFailureUri(this IPagingOperations operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesFailureUriAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that receives an invalid nextLink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetMultiplePagesFailureUriAsync(this IPagingOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMultiplePagesFailureUriWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that finishes on the first call without a nextlink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetSinglePagesNext(this IPagingOperations operations, System.String nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetSinglePagesNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that finishes on the first call without a nextlink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetSinglePagesNextAsync(this IPagingOperations operations, System.String nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetSinglePagesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='clientRequestId'>
            /// </param>
            /// <param name='pagingGetMultiplePagesOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetMultiplePagesNext(this IPagingOperations operations, System.String nextPageLink, System.String clientRequestId = default(System.String), PagingGetMultiplePagesOptions pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesNextAsync(nextPageLink, clientRequestId, pagingGetMultiplePagesOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='clientRequestId'>
            /// </param>
            /// <param name='pagingGetMultiplePagesOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetMultiplePagesNextAsync(this IPagingOperations operations, System.String nextPageLink, System.String clientRequestId = default(System.String), PagingGetMultiplePagesOptions pagingGetMultiplePagesOptions = default(PagingGetMultiplePagesOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMultiplePagesNextWithHttpMessagesAsync(nextPageLink, clientRequestId, pagingGetMultiplePagesOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that includes a nextLink in odata format that has 10
            /// pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='clientRequestId'>
            /// </param>
            /// <param name='pagingGetOdataMultiplePagesOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetOdataMultiplePagesNext(this IPagingOperations operations, System.String nextPageLink, System.String clientRequestId = default(System.String), PagingGetOdataMultiplePagesOptions pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetOdataMultiplePagesNextAsync(nextPageLink, clientRequestId, pagingGetOdataMultiplePagesOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that includes a nextLink in odata format that has 10
            /// pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='clientRequestId'>
            /// </param>
            /// <param name='pagingGetOdataMultiplePagesOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetOdataMultiplePagesNextAsync(this IPagingOperations operations, System.String nextPageLink, System.String clientRequestId = default(System.String), PagingGetOdataMultiplePagesOptions pagingGetOdataMultiplePagesOptions = default(PagingGetOdataMultiplePagesOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetOdataMultiplePagesNextWithHttpMessagesAsync(nextPageLink, clientRequestId, pagingGetOdataMultiplePagesOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='clientRequestId'>
            /// </param>
            /// <param name='pagingGetMultiplePagesWithOffsetNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetMultiplePagesWithOffsetNext(this IPagingOperations operations, System.String nextPageLink, System.String clientRequestId = default(System.String), PagingGetMultiplePagesWithOffsetNextOptions pagingGetMultiplePagesWithOffsetNextOptions = default(PagingGetMultiplePagesWithOffsetNextOptions))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesWithOffsetNextAsync(nextPageLink, clientRequestId, pagingGetMultiplePagesWithOffsetNextOptions), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='clientRequestId'>
            /// </param>
            /// <param name='pagingGetMultiplePagesWithOffsetNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetMultiplePagesWithOffsetNextAsync(this IPagingOperations operations, System.String nextPageLink, System.String clientRequestId = default(System.String), PagingGetMultiplePagesWithOffsetNextOptions pagingGetMultiplePagesWithOffsetNextOptions = default(PagingGetMultiplePagesWithOffsetNextOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMultiplePagesWithOffsetNextWithHttpMessagesAsync(nextPageLink, clientRequestId, pagingGetMultiplePagesWithOffsetNextOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that fails on the first call with 500 and then retries
            /// and then get a response including a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetMultiplePagesRetryFirstNext(this IPagingOperations operations, System.String nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesRetryFirstNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that fails on the first call with 500 and then retries
            /// and then get a response including a nextLink that has 10 pages
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetMultiplePagesRetryFirstNextAsync(this IPagingOperations operations, System.String nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMultiplePagesRetryFirstNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages, of which
            /// the 2nd call fails first with 500. The client should retry and finish all
            /// 10 pages eventually.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetMultiplePagesRetrySecondNext(this IPagingOperations operations, System.String nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesRetrySecondNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that includes a nextLink that has 10 pages, of which
            /// the 2nd call fails first with 500. The client should retry and finish all
            /// 10 pages eventually.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetMultiplePagesRetrySecondNextAsync(this IPagingOperations operations, System.String nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMultiplePagesRetrySecondNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that receives a 400 on the first call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetSinglePagesFailureNext(this IPagingOperations operations, System.String nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetSinglePagesFailureNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that receives a 400 on the first call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetSinglePagesFailureNextAsync(this IPagingOperations operations, System.String nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetSinglePagesFailureNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that receives a 400 on the second call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetMultiplePagesFailureNext(this IPagingOperations operations, System.String nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesFailureNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that receives a 400 on the second call
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetMultiplePagesFailureNextAsync(this IPagingOperations operations, System.String nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMultiplePagesFailureNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// A paging operation that receives an invalid nextLink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Product> GetMultiplePagesFailureUriNext(this IPagingOperations operations, System.String nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPagingOperations)s).GetMultiplePagesFailureUriNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// A paging operation that receives an invalid nextLink
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Product>> GetMultiplePagesFailureUriNextAsync(this IPagingOperations operations, System.String nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetMultiplePagesFailureUriNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
