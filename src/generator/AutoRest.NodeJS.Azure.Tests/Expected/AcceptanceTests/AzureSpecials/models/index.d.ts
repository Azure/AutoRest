/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 * 
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

import * as msRestAzure from 'ms-rest-azure';
exports.BaseResource = msRestAzure.BaseResource;
exports.CloudError = msRestAzure.CloudError;

/**
 * @class
 * Initializes a new instance of the ErrorModel class.
 * @constructor
 * @member {number} [status]
 * 
 * @member {number} [constantId]
 * 
 * @member {string} [message]
 * 
 */
export interface ErrorModel {
  status?: number;
  constantId?: number;
  message?: string;
}

/**
 * @class
 * Initializes a new instance of the OdataFilter class.
 * @constructor
 * @member {number} [id]
 * 
 * @member {string} [name]
 * 
 */
export interface OdataFilter {
  id?: number;
  name?: string;
}

/**
 * @class
 * Initializes a new instance of the HeaderCustomNamedRequestIdParamGroupingParameters class.
 * @constructor
 * Additional parameters for the Header_customNamedRequestIdParamGrouping
 * operation.
 *
 * @member {string} fooClientRequestId The fooRequestId
 * 
 */
export interface HeaderCustomNamedRequestIdParamGroupingParameters {
  fooClientRequestId: string;
}

