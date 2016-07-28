// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsBodyByte
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for ByteModel.
    /// </summary>
    public static partial class ByteModelExtensions
    {
            /// <summary>
            /// Get null byte value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static byte[] GetNull(this IByteModel operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IByteModel)s).GetNullAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null byte value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<byte[]> GetNullAsync(this IByteModel operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetNullWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get empty byte value ''
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static byte[] GetEmpty(this IByteModel operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IByteModel)s).GetEmptyAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get empty byte value ''
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<byte[]> GetEmptyAsync(this IByteModel operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetEmptyWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static byte[] GetNonAscii(this IByteModel operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IByteModel)s).GetNonAsciiAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<byte[]> GetNonAsciiAsync(this IByteModel operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetNonAsciiWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='byteBody'>
            /// Base64-encoded non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
            /// </param>
            public static void PutNonAscii(this IByteModel operations, byte[] byteBody)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IByteModel)s).PutNonAsciiAsync(byteBody), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='byteBody'>
            /// Base64-encoded non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PutNonAsciiAsync(this IByteModel operations, byte[] byteBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.PutNonAsciiWithHttpMessagesAsync(byteBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get invalid byte value ':::SWAGGER::::'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static byte[] GetInvalid(this IByteModel operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IByteModel)s).GetInvalidAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get invalid byte value ':::SWAGGER::::'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<byte[]> GetInvalidAsync(this IByteModel operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetInvalidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
