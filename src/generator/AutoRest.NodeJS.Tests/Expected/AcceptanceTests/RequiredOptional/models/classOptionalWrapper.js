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
 * Class representing a ClassOptionalWrapper.
 */
class ClassOptionalWrapper {
  /**
   * Create a ClassOptionalWrapper.
   * @member {object} [value]
   * @member {number} [value.id]
   * @member {string} [value.name]
   */
  constructor() {
  }

  /**
   * Defines the metadata of ClassOptionalWrapper
   *
   * @returns {object} metadata of ClassOptionalWrapper
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'class-optional-wrapper',
      type: {
        name: 'Composite',
        className: 'ClassOptionalWrapper',
        modelProperties: {
          value: {
            required: false,
            serializedName: 'value',
            type: {
              name: 'Composite',
              className: 'Product'
            }
          }
        }
      }
    };
  }
}

module.exports = ClassOptionalWrapper;
