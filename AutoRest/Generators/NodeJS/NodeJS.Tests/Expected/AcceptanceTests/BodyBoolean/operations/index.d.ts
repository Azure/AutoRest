/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
*/

import { ServiceClientOptions, RequestOptions, ServiceCallback } from 'ms-rest';
import * as models from '../models';


/**
 * @class
 * Bool
 * __NOTE__: An instance of this class is automatically created for an
 * instance of the AutoRestBoolTestService.
 */
export interface Bool {

    /**
     * Get true Boolean value
     *
     * @param {object} [options] Optional Parameters.
     * 
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     * 
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getTrue(options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<boolean>): void;
    getTrue(callback: ServiceCallback<boolean>): void;

    /**
     * Set Boolean value true
     *
     * @param {boolean} boolBody
     * 
     * @param {object} [options] Optional Parameters.
     * 
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     * 
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    putTrue(boolBody: boolean, options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<void>): void;
    putTrue(boolBody: boolean, callback: ServiceCallback<void>): void;

    /**
     * Get false Boolean value
     *
     * @param {object} [options] Optional Parameters.
     * 
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     * 
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getFalse(options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<boolean>): void;
    getFalse(callback: ServiceCallback<boolean>): void;

    /**
     * Set Boolean value false
     *
     * @param {boolean} boolBody
     * 
     * @param {object} [options] Optional Parameters.
     * 
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     * 
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    putFalse(boolBody: boolean, options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<void>): void;
    putFalse(boolBody: boolean, callback: ServiceCallback<void>): void;

    /**
     * Get null Boolean value
     *
     * @param {object} [options] Optional Parameters.
     * 
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     * 
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getNull(options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<boolean>): void;
    getNull(callback: ServiceCallback<boolean>): void;

    /**
     * Get invalid Boolean value
     *
     * @param {object} [options] Optional Parameters.
     * 
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     * 
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getInvalid(options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<boolean>): void;
    getInvalid(callback: ServiceCallback<boolean>): void;
}
