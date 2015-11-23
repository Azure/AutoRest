/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 * 
 * Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

var util = require('util');

/**
 * @class
 * Initializes a new instance of the ArrayWrapper class.
 * @constructor
 * @member {array} value
 * 
 */
function ArrayWrapper(parameters) {
  if (parameters !== null && parameters !== undefined) {
    if (parameters.value) {
      var tempParametersvalue = [];
      parameters.value.forEach(function(element) {
        if (element !== undefined) {
          element = element;
        }
        tempParametersvalue.push(element);
      });
      this.value = tempParametersvalue;
    }
  }    
}


/**
 * Validate the payload against the ArrayWrapper schema
 *
 * @param {JSON} payload
 *
 */
ArrayWrapper.prototype.serialize = function () {
  var payload = {};
  if (!util.isArray(this['value'])) {
    throw new Error('this[\'value\'] cannot be null or undefined and it must be of type array.');
  }
  payload['value'] = [];
  for (var i = 0; i < this['value'].length; i++) {
    if (this['value'][i] !== null && this['value'][i] !== undefined) {
      if (typeof this['value'][i].valueOf() !== 'string') {
        throw new Error('this[\'value\'][i] must be of type string.');
      }
      if (payload['value'] === null || payload['value'] === undefined) {
        payload['value'] = {};
      }
      payload['value'][i] = this['value'][i];
    }
  }

  return payload;
};

/**
 * Deserialize the instance to ArrayWrapper schema
 *
 * @param {JSON} instance
 *
 */
ArrayWrapper.prototype.deserialize = function (instance) {
  if (instance) {
    if (instance['value']) {
      var tempInstancevalue = [];
      instance['value'].forEach(function(element1) {
        if (element1 !== undefined) {
          element1 = element1;
        }
        tempInstancevalue.push(element1);
      });
      this['value'] = tempInstancevalue;
    }
  }

  return this;
};

module.exports = ArrayWrapper;
