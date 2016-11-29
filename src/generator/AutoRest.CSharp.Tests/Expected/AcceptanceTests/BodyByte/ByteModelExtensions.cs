// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsBodyByte
{
   using Models;
    using System.Threading;
    using System.Threading.Tasks;

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
                return operations.GetNullAsync().GetAwaiter().GetResult();
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
            public static async Task<byte[]> GetNullAsync(this IByteModel operations, CancellationToken cancellationToken = default(CancellationToken))
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
                return operations.GetEmptyAsync().GetAwaiter().GetResult();
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
            public static async Task<byte[]> GetEmptyAsync(this IByteModel operations, CancellationToken cancellationToken = default(CancellationToken))
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
                return operations.GetNonAsciiAsync().GetAwaiter().GetResult();
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
            public static async Task<byte[]> GetNonAsciiAsync(this IByteModel operations, CancellationToken cancellationToken = default(CancellationToken))
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
                operations.PutNonAsciiAsync(byteBody).GetAwaiter().GetResult();
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
            public static async Task PutNonAsciiAsync(this IByteModel operations, byte[] byteBody, CancellationToken cancellationToken = default(CancellationToken))
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
                return operations.GetInvalidAsync().GetAwaiter().GetResult();
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
            public static async Task<byte[]> GetInvalidAsync(this IByteModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetInvalidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

