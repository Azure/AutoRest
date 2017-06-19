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

const msRest = require('ms-rest');
const WebResource = msRest.WebResource;

/**
 * Updates the tags for an availability set.
 *
 * @param {string} resourceGroupName The name of the resource group.
 *
 * @param {string} avset The name of the storage availability set.
 *
 * @param {object} tags A set of tags. A description about the set of tags.
 *
 * @param {object} [options] Optional Parameters.
 *
 * @param {object} [options.customHeaders] Headers that will be added to the
 * request
 *
 * @param {function} callback - The callback.
 *
 * @returns {function} callback(err, result, request, response)
 *
 *                      {Error}  err        - The Error object if an error occurred, null otherwise.
 *
 *                      {null} [result]   - The deserialized result object if an error did not occur.
 *
 *                      {object} [request]  - The HTTP Request object if an error did not occur.
 *
 *                      {stream} [response] - The HTTP Response stream if an error did not occur.
 */
function _update(resourceGroupName, avset, tags, options, callback) {
   /* jshint validthis: true */
  let client = this.client;
  if(!callback && typeof options === 'function') {
    callback = options;
    options = null;
  }
  if (!callback) {
    throw new Error('callback cannot be null.');
  }
  // Validate
  try {
    if (resourceGroupName === null || resourceGroupName === undefined || typeof resourceGroupName.valueOf() !== 'string') {
      throw new Error('resourceGroupName cannot be null or undefined and it must be of type string.');
    }
    if (avset === null || avset === undefined || typeof avset.valueOf() !== 'string') {
      throw new Error('avset cannot be null or undefined and it must be of type string.');
    }
    if (avset !== null && avset !== undefined) {
      if (avset.length > 80)
      {
        throw new Error('"avset" should satisfy the constraint - "MaxLength": 80');
      }
    }
    if (tags === null || tags === undefined || typeof tags !== 'object') {
      throw new Error('tags cannot be null or undefined and it must be of type object.');
    }
    for(let valueElement in tags) {
      if (tags[valueElement] !== null && tags[valueElement] !== undefined && typeof tags[valueElement].valueOf() !== 'string') {
        throw new Error('tags[valueElement] must be of type string.');
      }
    }
  } catch (error) {
    return callback(error);
  }
  let tags1;
  if (tags !== null && tags !== undefined) {
    tags1 = new client.models['AvailabilitySetUpdateParameters']();
    tags1.tags = tags;
  }

  // Construct URL
  let baseUrl = this.client.baseUri;
  let requestUrl = baseUrl + (baseUrl.endsWith('/') ? '' : '/') + 'parameterFlattening/{resourceGroupName}/{availabilitySetName}';
  requestUrl = requestUrl.replace('{resourceGroupName}', encodeURIComponent(resourceGroupName));
  requestUrl = requestUrl.replace('{availabilitySetName}', encodeURIComponent(avset));

  // Create HTTP transport objects
  let httpRequest = new WebResource();
  httpRequest.method = 'PATCH';
  httpRequest.headers = {};
  httpRequest.url = requestUrl;
  // Set Headers
  if(options) {
    for(let headerName in options['customHeaders']) {
      if (options['customHeaders'].hasOwnProperty(headerName)) {
        httpRequest.headers[headerName] = options['customHeaders'][headerName];
      }
    }
  }
  httpRequest.headers['Content-Type'] = 'application/json; charset=utf-8';
  // Serialize Request
  let requestContent = null;
  let requestModel = null;
  try {
    if (tags1 !== null && tags1 !== undefined) {
      let requestModelMapper = new client.models['AvailabilitySetUpdateParameters']().mapper();
      requestModel = client.serialize(requestModelMapper, tags1, 'tags1');
      requestContent = JSON.stringify(requestModel);
    }
  } catch (error) {
    let serializationError = new Error(`Error "${error.message}" occurred in serializing the ` +
        `payload - ${JSON.stringify(tags1, null, 2)}.`);
    return callback(serializationError);
  }
  httpRequest.body = requestContent;
  // Send Request
  return client.pipeline(httpRequest, (err, response, responseBody) => {
    if (err) {
      return callback(err);
    }
    let statusCode = response.statusCode;
    if (statusCode !== 200) {
      let error = new Error(responseBody);
      error.statusCode = response.statusCode;
      error.request = msRest.stripRequest(httpRequest);
      error.response = msRest.stripResponse(response);
      if (responseBody === '') responseBody = null;
      let parsedErrorResponse;
      try {
        parsedErrorResponse = JSON.parse(responseBody);
        if (parsedErrorResponse) {
          let internalError = null;
          if (parsedErrorResponse.error) internalError = parsedErrorResponse.error;
          error.code = internalError ? internalError.code : parsedErrorResponse.code;
          error.message = internalError ? internalError.message : parsedErrorResponse.message;
        }
      } catch (defaultError) {
        error.message = `Error "${defaultError.message}" occurred in deserializing the responseBody ` +
                         `- "${responseBody}" for the default response.`;
        return callback(error);
      }
      return callback(error);
    }
    // Create Result
    let result = null;
    if (responseBody === '') responseBody = null;

    return callback(null, result, httpRequest, response);
  });
}

/** Class representing a AvailabilitySets. */
class AvailabilitySets {
  /**
   * Create a AvailabilitySets.
   * @param {AutoRestParameterFlattening} client Reference to the service client.
   */
  constructor(client) {
    this.client = client;
    this._update = _update;
  }

  /**
   * Updates the tags for an availability set.
   *
   * @param {string} resourceGroupName The name of the resource group.
   *
   * @param {string} avset The name of the storage availability set.
   *
   * @param {object} tags A set of tags. A description about the set of tags.
   *
   * @param {object} [options] Optional Parameters.
   *
   * @param {object} [options.customHeaders] Headers that will be added to the
   * request
   *
   * @returns {Promise} A promise is returned
   *
   * @resolve {HttpOperationResponse<null>} - The deserialized result object.
   *
   * @reject {Error} - The error object.
   */
  updateWithHttpOperationResponse(resourceGroupName, avset, tags, options) {
    let client = this.client;
    let self = this;
    return new Promise((resolve, reject) => {
      self._update(resourceGroupName, avset, tags, options, (err, result, request, response) => {
        let httpOperationResponse = new msRest.HttpOperationResponse(request, response);
        httpOperationResponse.body = result;
        if (err) { reject(err); }
        else { resolve(httpOperationResponse); }
        return;
      });
    });
  }

  /**
   * Updates the tags for an availability set.
   *
   * @param {string} resourceGroupName The name of the resource group.
   *
   * @param {string} avset The name of the storage availability set.
   *
   * @param {object} tags A set of tags. A description about the set of tags.
   *
   * @param {object} [options] Optional Parameters.
   *
   * @param {object} [options.customHeaders] Headers that will be added to the
   * request
   *
   * @param {function} [optionalCallback] - The optional callback.
   *
   * @returns {function|Promise} If a callback was passed as the last parameter
   * then it returns the callback else returns a Promise.
   *
   * {Promise} A promise is returned
   *
   *                      @resolve {null} - The deserialized result object.
   *
   *                      @reject {Error} - The error object.
   *
   * {function} optionalCallback(err, result, request, response)
   *
   *                      {Error}  err        - The Error object if an error occurred, null otherwise.
   *
   *                      {null} [result]   - The deserialized result object if an error did not occur.
   *
   *                      {object} [request]  - The HTTP Request object if an error did not occur.
   *
   *                      {stream} [response] - The HTTP Response stream if an error did not occur.
   */
  update(resourceGroupName, avset, tags, options, optionalCallback) {
    let client = this.client;
    let self = this;
    if (!optionalCallback && typeof options === 'function') {
      optionalCallback = options;
      options = null;
    }
    if (!optionalCallback) {
      return new Promise((resolve, reject) => {
        self._update(resourceGroupName, avset, tags, options, (err, result, request, response) => {
          if (err) { reject(err); }
          else { resolve(result); }
          return;
        });
      });
    } else {
      return self._update(resourceGroupName, avset, tags, options, optionalCallback);
    }
  }

}

module.exports = AvailabilitySets;
