/*
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * @class
 * Initializes a new instance of the Pet class.
 * @constructor
 * @member {number} id
 *
 * @member {string} name
 *
 * @member {string} [tag]
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
      serializedName: 'Pet',
      type: {
        name: 'Composite',
        className: 'Pet',
        modelProperties: {
          id: {
            required: true,
            serializedName: 'id',
            type: {
              name: 'Number'
            }
          },
          name: {
            required: true,
            serializedName: 'name',
            type: {
              name: 'String'
            }
          },
          tag: {
            required: false,
            serializedName: 'tag',
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
