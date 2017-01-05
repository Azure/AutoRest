// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsBodyStringDeprecated
{
    using System.Threading.Tasks;
   using Models;

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
            [System.Obsolete()]
            public static string GetNull(this IStringModel operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IStringModel)s).GetNullAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            [System.Obsolete()]
            public static async System.Threading.Tasks.Task<string> GetNullAsync(this IStringModel operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            [System.Obsolete()]
            public static void PutNull(this IStringModel operations, string stringBody = default(string))
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IStringModel)s).PutNullAsync(stringBody), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            [System.Obsolete()]
            public static async System.Threading.Tasks.Task PutNullAsync(this IStringModel operations, string stringBody = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IStringModel)s).GetEmptyAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            public static async System.Threading.Tasks.Task<string> GetEmptyAsync(this IStringModel operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IStringModel)s).PutEmptyAsync(stringBody), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            public static async System.Threading.Tasks.Task PutEmptyAsync(this IStringModel operations, string stringBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.PutEmptyWithHttpMessagesAsync(stringBody, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
