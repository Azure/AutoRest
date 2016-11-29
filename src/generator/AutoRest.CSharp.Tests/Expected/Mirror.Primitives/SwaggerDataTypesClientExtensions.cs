// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.MirrorPrimitives
{
   using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SwaggerDataTypesClient.
    /// </summary>
    public static partial class SwaggerDataTypesClientExtensions
    {
            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            public static Product GetProduct(this ISwaggerDataTypesClient operations, string responseCode = default(string), Product product = default(Product))
            {
                return operations.GetProductAsync(responseCode, product).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> GetProductAsync(this ISwaggerDataTypesClient operations, string responseCode = default(string), Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetProductWithHttpMessagesAsync(responseCode, product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            public static Product PutProduct(this ISwaggerDataTypesClient operations, string responseCode = default(string), Product product = default(Product))
            {
                return operations.PutProductAsync(responseCode, product).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> PutProductAsync(this ISwaggerDataTypesClient operations, string responseCode = default(string), Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PutProductWithHttpMessagesAsync(responseCode, product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            public static Product PostProduct(this ISwaggerDataTypesClient operations, string responseCode = default(string), Product product = default(Product))
            {
                return operations.PostProductAsync(responseCode, product).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> PostProductAsync(this ISwaggerDataTypesClient operations, string responseCode = default(string), Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostProductWithHttpMessagesAsync(responseCode, product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            public static Product PatchProduct(this ISwaggerDataTypesClient operations, string responseCode = default(string), Product product = default(Product))
            {
                return operations.PatchProductAsync(responseCode, product).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> PatchProductAsync(this ISwaggerDataTypesClient operations, string responseCode = default(string), Product product = default(Product), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PatchProductWithHttpMessagesAsync(responseCode, product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

