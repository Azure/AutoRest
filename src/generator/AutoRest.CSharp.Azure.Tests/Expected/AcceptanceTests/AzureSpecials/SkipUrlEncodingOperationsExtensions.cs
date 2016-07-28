// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for SkipUrlEncodingOperations.
    /// </summary>
    public static partial class SkipUrlEncodingOperationsExtensions
    {
            /// <summary>
            /// Get method with unencoded path parameter with value 'path1/path2/path3'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='unencodedPathParam'>
            /// Unencoded path parameter with value 'path1/path2/path3'
            /// </param>
            public static void GetMethodPathValid(this ISkipUrlEncodingOperations operations, string unencodedPathParam)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISkipUrlEncodingOperations)s).GetMethodPathValidAsync(unencodedPathParam), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with unencoded path parameter with value 'path1/path2/path3'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='unencodedPathParam'>
            /// Unencoded path parameter with value 'path1/path2/path3'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetMethodPathValidAsync(this ISkipUrlEncodingOperations operations, string unencodedPathParam, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.GetMethodPathValidWithHttpMessagesAsync(unencodedPathParam, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get method with unencoded path parameter with value 'path1/path2/path3'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='unencodedPathParam'>
            /// Unencoded path parameter with value 'path1/path2/path3'
            /// </param>
            public static void GetPathPathValid(this ISkipUrlEncodingOperations operations, string unencodedPathParam)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISkipUrlEncodingOperations)s).GetPathPathValidAsync(unencodedPathParam), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with unencoded path parameter with value 'path1/path2/path3'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='unencodedPathParam'>
            /// Unencoded path parameter with value 'path1/path2/path3'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetPathPathValidAsync(this ISkipUrlEncodingOperations operations, string unencodedPathParam, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.GetPathPathValidWithHttpMessagesAsync(unencodedPathParam, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get method with unencoded path parameter with value 'path1/path2/path3'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetSwaggerPathValid(this ISkipUrlEncodingOperations operations)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISkipUrlEncodingOperations)s).GetSwaggerPathValidAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with unencoded path parameter with value 'path1/path2/path3'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetSwaggerPathValidAsync(this ISkipUrlEncodingOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.GetSwaggerPathValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get method with unencoded query parameter with value
            /// 'value1&amp;q2=value2&amp;q3=value3'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='q1'>
            /// Unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'
            /// </param>
            public static void GetMethodQueryValid(this ISkipUrlEncodingOperations operations, string q1)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISkipUrlEncodingOperations)s).GetMethodQueryValidAsync(q1), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with unencoded query parameter with value
            /// 'value1&amp;q2=value2&amp;q3=value3'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='q1'>
            /// Unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetMethodQueryValidAsync(this ISkipUrlEncodingOperations operations, string q1, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.GetMethodQueryValidWithHttpMessagesAsync(q1, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get method with unencoded query parameter with value null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='q1'>
            /// Unencoded query parameter with value null
            /// </param>
            public static void GetMethodQueryNull(this ISkipUrlEncodingOperations operations, string q1 = default(string))
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISkipUrlEncodingOperations)s).GetMethodQueryNullAsync(q1), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with unencoded query parameter with value null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='q1'>
            /// Unencoded query parameter with value null
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetMethodQueryNullAsync(this ISkipUrlEncodingOperations operations, string q1 = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.GetMethodQueryNullWithHttpMessagesAsync(q1, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get method with unencoded query parameter with value
            /// 'value1&amp;q2=value2&amp;q3=value3'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='q1'>
            /// Unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'
            /// </param>
            public static void GetPathQueryValid(this ISkipUrlEncodingOperations operations, string q1)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISkipUrlEncodingOperations)s).GetPathQueryValidAsync(q1), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with unencoded query parameter with value
            /// 'value1&amp;q2=value2&amp;q3=value3'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='q1'>
            /// Unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetPathQueryValidAsync(this ISkipUrlEncodingOperations operations, string q1, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.GetPathQueryValidWithHttpMessagesAsync(q1, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get method with unencoded query parameter with value
            /// 'value1&amp;q2=value2&amp;q3=value3'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetSwaggerQueryValid(this ISkipUrlEncodingOperations operations)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISkipUrlEncodingOperations)s).GetSwaggerQueryValidAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get method with unencoded query parameter with value
            /// 'value1&amp;q2=value2&amp;q3=value3'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetSwaggerQueryValidAsync(this ISkipUrlEncodingOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.GetSwaggerQueryValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

    }
}
