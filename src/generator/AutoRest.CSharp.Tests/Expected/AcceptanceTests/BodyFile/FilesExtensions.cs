// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsBodyFile
{
    using Models;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Files.
    /// </summary>
    public static partial class FilesExtensions
    {
            /// <summary>
            /// Get file
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Stream GetFile(this IFiles operations)
            {
                return operations.GetFileAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get file
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> GetFileAsync(this IFiles operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetFileWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Get a large file
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Stream GetFileLarge(this IFiles operations)
            {
                return operations.GetFileLargeAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a large file
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> GetFileLargeAsync(this IFiles operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetFileLargeWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Get empty file
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Stream GetEmptyFile(this IFiles operations)
            {
                return operations.GetEmptyFileAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get empty file
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> GetEmptyFileAsync(this IFiles operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetEmptyFileWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

    }
}
