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
 * Initializes a new instance of the Cookiecuttershark class.
 * @constructor
 */
class Cookiecuttershark extends models['Shark'] {
  constructor() {
    super();
  }

  /**
   * Defines the metadata of Cookiecuttershark
   *
   * @returns {object} metadata of Cookiecuttershark
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'cookiecuttershark',
      type: {
        name: 'Composite',
        className: 'Cookiecuttershark',
        modelProperties: {
          species: {
            required: false,
            serializedName: 'species',
            type: {
              name: 'String'
            }
          },
          length: {
            required: true,
            serializedName: 'length',
            type: {
              name: 'Number'
            }
          },
          siblings: {
            required: false,
            serializedName: 'siblings',
            type: {
              name: 'Sequence',
              element: {
                  required: false,
                  serializedName: 'FishElementType',
                  type: {
                    name: 'Composite',
                    polymorphicDiscriminator: {
                      serializedName: 'fishtype',
                      clientName: 'fishtype'
                    },
                    uberParent: 'Fish',
                    className: 'Fish'
                  }
              }
            }
          },
          fishtype: {
            required: true,
            serializedName: 'fishtype',
            type: {
              name: 'String'
            }
          },
          age: {
            required: false,
            serializedName: 'age',
            type: {
              name: 'Number'
            }
          },
          birthday: {
            required: true,
            serializedName: 'birthday',
            type: {
              name: 'DateTime'
            }
          }
        }
      }
    };
  }
}

module.exports = Cookiecuttershark;
