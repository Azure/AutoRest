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

const models = require('./index');

/**
 * @class
 * Initializes a new instance of the SubProduct class.
 * @constructor
 * @member {string} [provisioningState]
 *
 * @member {string} [provisioningStateValues] Possible values include:
 * 'Succeeded', 'Failed', 'canceled', 'Accepted', 'Creating', 'Created',
 * 'Updating', 'Updated', 'Deleting', 'Deleted', 'OK'
 *
 */
class SubProduct extends models['SubResource'] {
  constructor() {
    super();
  }

  /**
   * Defines the metadata of SubProduct
   *
   * @returns {object} metadata of SubProduct
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'SubProduct',
      type: {
        name: 'Composite',
        className: 'SubProduct',
        modelProperties: {
          id: {
            required: false,
            readOnly: true,
            serializedName: 'id',
            type: {
              name: 'String'
            }
          },
          provisioningState: {
            required: false,
            serializedName: 'properties.provisioningState',
            type: {
              name: 'String'
            }
          },
          provisioningStateValues: {
            required: false,
            readOnly: true,
            serializedName: 'properties.provisioningStateValues',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = SubProduct;
