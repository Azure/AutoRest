/*
 */

'use strict';

const models = require('./index');

/**
 * @class
 * Initializes a new instance of the Resource class.
 * @constructor
 * @member {string} [id] Resource Id
 *
 * @member {string} [name] Resource name
 *
 * @member {string} [type] Resource type
 *
 * @member {string} [location] Resource location
 *
 * @member {object} [tags] Resource tags
 *
 */
class Resource extends models['BaseResource'] {
  constructor() {
    super();
  }

  /**
   * Defines the metadata of Resource
   *
   * @returns {object} metadata of Resource
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'Resource',
      type: {
        name: 'Composite',
        className: 'Resource',
        modelProperties: {
          id: {
            required: false,
            readOnly: true,
            serializedName: 'id',
            type: {
              name: 'String'
            }
          },
          name: {
            required: false,
            readOnly: true,
            serializedName: 'name',
            type: {
              name: 'String'
            }
          },
          type: {
            required: false,
            readOnly: true,
            serializedName: 'type',
            type: {
              name: 'String'
            }
          },
          location: {
            required: false,
            serializedName: 'location',
            type: {
              name: 'String'
            }
          },
          tags: {
            required: false,
            serializedName: 'tags',
            type: {
              name: 'Dictionary',
              value: {
                  required: false,
                  serializedName: 'StringElementType',
                  type: {
                    name: 'String'
                  }
              }
            }
          }
        }
      }
    };
  }
}

module.exports = Resource;
