// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsBodyString
{
   using Models;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StringModel.
    /// </summary>
    public static partial class StringModelExtensions
    {
            /// <summary>
            /// Get null string value value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static string GetNull(this IStringModel operations)
            {
                return Task.Factory.StartNew(s => ((IStringModel)s).GetNullAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null string value value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetNullAsync(this IStringModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNullWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Set string value null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringBody'>
            /// Possible values include: ''
            /// </param>
            public static void PutNull(this IStringModel operations, string stringBody = default(string))
            {
                Task.Factory.StartNew(s => ((IStringModel)s).PutNullAsync(stringBody), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Set string value null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringBody'>
            /// Possible values include: ''
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutNullAsync(this IStringModel operations, string stringBody = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutNullWithHttpMessagesAsync(stringBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get empty string value value ''
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static string GetEmpty(this IStringModel operations)
            {
                return Task.Factory.StartNew(s => ((IStringModel)s).GetEmptyAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get empty string value value ''
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetEmptyAsync(this IStringModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEmptyWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Set string value empty ''
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringBody'>
            /// Possible values include: ''
            /// </param>
            public static void PutEmpty(this IStringModel operations, string stringBody)
            {
                Task.Factory.StartNew(s => ((IStringModel)s).PutEmptyAsync(stringBody), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Set string value empty ''
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringBody'>
            /// Possible values include: ''
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutEmptyAsync(this IStringModel operations, string stringBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutEmptyWithHttpMessagesAsync(stringBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get mbcs string value
            /// '啊齄丂狛狜隣郎隣兀﨩ˊ▇█〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€ '
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static string GetMbcs(this IStringModel operations)
            {
                return Task.Factory.StartNew(s => ((IStringModel)s).GetMbcsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get mbcs string value
            /// '啊齄丂狛狜隣郎隣兀﨩ˊ▇█〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€ '
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetMbcsAsync(this IStringModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetMbcsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Set string value mbcs
            /// '啊齄丂狛狜隣郎隣兀﨩ˊ▇█〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€ '
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringBody'>
            /// Possible values include:
            /// '啊齄丂狛狜隣郎隣兀﨩ˊ▇█〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€ '
            /// </param>
            public static void PutMbcs(this IStringModel operations, string stringBody)
            {
                Task.Factory.StartNew(s => ((IStringModel)s).PutMbcsAsync(stringBody), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Set string value mbcs
            /// '啊齄丂狛狜隣郎隣兀﨩ˊ▇█〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€ '
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringBody'>
            /// Possible values include:
            /// '啊齄丂狛狜隣郎隣兀﨩ˊ▇█〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€ '
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutMbcsAsync(this IStringModel operations, string stringBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutMbcsWithHttpMessagesAsync(stringBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get string value with leading and trailing whitespace
            /// '&lt;tab&gt;&lt;space&gt;&lt;space&gt;Now is the time for all good men to
            /// come to the aid of their country&lt;tab&gt;&lt;space&gt;&lt;space&gt;'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static string GetWhitespace(this IStringModel operations)
            {
                return Task.Factory.StartNew(s => ((IStringModel)s).GetWhitespaceAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get string value with leading and trailing whitespace
            /// '&lt;tab&gt;&lt;space&gt;&lt;space&gt;Now is the time for all good men to
            /// come to the aid of their country&lt;tab&gt;&lt;space&gt;&lt;space&gt;'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetWhitespaceAsync(this IStringModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWhitespaceWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Set String value with leading and trailing whitespace
            /// '&lt;tab&gt;&lt;space&gt;&lt;space&gt;Now is the time for all good men to
            /// come to the aid of their country&lt;tab&gt;&lt;space&gt;&lt;space&gt;'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringBody'>
            /// Possible values include: '    Now is the time for all good men to come to
            /// the aid of their country    '
            /// </param>
            public static void PutWhitespace(this IStringModel operations, string stringBody)
            {
                Task.Factory.StartNew(s => ((IStringModel)s).PutWhitespaceAsync(stringBody), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Set String value with leading and trailing whitespace
            /// '&lt;tab&gt;&lt;space&gt;&lt;space&gt;Now is the time for all good men to
            /// come to the aid of their country&lt;tab&gt;&lt;space&gt;&lt;space&gt;'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringBody'>
            /// Possible values include: '    Now is the time for all good men to come to
            /// the aid of their country    '
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutWhitespaceAsync(this IStringModel operations, string stringBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutWhitespaceWithHttpMessagesAsync(stringBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get String value when no string value is sent in response payload
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static string GetNotProvided(this IStringModel operations)
            {
                return Task.Factory.StartNew(s => ((IStringModel)s).GetNotProvidedAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get String value when no string value is sent in response payload
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> GetNotProvidedAsync(this IStringModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNotProvidedWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get value that is base64 encoded
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static byte[] GetBase64Encoded(this IStringModel operations)
            {
                return Task.Factory.StartNew(s => ((IStringModel)s).GetBase64EncodedAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get value that is base64 encoded
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<byte[]> GetBase64EncodedAsync(this IStringModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBase64EncodedWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get value that is base64url encoded
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static byte[] GetBase64UrlEncoded(this IStringModel operations)
            {
                return Task.Factory.StartNew(s => ((IStringModel)s).GetBase64UrlEncodedAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get value that is base64url encoded
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<byte[]> GetBase64UrlEncodedAsync(this IStringModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBase64UrlEncodedWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put value that is base64url encoded
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringBody'>
            /// </param>
            public static void PutBase64UrlEncoded(this IStringModel operations, byte[] stringBody)
            {
                Task.Factory.StartNew(s => ((IStringModel)s).PutBase64UrlEncodedAsync(stringBody), operations, CancellationToken.None, TaskCreationOptions.None,  TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put value that is base64url encoded
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringBody'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutBase64UrlEncodedAsync(this IStringModel operations, byte[] stringBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutBase64UrlEncodedWithHttpMessagesAsync(stringBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get null value that is expected to be base64url encoded
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static byte[] GetNullBase64UrlEncoded(this IStringModel operations)
            {
                return Task.Factory.StartNew(s => ((IStringModel)s).GetNullBase64UrlEncodedAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null value that is expected to be base64url encoded
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<byte[]> GetNullBase64UrlEncodedAsync(this IStringModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetNullBase64UrlEncodedWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
