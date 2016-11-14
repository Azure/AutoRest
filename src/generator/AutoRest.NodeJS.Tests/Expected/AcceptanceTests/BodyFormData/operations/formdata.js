/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 * 
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

var util = require('util');
var msRest = require('ms-rest');
var WebResource = msRest.WebResource;

/**
 * @class
 * Formdata
 * __NOTE__: An instance of this class is automatically created for an
 * instance of the AutoRestSwaggerBATFormDataService.
 * Initializes a new instance of the Formdata class.
 * @constructor
 *
 * @param {AutoRestSwaggerBATFormDataService} client Reference to the service client.
 */
function Formdata(client) {
  this.client = client;
}

/**
 * Upload file
 *
 * @param {object} fileContent File to upload.
 * 
 * @param {string} fileName File name to upload. Name has to be spelled exactly
 * as written here.
 * 
 * @param {object} [options] Optional Parameters.
 * 
 * @param {object} [options.customHeaders] Headers that will be added to the
 * request
 * 
 * @param {function} callback
 *
 * @returns {function} callback(err, result, request, response)
 *
 *                      {Error}  err        - The Error object if an error occurred, null otherwise.
 *
 *                      {object} [result]   - The deserialized result object.
 *
 *                      {object} [request]  - The HTTP Request object if an error did not occur.
 *
 *                      {stream} [response] - The HTTP Response stream if an error did not occur.
 */
Formdata.prototype.uploadFile = function (fileContent, fileName, options, callback) {
  var client = this.client;
  if(!callback && typeof options === 'function') {
    callback = options;
    options = null;
  }
  if (!callback) {
    throw new Error('callback cannot be null.');
  }
  // Validate
  try {
    if (fileContent === null || fileContent === undefined) {
      throw new Error('fileContent cannot be null or undefined and it must be of type object.');
    }
    if (fileName === null || fileName === undefined || typeof fileName.valueOf() !== 'string') {
      throw new Error('fileName cannot be null or undefined and it must be of type string.');
    }
  } catch (error) {
    return callback(error);
  }

  // Construct URL
  var baseUrl = this.client.baseUri;
  var requestUrl = baseUrl + (baseUrl.endsWith('/') ? '' : '/') + 'formdata/stream/uploadfile';

  // Create HTTP transport objects
  var httpRequest = new WebResource();
  httpRequest.method = 'POST';
  httpRequest.headers = {};
  httpRequest.url = requestUrl;
  // Set Headers
  if(options) {
    for(var headerName in options['customHeaders']) {
      if (options['customHeaders'].hasOwnProperty(headerName)) {
        httpRequest.headers[headerName] = options['customHeaders'][headerName];
      }
    }
  }
  httpRequest.headers['Content-Type'] = 'multipart/form-data';
  // Serialize Request  
  var formData = {};  
  if (fileContent !== undefined && fileContent !== null) {
    formData['fileContent'] = fileContent;  
  }
  if (fileName !== undefined && fileName !== null) {
    formData['fileName'] = fileName;
  }
  httpRequest.formData = formData;
  // Send Request
  httpRequest.streamedResponse = true;
  return client.pipeline(httpRequest, function (err, response, responseBody) {
    if (err) {
      return callback(err);
    }

    var statusCode = response.statusCode;
    if (statusCode !== 200) {
      var error = new Error(util.format('Unexpected status code: %s', statusCode));
      error.statusCode = response.statusCode;
      error.request = msRest.stripRequest(httpRequest);
      error.response = msRest.stripResponse(response);
      if (responseBody === '') responseBody = null;
      var parsedErrorResponse;
      try {
        if (responseBody !== undefined) parsedErrorResponse = JSON.parse(responseBody);
        if (parsedErrorResponse) {
          var internalError = null;
          if (parsedErrorResponse.error) internalError = parsedErrorResponse.error;
          if (parsedErrorResponse.code) error.code = internalError ? internalError.code : parsedErrorResponse.code;
          if (parsedErrorResponse.message) error.message = internalError ? internalError.message : parsedErrorResponse.message;
        }
        if (parsedErrorResponse !== null && parsedErrorResponse !== undefined) {
          var resultMapper = new client.models['ErrorModel']().mapper();
          error.body = client.deserialize(resultMapper, parsedErrorResponse, 'error.body');
        }
      } catch (defaultError) {
        error.message = util.format('Error "%s" occurred in deserializing the responseBody ' + 
                         '- "%s" for the default response.', defaultError.message, responseBody);
        return callback(error);
      }
      return callback(error);
    }

    // Create Result
    var result = response;
    return callback(null, result, httpRequest, response);
  });
};

/**
 * Upload file
 *
 * @param {object} fileContent File to upload.
 * 
 * @param {object} [options] Optional Parameters.
 * 
 * @param {object} [options.customHeaders] Headers that will be added to the
 * request
 * 
 * @param {function} callback
 *
 * @returns {function} callback(err, result, request, response)
 *
 *                      {Error}  err        - The Error object if an error occurred, null otherwise.
 *
 *                      {object} [result]   - The deserialized result object.
 *
 *                      {object} [request]  - The HTTP Request object if an error did not occur.
 *
 *                      {stream} [response] - The HTTP Response stream if an error did not occur.
 */
Formdata.prototype.uploadFileViaBody = function (fileContent, options, callback) {
  var client = this.client;
  if(!callback && typeof options === 'function') {
    callback = options;
    options = null;
  }
  if (!callback) {
    throw new Error('callback cannot be null.');
  }
  // Validate
  try {
    if (fileContent === null || fileContent === undefined) {
      throw new Error('fileContent cannot be null or undefined and it must be of type object.');
    }
  } catch (error) {
    return callback(error);
  }

  // Construct URL
  var baseUrl = this.client.baseUri;
  var requestUrl = baseUrl + (baseUrl.endsWith('/') ? '' : '/') + 'formdata/stream/uploadfile';

  // Create HTTP transport objects
  var httpRequest = new WebResource();
  httpRequest.method = 'PUT';
  httpRequest.headers = {};
  httpRequest.url = requestUrl;
  // Set Headers
  if(options) {
    for(var headerName in options['customHeaders']) {
      if (options['customHeaders'].hasOwnProperty(headerName)) {
        httpRequest.headers[headerName] = options['customHeaders'][headerName];
      }
    }
  }
  httpRequest.headers['Content-Type'] = 'application/octet-stream';
  // Serialize Request  
  var requestContent = fileContent;
  httpRequest.body = requestContent;
  // Send Request
  httpRequest.streamedResponse = true;
  return client.pipeline(httpRequest, function (err, response, responseBody) {
    if (err) {
      return callback(err);
    }

    var statusCode = response.statusCode;
    if (statusCode !== 200) {
      var error = new Error(util.format('Unexpected status code: %s', statusCode));
      error.statusCode = response.statusCode;
      error.request = msRest.stripRequest(httpRequest);
      error.response = msRest.stripResponse(response);
      if (responseBody === '') responseBody = null;
      var parsedErrorResponse;
      try {
        if (responseBody !== undefined) parsedErrorResponse = JSON.parse(responseBody);
        if (parsedErrorResponse) {
          var internalError = null;
          if (parsedErrorResponse.error) internalError = parsedErrorResponse.error;
          if (parsedErrorResponse.code) error.code = internalError ? internalError.code : parsedErrorResponse.code;
          if (parsedErrorResponse.message) error.message = internalError ? internalError.message : parsedErrorResponse.message;
        }
        if (parsedErrorResponse !== null && parsedErrorResponse !== undefined) {
          var resultMapper = new client.models['ErrorModel']().mapper();
          error.body = client.deserialize(resultMapper, parsedErrorResponse, 'error.body');
        }
      } catch (defaultError) {
        error.message = util.format('Error "%s" occurred in deserializing the responseBody ' + 
                         '- "%s" for the default response.', defaultError.message, responseBody);
        return callback(error);
      }
      return callback(error);
    }

    // Create Result
    var result = response;
    return callback(null, result, httpRequest, response);
  });
};


module.exports = Formdata;
