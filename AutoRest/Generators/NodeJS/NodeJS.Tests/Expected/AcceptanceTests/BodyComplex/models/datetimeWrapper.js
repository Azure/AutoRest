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

/**
 * @class
 * Initializes a new instance of the DatetimeWrapper class.
 * @constructor
 * @member {date} [field]
 * 
 * @member {date} [now]
 * 
 */
function DatetimeWrapper(parameters) {
  if (parameters !== null && parameters !== undefined) {
    if (parameters.field !== undefined) {
      this.field = parameters.field;
    }
    if (parameters.now !== undefined) {
      this.now = parameters.now;
    }
  }    
}


/**
 * Validate the payload against the DatetimeWrapper schema
 *
 * @param {JSON} payload
 *
 */
DatetimeWrapper.prototype.serialize = function () {
  var payload = {};
  if (this['field']) {
    if (!(this['field'] instanceof Date || typeof this['field'].valueOf() === 'string' && !isNaN(Date.parse(this['field'])))) {
      throw new Error('this[\'field\'] must be of type date.');
    }
    payload['field'] = (this['field'] instanceof Date) ? this['field'].toISOString() : this['field'];
  }

  if (this['now']) {
    if (!(this['now'] instanceof Date || typeof this['now'].valueOf() === 'string' && !isNaN(Date.parse(this['now'])))) {
      throw new Error('this[\'now\'] must be of type date.');
    }
    payload['now'] = (this['now'] instanceof Date) ? this['now'].toISOString() : this['now'];
  }

  return payload;
};

/**
 * Deserialize the instance to DatetimeWrapper schema
 *
 * @param {JSON} instance
 *
 */
DatetimeWrapper.prototype.deserialize = function (instance) {
  if (instance) {
    if (instance['field']) {
      this['field'] = new Date(instance['field']);
    }
    else if (instance['field'] !== undefined) {
      this['field'] = instance['field'];
    }

    if (instance['now']) {
      this['now'] = new Date(instance['now']);
    }
    else if (instance['now'] !== undefined) {
      this['now'] = instance['now'];
    }
  }

  return this;
};

module.exports = DatetimeWrapper;
