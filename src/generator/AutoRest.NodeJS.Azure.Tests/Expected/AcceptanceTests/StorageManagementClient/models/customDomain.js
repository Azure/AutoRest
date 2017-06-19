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
 * The custom domain assigned to this storage account. This can be set via
 * Update.
 *
 */
class CustomDomain {
  /**
   * Create a CustomDomain.
   * @member {string} [name] Gets or sets the custom domain name. Name is the
   * CNAME source.
   * @member {boolean} [useSubDomain] Indicates whether indirect CName
   * validation is enabled. Default value is false. This should only be set on
   * updates
   */
  constructor() {
  }

  /**
   * Defines the metadata of CustomDomain
   *
   * @returns {object} metadata of CustomDomain
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'CustomDomain',
      type: {
        name: 'Composite',
        className: 'CustomDomain',
        modelProperties: {
          name: {
            required: false,
            serializedName: 'name',
            type: {
              name: 'String'
            }
          },
          useSubDomain: {
            required: false,
            serializedName: 'useSubDomain',
            type: {
              name: 'Boolean'
            }
          }
        }
      }
    };
  }
}

module.exports = CustomDomain;
