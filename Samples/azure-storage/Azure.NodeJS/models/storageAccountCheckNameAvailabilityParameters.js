/*
 */

'use strict';

/**
 * @class
 * Initializes a new instance of the StorageAccountCheckNameAvailabilityParameters class.
 * @constructor
 * @member {string} name
 *
 * @member {string} [type] Default value: 'Microsoft.Storage/storageAccounts' .
 *
 */
class StorageAccountCheckNameAvailabilityParameters {
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
