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
 * Class representing a StorageAccountCheckNameAvailabilityParameters.
 */
class StorageAccountCheckNameAvailabilityParameters {
  /**
   * Create a StorageAccountCheckNameAvailabilityParameters.
   * @member {string} name
   * @member {string} [type] Default value: 'Microsoft.Storage/storageAccounts'
   * .
   */
  constructor() {
  }

  /**
   * Defines the metadata of StorageAccountCheckNameAvailabilityParameters
   *
   * @returns {object} metadata of StorageAccountCheckNameAvailabilityParameters
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'StorageAccountCheckNameAvailabilityParameters',
      type: {
        name: 'Composite',
        className: 'StorageAccountCheckNameAvailabilityParameters',
        modelProperties: {
          name: {
            required: true,
            serializedName: 'name',
            type: {
              name: 'String'
            }
          },
          type: {
            required: false,
            serializedName: 'type',
            defaultValue: 'Microsoft.Storage/storageAccounts',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = StorageAccountCheckNameAvailabilityParameters;
