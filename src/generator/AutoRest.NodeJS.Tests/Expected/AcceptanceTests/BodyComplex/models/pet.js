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
 * @class
 * Initializes a new instance of the Pet class.
 * @constructor
 * @member {number} [id]
 *
 * @member {string} [name]
 *
 */
class Pet {
  constructor() {
  }

  /**
   * Defines the metadata of Pet
   *
   * @returns {object} metadata of Pet
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'pet',
      type: {
        name: 'Composite',
        className: 'Pet',
        modelProperties: {
          id: {
            required: false,
            serializedName: 'id',
            type: {
              name: 'Number'
            }
          },
          name: {
            required: false,
            serializedName: 'name',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = Pet;
