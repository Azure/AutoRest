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
 * @member {string} [message]
 * 
 */
export interface ErrorModel {
  status?: number;
  message?: string;
}

/**
 * @class
 * Initializes a new instance of the ParameterGroupingPostRequiredParameters class.
 * @constructor
 * Additional parameters for the parameterGrouping_postRequired operation.
 *
 * @member {number} body
 * 
 * @member {string} [customHeader]
 * 
 * @member {number} [query] Query parameter with default. Default value: 30 .
 * 
 * @member {string} path Path parameter
 * 
 */
export interface ParameterGroupingPostRequiredParameters {
  body: number;
  customHeader?: string;
  query?: number;
  path: string;
}

/**
 * @class
 * Initializes a new instance of the ParameterGroupingPostOptionalParameters class.
 * @constructor
 * Additional parameters for the parameterGrouping_postOptional operation.
 *
 * @member {string} [customHeader]
 * 
 * @member {number} [query] Query parameter with default. Default value: 30 .
 * 
 */
export interface ParameterGroupingPostOptionalParameters {
  customHeader?: string;
  query?: number;
}

/**
 * @class
 * Initializes a new instance of the FirstParameterGroup class.
 * @constructor
 * Additional parameters for a set of operations, such as:
 * parameterGrouping_postMultiParamGroups,
 * parameterGrouping_postSharedParameterGroupObject.
 *
 * @member {string} [headerOne]
 * 
 * @member {number} [queryOne] Query parameter with default. Default value: 30
 * .
 * 
 */
export interface FirstParameterGroup {
  headerOne?: string;
  queryOne?: number;
}

/**
 * @class
 * Initializes a new instance of the ParameterGroupingPostMultiParamGroupsSecondParamGroup class.
 * @constructor
 * Additional parameters for the parameterGrouping_postMultiParamGroups
 * operation.
 *
 * @member {string} [headerTwo]
 * 
 * @member {number} [queryTwo] Query parameter with default. Default value: 30
 * .
 * 
 */
export interface ParameterGroupingPostMultiParamGroupsSecondParamGroup {
  headerTwo?: string;
  queryTwo?: number;
}

