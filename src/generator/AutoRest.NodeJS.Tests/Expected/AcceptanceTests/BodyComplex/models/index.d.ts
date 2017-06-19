/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

import * as moment from "moment";


/**
 * @class
 * Initializes a new instance of the ErrorModel class.
 * @constructor
 * @member {number} [status]
 * @member {string} [message]
 */
export interface ErrorModel {
  status?: number;
  message?: string;
}

/**
 * @class
 * Initializes a new instance of the Basic class.
 * @constructor
 * @member {number} [id] Basic Id
 * @member {string} [name] Name property with a very long description that does
 * not fit on a single line and a line break.
 * @member {string} [color] Possible values include: 'cyan', 'Magenta',
 * 'YELLOW', 'blacK'
 */
export interface Basic {
  id?: number;
  name?: string;
  color?: string;
}

/**
 * @class
 * Initializes a new instance of the Pet class.
 * @constructor
 * @member {number} [id]
 * @member {string} [name]
 */
export interface Pet {
  id?: number;
  name?: string;
}

/**
 * @class
 * Initializes a new instance of the Dog class.
 * @constructor
 * @member {string} [food]
 */
export interface Dog extends Pet {
  food?: string;
}

/**
 * @class
 * Initializes a new instance of the Cat class.
 * @constructor
 * @member {string} [color]
 * @member {array} [hates]
 */
export interface Cat extends Pet {
  color?: string;
  hates?: Dog[];
}

/**
 * @class
 * Initializes a new instance of the Siamese class.
 * @constructor
 * @member {string} [breed]
 */
export interface Siamese extends Cat {
  breed?: string;
}

/**
 * @class
 * Initializes a new instance of the Fish class.
 * @constructor
 * @member {string} [species]
 * @member {number} length
 * @member {array} [siblings]
 * @member {string} fishtype Polymorphic Discriminator
 */
export interface Fish {
  species?: string;
  length: number;
  siblings?: Fish[];
  fishtype: string;
}

/**
 * @class
 * Initializes a new instance of the Salmon class.
 * @constructor
 * @member {string} [location]
 * @member {boolean} [iswild]
 */
export interface Salmon extends Fish {
  location?: string;
  iswild?: boolean;
}

/**
 * @class
 * Initializes a new instance of the Shark class.
 * @constructor
 * @member {number} [age]
 * @member {date} birthday
 */
export interface Shark extends Fish {
  age?: number;
  birthday: Date;
}

/**
 * @class
 * Initializes a new instance of the Sawshark class.
 * @constructor
 * @member {buffer} [picture]
 */
export interface Sawshark extends Shark {
  picture?: Buffer;
}

/**
 * @class
 * Initializes a new instance of the Goblinshark class.
 * @constructor
 * @member {number} [jawsize]
 */
export interface Goblinshark extends Shark {
  jawsize?: number;
}

/**
 * @class
 * Initializes a new instance of the Cookiecuttershark class.
 * @constructor
 */
export interface Cookiecuttershark extends Shark {
}

/**
 * @class
 * Initializes a new instance of the IntWrapper class.
 * @constructor
 * @member {number} [field1]
 * @member {number} [field2]
 */
export interface IntWrapper {
  field1?: number;
  field2?: number;
}

/**
 * @class
 * Initializes a new instance of the LongWrapper class.
 * @constructor
 * @member {number} [field1]
 * @member {number} [field2]
 */
export interface LongWrapper {
  field1?: number;
  field2?: number;
}

/**
 * @class
 * Initializes a new instance of the FloatWrapper class.
 * @constructor
 * @member {number} [field1]
 * @member {number} [field2]
 */
export interface FloatWrapper {
  field1?: number;
  field2?: number;
}

/**
 * @class
 * Initializes a new instance of the DoubleWrapper class.
 * @constructor
 * @member {number} [field1]
 * @member {number}
 * [field56ZerosAfterTheDotAndNegativeZeroBeforeDotAndThisIsALongFieldNameOnPurpose]
 */
export interface DoubleWrapper {
  field1?: number;
  field56ZerosAfterTheDotAndNegativeZeroBeforeDotAndThisIsALongFieldNameOnPurpose?: number;
}

/**
 * @class
 * Initializes a new instance of the BooleanWrapper class.
 * @constructor
 * @member {boolean} [fieldTrue]
 * @member {boolean} [fieldFalse]
 */
export interface BooleanWrapper {
  fieldTrue?: boolean;
  fieldFalse?: boolean;
}

/**
 * @class
 * Initializes a new instance of the StringWrapper class.
 * @constructor
 * @member {string} [field]
 * @member {string} [empty]
 * @member {string} [nullProperty]
 */
export interface StringWrapper {
  field?: string;
  empty?: string;
  nullProperty?: string;
}

/**
 * @class
 * Initializes a new instance of the DateWrapper class.
 * @constructor
 * @member {date} [field]
 * @member {date} [leap]
 */
export interface DateWrapper {
  field?: Date;
  leap?: Date;
}

/**
 * @class
 * Initializes a new instance of the DatetimeWrapper class.
 * @constructor
 * @member {date} [field]
 * @member {date} [now]
 */
export interface DatetimeWrapper {
  field?: Date;
  now?: Date;
}

/**
 * @class
 * Initializes a new instance of the Datetimerfc1123Wrapper class.
 * @constructor
 * @member {date} [field]
 * @member {date} [now]
 */
export interface Datetimerfc1123Wrapper {
  field?: Date;
  now?: Date;
}

/**
 * @class
 * Initializes a new instance of the DurationWrapper class.
 * @constructor
 * @member {moment.duration} [field]
 */
export interface DurationWrapper {
  field?: moment.Duration;
}

/**
 * @class
 * Initializes a new instance of the ByteWrapper class.
 * @constructor
 * @member {buffer} [field]
 */
export interface ByteWrapper {
  field?: Buffer;
}

/**
 * @class
 * Initializes a new instance of the ArrayWrapper class.
 * @constructor
 * @member {array} [arrayProperty]
 */
export interface ArrayWrapper {
  arrayProperty?: string[];
}

/**
 * @class
 * Initializes a new instance of the DictionaryWrapper class.
 * @constructor
 * @member {object} [defaultProgram]
 */
export interface DictionaryWrapper {
  defaultProgram?: { [propertyName: string]: string };
}

/**
 * @class
 * Initializes a new instance of the ReadonlyObj class.
 * @constructor
 * @member {string} [id]
 * @member {number} [size]
 */
export interface ReadonlyObj {
  readonly id?: string;
  size?: number;
}
