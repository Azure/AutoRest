// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsHeader
{
    using Models;

    /// <summary>
    /// Header operations.
    /// </summary>
    public partial interface IHeader
    {
        /// <summary>
        /// Send a post request with header value "User-Agent": "overwrite"
        /// </summary>
        /// <param name='userAgent'>
        /// Send a post request with header value "User-Agent": "overwrite"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamExistingKeyWithHttpMessagesAsync(System.String userAgent, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header value "User-Agent": "overwrite"
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
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseExistingKeyHeaders>> ResponseExistingKeyWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header value "Content-Type": "text/html"
        /// </summary>
        /// <param name='contentType'>
        /// Send a post request with header value "Content-Type": "text/html"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamProtectedKeyWithHttpMessagesAsync(System.String contentType, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header value "Content-Type": "text/html"
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
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseProtectedKeyHeaders>> ResponseProtectedKeyWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header values "scenario": "positive",
        /// "value": 1 or "scenario": "negative", "value": -2
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "positive" or
        /// "negative"
        /// </param>
        /// <param name='value'>
        /// Send a post request with header values 1 or -2
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamIntegerWithHttpMessagesAsync(System.String scenario, System.Int32 value, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header value "value": 1 or -2
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "positive" or
        /// "negative"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseIntegerHeaders>> ResponseIntegerWithHttpMessagesAsync(System.String scenario, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header values "scenario": "positive",
        /// "value": 105 or "scenario": "negative", "value": -2
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "positive" or
        /// "negative"
        /// </param>
        /// <param name='value'>
        /// Send a post request with header values 105 or -2
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamLongWithHttpMessagesAsync(System.String scenario, System.Int64 value, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header value "value": 105 or -2
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "positive" or
        /// "negative"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseLongHeaders>> ResponseLongWithHttpMessagesAsync(System.String scenario, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header values "scenario": "positive",
        /// "value": 0.07 or "scenario": "negative", "value": -3.0
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "positive" or
        /// "negative"
        /// </param>
        /// <param name='value'>
        /// Send a post request with header values 0.07 or -3.0
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamFloatWithHttpMessagesAsync(System.String scenario, System.Double value, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header value "value": 0.07 or -3.0
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "positive" or
        /// "negative"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseFloatHeaders>> ResponseFloatWithHttpMessagesAsync(System.String scenario, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header values "scenario": "positive",
        /// "value": 7e120 or "scenario": "negative", "value": -3.0
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "positive" or
        /// "negative"
        /// </param>
        /// <param name='value'>
        /// Send a post request with header values 7e120 or -3.0
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamDoubleWithHttpMessagesAsync(System.String scenario, System.Double value, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header value "value": 7e120 or -3.0
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "positive" or
        /// "negative"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseDoubleHeaders>> ResponseDoubleWithHttpMessagesAsync(System.String scenario, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header values "scenario": "true",
        /// "value": true or "scenario": "false", "value": false
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "true" or
        /// "false"
        /// </param>
        /// <param name='value'>
        /// Send a post request with header values true or false
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamBoolWithHttpMessagesAsync(System.String scenario, System.Boolean value, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header value "value": true or false
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "true" or
        /// "false"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseBoolHeaders>> ResponseBoolWithHttpMessagesAsync(System.String scenario, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header values "scenario": "valid",
        /// "value": "The quick brown fox jumps over the lazy dog" or
        /// "scenario": "null", "value": null or "scenario": "empty",
        /// "value": ""
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid" or
        /// "null" or "empty"
        /// </param>
        /// <param name='value'>
        /// Send a post request with header values "The quick brown fox jumps
        /// over the lazy dog" or null or ""
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamStringWithHttpMessagesAsync(System.String scenario, System.String value = default(System.String), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header values "The quick brown fox jumps over
        /// the lazy dog" or null or ""
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid" or
        /// "null" or "empty"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseStringHeaders>> ResponseStringWithHttpMessagesAsync(System.String scenario, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header values "scenario": "valid",
        /// "value": "2010-01-01" or "scenario": "min", "value": "0001-01-01"
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid" or "min"
        /// </param>
        /// <param name='value'>
        /// Send a post request with header values "2010-01-01" or "0001-01-01"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamDateWithHttpMessagesAsync(System.String scenario, System.DateTime value, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header values "2010-01-01" or "0001-01-01"
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid" or "min"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseDateHeaders>> ResponseDateWithHttpMessagesAsync(System.String scenario, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header values "scenario": "valid",
        /// "value": "2010-01-01T12:34:56Z" or "scenario": "min", "value":
        /// "0001-01-01T00:00:00Z"
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid" or "min"
        /// </param>
        /// <param name='value'>
        /// Send a post request with header values "2010-01-01T12:34:56Z" or
        /// "0001-01-01T00:00:00Z"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamDatetimeWithHttpMessagesAsync(System.String scenario, System.DateTime value, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header values "2010-01-01T12:34:56Z" or
        /// "0001-01-01T00:00:00Z"
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid" or "min"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseDatetimeHeaders>> ResponseDatetimeWithHttpMessagesAsync(System.String scenario, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header values "scenario": "valid",
        /// "value": "Wed, 01 Jan 2010 12:34:56 GMT" or "scenario": "min",
        /// "value": "Mon, 01 Jan 0001 00:00:00 GMT"
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid" or "min"
        /// </param>
        /// <param name='value'>
        /// Send a post request with header values "Wed, 01 Jan 2010 12:34:56
        /// GMT" or "Mon, 01 Jan 0001 00:00:00 GMT"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamDatetimeRfc1123WithHttpMessagesAsync(System.String scenario, System.DateTime? value = default(System.DateTime?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header values "Wed, 01 Jan 2010 12:34:56 GMT"
        /// or "Mon, 01 Jan 0001 00:00:00 GMT"
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid" or "min"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseDatetimeRfc1123Headers>> ResponseDatetimeRfc1123WithHttpMessagesAsync(System.String scenario, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header values "scenario": "valid",
        /// "value": "P123DT22H14M12.011S"
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid"
        /// </param>
        /// <param name='value'>
        /// Send a post request with header values "P123DT22H14M12.011S"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamDurationWithHttpMessagesAsync(System.String scenario, System.TimeSpan value, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header values "P123DT22H14M12.011S"
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseDurationHeaders>> ResponseDurationWithHttpMessagesAsync(System.String scenario, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header values "scenario": "valid",
        /// "value": "啊齄丂狛狜隣郎隣兀﨩"
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid"
        /// </param>
        /// <param name='value'>
        /// Send a post request with header values "啊齄丂狛狜隣郎隣兀﨩"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamByteWithHttpMessagesAsync(System.String scenario, System.Byte[] value, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header values "啊齄丂狛狜隣郎隣兀﨩"
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseByteHeaders>> ResponseByteWithHttpMessagesAsync(System.String scenario, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send a post request with header values "scenario": "valid",
        /// "value": "GREY" or "scenario": "null", "value": null
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid" or
        /// "null" or "empty"
        /// </param>
        /// <param name='value'>
        /// Send a post request with header values 'GREY' . Possible values
        /// include: 'White', 'black', 'GREY'
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> ParamEnumWithHttpMessagesAsync(System.String scenario, GreyscaleColors? value = default(GreyscaleColors?), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a response with header values "GREY" or null
        /// </summary>
        /// <param name='scenario'>
        /// Send a post request with header values "scenario": "valid" or
        /// "null" or "empty"
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationHeaderResponse<HeaderResponseEnumHeaders>> ResponseEnumWithHttpMessagesAsync(System.String scenario, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0
        /// in the header of the request
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
        System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse> CustomRequestIdWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
