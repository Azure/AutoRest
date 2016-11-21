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

/**
 * @class
 * Initializes a new instance of the OdataProductResult class.
 * @constructor
 * @member {array} [values]
 *
 * @member {string} [odatanextLink]
 *
 */
function OdataProductResult() {
}

util.inherits(OdataProductResult, Array);

/**
 * Defines the metadata of OdataProductResult
 *
 * @returns {object} metadata of OdataProductResult
 *
 */
OdataProductResult.prototype.mapper = function () {
  return {
    required: false,
    serializedName: 'OdataProductResult',
    type: {
      name: 'Composite',
      className: 'OdataProductResult',
      modelProperties: {
        values: {
          required: false,
          serializedName: '',
          type: {
            name: 'Sequence',
            element: {
                required: false,
                serializedName: 'ProductElementType',
                type: {
                  name: 'Composite',
                  className: 'Product'
                }
            }
          }
        },
        odatanextLink: {
          required: false,
          serializedName: 'odata\\.nextLink',
          type: {
            name: 'String'
          }
        }
      }
    }
  };
};

module.exports = OdataProductResult;
