/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

import { ServiceClient, ServiceClientOptions, RequestOptions, ServiceCallback, HttpOperationResponse } from 'ms-rest';
import * as operations from "./operations";

/**
 * AutoRestParameterizedCustomHostTestClientOptions for AutoRestParameterizedCustomHostTestClient.
 */
declare interface AutoRestParameterizedCustomHostTestClientOptions extends ServiceClientOptions {
  /**
   * @property {string} [dnsSuffix] - A string value that is used as a global part of the parameterized host. Default value 'host'.
   */
  dnsSuffix?: String;
}

declare class AutoRestParameterizedCustomHostTestClient extends ServiceClient {
  /**
   * @class
   * Initializes a new instance of the AutoRestParameterizedCustomHostTestClient class.
   * @constructor
   *
   * @param {string} subscriptionId - The subscription id with value 'test12'.
   *
   * @param {object} [options] - The parameter options
   *
   * @param {Array} [options.filters] - Filters to be added to the request pipeline
   *
   * @param {object} [options.requestOptions] - Options for the underlying request object
   * {@link https://github.com/request/request#requestoptions-callback Options doc}
   *
   * @param {boolean} [options.noRetryPolicy] - If set to true, turn off default retry policy
   *
   * @param {string} [options.dnsSuffix] - A string value that is used as a global part of the parameterized host. Default value 'host'.
   *
   */
  constructor(subscriptionId: string, options?: AutoRestParameterizedCustomHostTestClientOptions);

  subscriptionId: string;

  dnsSuffix: string;

  // Operation groups
  paths: operations.Paths;
}

export = AutoRestParameterizedCustomHostTestClient;
