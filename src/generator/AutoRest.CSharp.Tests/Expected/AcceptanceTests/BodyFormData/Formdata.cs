// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsBodyFormData
{
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Formdata operations.
    /// </summary>
    public partial class Formdata : Microsoft.Rest.IServiceOperations<AutoRestSwaggerBATFormDataService>, IFormdata
    {
        /// <summary>
        /// Initializes a new instance of the Formdata class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public Formdata(AutoRestSwaggerBATFormDataService client)
        {
            if (client == null) 
            {
                throw new System.ArgumentNullException("client");
            }
            this.Client = client;
        }

        /// <summary>
        /// Gets a reference to the AutoRestSwaggerBATFormDataService
        /// </summary>
        public AutoRestSwaggerBATFormDataService Client { get; private set; }

        /// <summary>
        /// Upload file
        /// </summary>
        /// <param name='fileContent'>
        /// File to upload.
        /// </param>
        /// <param name='fileName'>
        /// File name to upload. Name has to be spelled exactly as written here.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse<System.IO.Stream>> UploadFileWithHttpMessagesAsync(System.IO.Stream fileContent, System.String fileName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            if (fileContent == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "fileContent");
            }
            if (fileName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "fileName");
            }
            // Tracing
            bool _shouldTrace = Microsoft.Rest.ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = Microsoft.Rest.ServiceClientTracing.NextInvocationId.ToString();
                System.Collections.Generic.Dictionary<string, object> tracingParameters = new System.Collections.Generic.Dictionary<string, object>();
                tracingParameters.Add("fileContent", fileContent);
                tracingParameters.Add("fileName", fileName);
                tracingParameters.Add("cancellationToken", cancellationToken);
                Microsoft.Rest.ServiceClientTracing.Enter(_invocationId, this, "UploadFile", tracingParameters);
            }
            // Construct URL
            var _baseUrl = this.Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "formdata/stream/uploadfile").ToString();
            // Create HTTP transport objects
            System.Net.Http.HttpRequestMessage _httpRequest = new System.Net.Http.HttpRequestMessage();
            System.Net.Http.HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new System.Net.Http.HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            System.Net.Http.MultipartFormDataContent _multiPartContent = new System.Net.Http.MultipartFormDataContent();
            if (fileContent != null)
            {
                 System.Net.Http.StreamContent _fileContent = new System.Net.Http.StreamContent(fileContent);
                _fileContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                System.IO.FileStream _fileContentAsFileStream = fileContent as System.IO.FileStream;
                if (_fileContentAsFileStream != null)
                {
                    System.Net.Http.Headers.ContentDispositionHeaderValue _contentDispositionHeaderValue = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");
                    _contentDispositionHeaderValue.Name = "fileContent";
                    _contentDispositionHeaderValue.FileName = _fileContentAsFileStream.Name;
                    _fileContent.Headers.ContentDisposition = _contentDispositionHeaderValue;        
                }    
                _multiPartContent.Add(_fileContent, "fileContent");
            }
            if (fileName != null)
            {
                System.Net.Http.StringContent _fileName = new System.Net.Http.StringContent(fileName, System.Text.Encoding.UTF8);
                _multiPartContent.Add(_fileName, "fileName");
            }
            _httpRequest.Content = _multiPartContent;
            // Send Request
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await this.Client.HttpClient.SendAsync(_httpRequest, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            System.Net.HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new ErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Error _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Error>(_responseContent, this.Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (Newtonsoft.Json.JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new Microsoft.Rest.HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new Microsoft.Rest.HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    Microsoft.Rest.ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new Microsoft.Rest.HttpOperationResponse<System.IO.Stream>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _result.Body = await _httpResponse.Content.ReadAsStreamAsync().ConfigureAwait(false);
            }
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Upload file
        /// </summary>
        /// <param name='fileContent'>
        /// File to upload.
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async System.Threading.Tasks.Task<Microsoft.Rest.HttpOperationResponse<System.IO.Stream>> UploadFileViaBodyWithHttpMessagesAsync(System.IO.Stream fileContent, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            if (fileContent == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "fileContent");
            }
            // Tracing
            bool _shouldTrace = Microsoft.Rest.ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = Microsoft.Rest.ServiceClientTracing.NextInvocationId.ToString();
                System.Collections.Generic.Dictionary<string, object> tracingParameters = new System.Collections.Generic.Dictionary<string, object>();
                tracingParameters.Add("fileContent", fileContent);
                tracingParameters.Add("cancellationToken", cancellationToken);
                Microsoft.Rest.ServiceClientTracing.Enter(_invocationId, this, "UploadFileViaBody", tracingParameters);
            }
            // Construct URL
            var _baseUrl = this.Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "formdata/stream/uploadfile").ToString();
            // Create HTTP transport objects
            System.Net.Http.HttpRequestMessage _httpRequest = new System.Net.Http.HttpRequestMessage();
            System.Net.Http.HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new System.Net.Http.HttpMethod("PUT");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
             System.Net.Http.StreamContent _fileStreamContent = new System.Net.Http.StreamContent(fileContent);
            _httpRequest.Content = _fileStreamContent;
            _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/octet-stream");
            // Send Request
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await this.Client.HttpClient.SendAsync(_httpRequest, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            System.Net.HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new ErrorException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                try
                {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Error _errorBody =  Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<Error>(_responseContent, this.Client.DeserializationSettings);
                    if (_errorBody != null)
                    {
                        ex.Body = _errorBody;
                    }
                }
                catch (Newtonsoft.Json.JsonException)
                {
                    // Ignore the exception
                }
                ex.Request = new Microsoft.Rest.HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new Microsoft.Rest.HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    Microsoft.Rest.ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new Microsoft.Rest.HttpOperationResponse<System.IO.Stream>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _result.Body = await _httpResponse.Content.ReadAsStreamAsync().ConfigureAwait(false);
            }
            if (_shouldTrace)
            {
                Microsoft.Rest.ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
