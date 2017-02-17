// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureSpecials
{
    using Fixtures.Azure;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for OdataOperations.
    /// </summary>
    public static partial class OdataOperationsExtensions
    {
            /// <summary>
            /// Specify filter parameter with value '$filter=id gt 5 and name eq
            /// 'foo'&amp;$orderby=id&amp;$top=10'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static void GetWithFilter(this IOdataOperations operations, ODataQuery<OdataFilterInner> odataQuery = default(ODataQuery<OdataFilterInner>))
            {
                operations.GetWithFilterAsync(odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Specify filter parameter with value '$filter=id gt 5 and name eq
            /// 'foo'&amp;$orderby=id&amp;$top=10'
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetWithFilterAsync(this IOdataOperations operations, ODataQuery<OdataFilterInner> odataQuery = default(ODataQuery<OdataFilterInner>), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.GetWithFilterWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
