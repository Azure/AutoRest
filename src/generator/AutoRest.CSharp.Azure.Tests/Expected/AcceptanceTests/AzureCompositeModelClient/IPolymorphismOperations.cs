// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// PolymorphismOperations operations.
    /// </summary>
    public partial interface IPolymorphismOperations
    {
        /// <summary>
        /// Get complex types that are polymorphic
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<AzureOperationResponse<Fish>> GetValidWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Put complex types that are polymorphic
        /// </summary>
        /// <param name='complexBody'>
        /// Please put a salmon that looks like this:{
        /// 'fishtype':'Salmon',        'location':'alaska',
        /// 'iswild':true,        'species':'king',
        /// 'length':1.0,        'siblings':[          {
        /// 'fishtype':'Shark',            'age':6,
        /// 'birthday': '2012-01-05T01:00:00Z',
        /// 'length':20.0,            'species':'predator',
        /// },          {            'fishtype':'Sawshark',
        /// 'age':105,            'birthday':
        /// '1900-01-05T01:00:00Z',            'length':10.0,
        /// 'picture': new Buffer([255, 255, 255, 255,
        /// 254]).toString('base64'),            'species':'dangerous',
        /// },          {            'fishtype': 'goblin',
        /// 'age': 1,            'birthday':
        /// '2015-08-08T00:00:00Z',            'length': 30.0,
        /// 'species': 'scary',            'jawsize': 5          }
        /// ]      };
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> PutValidWithHttpMessagesAsync(Fish complexBody, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Put complex types that are polymorphic, attempting to omit
        /// required 'birthday' field - the request should not be allowed
        /// from the client
        /// </summary>
        /// <param name='complexBody'>
        /// Please attempt put a sawshark that looks like this, the client
        /// should not allow this data to be sent:{    "fishtype":
        /// "sawshark",    "species": "snaggle toothed",    "length": 18.5,
        /// "age": 2,    "birthday": "2013-06-01T01:00:00Z",
        /// "location": "alaska",    "picture": base64(FF FF FF FF FE),
        /// "siblings": [        {            "fishtype": "shark",
        /// "species": "predator",            "birthday":
        /// "2012-01-05T01:00:00Z",            "length": 20,
        /// "age": 6        },        {            "fishtype":
        /// "sawshark",            "species": "dangerous",
        /// "picture": base64(FF FF FF FF FE),
        /// "length": 10,            "age": 105        }    ]}
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> PutValidMissingRequiredWithHttpMessagesAsync(Fish complexBody, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
