/*
 * Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * @class
 * Initializes a new instance of the CheckNameAvailabilityResult class.
 * @constructor
 * The CheckNameAvailability operation response.
 *
 * @member {boolean} [nameAvailable] Gets a boolean value that indicates
 * whether the name is available for you to use. If true, the name is
 * available. If false, the name has already been taken or invalid and cannot
 * be used.
 *
 * @member {string} [reason] Gets the reason that a storage account name could
 * not be used. The Reason element is only returned if NameAvailable is false.
 * Possible values include: 'AccountNameInvalid', 'AlreadyExists'
 *
 * @member {string} [message] Gets an error message explaining the Reason value
 * in more detail.
 *
 */
class CheckNameAvailabilityResult {
  constructor() {
  }

  /**
   * Defines the metadata of CheckNameAvailabilityResult
   *
   * @returns {object} metadata of CheckNameAvailabilityResult
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'CheckNameAvailabilityResult',
      type: {
        name: 'Composite',
        className: 'CheckNameAvailabilityResult',
        modelProperties: {
          nameAvailable: {
            required: false,
            serializedName: 'nameAvailable',
            type: {
              name: 'Boolean'
            }
          },
          reason: {
            required: false,
            serializedName: 'reason',
            type: {
              name: 'Enum',
              allowedValues: [ 'AccountNameInvalid', 'AlreadyExists' ]
            }
          },
          message: {
            required: false,
            serializedName: 'message',
            type: {
              name: 'String'
            }
          }
        }
      }
    };
  }
}

module.exports = CheckNameAvailabilityResult;
