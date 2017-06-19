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

/**
 * Class representing a StringWrapper.
 */
class StringWrapper {
  /**
   * Create a StringWrapper.
   * @member {string} [field]
   * @member {string} [empty]
   * @member {string} [nullProperty]
   */
  constructor() {
  }

  /**
   * Defines the metadata of StringWrapper
   *
   * @returns {object} metadata of StringWrapper
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'string-wrapper',
      type: {
        name: 'Composite',
        className: 'StringWrapper',
        modelProperties: {
          field: {
            required: false,
            serializedName: 'field',
            type: {
              name: 'String'
            }
          },
          empty: {
            required: false,
            serializedName: 'empty',
            type: {
              name: 'String'
            }
          },
          nullProperty: {
            required: false,
            serializedName: 'null',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = StringWrapper;
