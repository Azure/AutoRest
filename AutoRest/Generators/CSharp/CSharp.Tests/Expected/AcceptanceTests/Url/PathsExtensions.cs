// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsUrl
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class PathsExtensions
    {
            /// <summary>
            /// Get true Boolean value on path
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='boolPath'>
            /// true boolean value
            /// </param>
            public static void GetBooleanTrue(this IPaths operations, bool? boolPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).GetBooleanTrueAsync(boolPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get true Boolean value on path
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='boolPath'>
            /// true boolean value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetBooleanTrueAsync( this IPaths operations, bool? boolPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetBooleanTrueWithHttpMessagesAsync(boolPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get false Boolean value on path
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='boolPath'>
            /// false boolean value
            /// </param>
            public static void GetBooleanFalse(this IPaths operations, bool? boolPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).GetBooleanFalseAsync(boolPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get false Boolean value on path
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='boolPath'>
            /// false boolean value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetBooleanFalseAsync( this IPaths operations, bool? boolPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetBooleanFalseWithHttpMessagesAsync(boolPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '1000000' integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='intPath'>
            /// '1000000' integer value
            /// </param>
            public static void GetIntOneMillion(this IPaths operations, int? intPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).GetIntOneMillionAsync(intPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '1000000' integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='intPath'>
            /// '1000000' integer value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetIntOneMillionAsync( this IPaths operations, int? intPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetIntOneMillionWithHttpMessagesAsync(intPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '-1000000' integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='intPath'>
            /// '-1000000' integer value
            /// </param>
            public static void GetIntNegativeOneMillion(this IPaths operations, int? intPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).GetIntNegativeOneMillionAsync(intPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '-1000000' integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='intPath'>
            /// '-1000000' integer value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetIntNegativeOneMillionAsync( this IPaths operations, int? intPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetIntNegativeOneMillionWithHttpMessagesAsync(intPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '10000000000' 64 bit integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='longPath'>
            /// '10000000000' 64 bit integer value
            /// </param>
            public static void GetTenBillion(this IPaths operations, long? longPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).GetTenBillionAsync(longPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '10000000000' 64 bit integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='longPath'>
            /// '10000000000' 64 bit integer value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetTenBillionAsync( this IPaths operations, long? longPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetTenBillionWithHttpMessagesAsync(longPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '-10000000000' 64 bit integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='longPath'>
            /// '-10000000000' 64 bit integer value
            /// </param>
            public static void GetNegativeTenBillion(this IPaths operations, long? longPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).GetNegativeTenBillionAsync(longPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '-10000000000' 64 bit integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='longPath'>
            /// '-10000000000' 64 bit integer value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetNegativeTenBillionAsync( this IPaths operations, long? longPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetNegativeTenBillionWithHttpMessagesAsync(longPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '1.034E+20' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floatPath'>
            /// '1.034E+20'numeric value
            /// </param>
            public static void FloatScientificPositive(this IPaths operations, double? floatPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).FloatScientificPositiveAsync(floatPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '1.034E+20' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floatPath'>
            /// '1.034E+20'numeric value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task FloatScientificPositiveAsync( this IPaths operations, double? floatPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.FloatScientificPositiveWithHttpMessagesAsync(floatPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '-1.034E-20' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floatPath'>
            /// '-1.034E-20'numeric value
            /// </param>
            public static void FloatScientificNegative(this IPaths operations, double? floatPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).FloatScientificNegativeAsync(floatPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '-1.034E-20' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='floatPath'>
            /// '-1.034E-20'numeric value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task FloatScientificNegativeAsync( this IPaths operations, double? floatPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.FloatScientificNegativeWithHttpMessagesAsync(floatPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '9999999.999' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='doublePath'>
            /// '9999999.999'numeric value
            /// </param>
            public static void DoubleDecimalPositive(this IPaths operations, double? doublePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).DoubleDecimalPositiveAsync(doublePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '9999999.999' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='doublePath'>
            /// '9999999.999'numeric value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DoubleDecimalPositiveAsync( this IPaths operations, double? doublePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DoubleDecimalPositiveWithHttpMessagesAsync(doublePath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '-9999999.999' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='doublePath'>
            /// '-9999999.999'numeric value
            /// </param>
            public static void DoubleDecimalNegative(this IPaths operations, double? doublePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).DoubleDecimalNegativeAsync(doublePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '-9999999.999' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='doublePath'>
            /// '-9999999.999'numeric value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DoubleDecimalNegativeAsync( this IPaths operations, double? doublePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DoubleDecimalNegativeWithHttpMessagesAsync(doublePath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '啊齄丂狛狜隣郎隣兀﨩' multi-byte string value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringPath'>
            /// '啊齄丂狛狜隣郎隣兀﨩'multi-byte string value. Possible values for this parameter
            /// include: '啊齄丂狛狜隣郎隣兀﨩'
            /// </param>
            public static void StringUnicode(this IPaths operations, string stringPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).StringUnicodeAsync(stringPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '啊齄丂狛狜隣郎隣兀﨩' multi-byte string value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringPath'>
            /// '啊齄丂狛狜隣郎隣兀﨩'multi-byte string value. Possible values for this parameter
            /// include: '啊齄丂狛狜隣郎隣兀﨩'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StringUnicodeAsync( this IPaths operations, string stringPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StringUnicodeWithHttpMessagesAsync(stringPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get 'begin!*'();:@ &amp;=+$,/?#[]end
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringPath'>
            /// 'begin!*'();:@ &amp;=+$,/?#[]end' url encoded string value. Possible
            /// values for this parameter include: 'begin!*'();:@ &amp;=+$,/?#[]end'
            /// </param>
            public static void StringUrlEncoded(this IPaths operations, string stringPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).StringUrlEncodedAsync(stringPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get 'begin!*'();:@ &amp;=+$,/?#[]end
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringPath'>
            /// 'begin!*'();:@ &amp;=+$,/?#[]end' url encoded string value. Possible
            /// values for this parameter include: 'begin!*'();:@ &amp;=+$,/?#[]end'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StringUrlEncodedAsync( this IPaths operations, string stringPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StringUrlEncodedWithHttpMessagesAsync(stringPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get ''
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringPath'>
            /// '' string value. Possible values for this parameter include: ''
            /// </param>
            public static void StringEmpty(this IPaths operations, string stringPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).StringEmptyAsync(stringPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get ''
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringPath'>
            /// '' string value. Possible values for this parameter include: ''
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StringEmptyAsync( this IPaths operations, string stringPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StringEmptyWithHttpMessagesAsync(stringPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get null (should throw)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringPath'>
            /// null string value
            /// </param>
            public static void StringNull(this IPaths operations, string stringPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).StringNullAsync(stringPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null (should throw)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringPath'>
            /// null string value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StringNullAsync( this IPaths operations, string stringPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StringNullWithHttpMessagesAsync(stringPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get using uri with 'green color' in path parameter
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enumPath'>
            /// send the value green. Possible values for this parameter include: 'red
            /// color', 'green color', 'blue color'
            /// </param>
            public static void EnumValid(this IPaths operations, UriColor? enumPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).EnumValidAsync(enumPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get using uri with 'green color' in path parameter
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enumPath'>
            /// send the value green. Possible values for this parameter include: 'red
            /// color', 'green color', 'blue color'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EnumValidAsync( this IPaths operations, UriColor? enumPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.EnumValidWithHttpMessagesAsync(enumPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get null (should throw on the client before the request is sent on wire)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enumPath'>
            /// send null should throw. Possible values for this parameter include: 'red
            /// color', 'green color', 'blue color'
            /// </param>
            public static void EnumNull(this IPaths operations, UriColor? enumPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).EnumNullAsync(enumPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null (should throw on the client before the request is sent on wire)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enumPath'>
            /// send null should throw. Possible values for this parameter include: 'red
            /// color', 'green color', 'blue color'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EnumNullAsync( this IPaths operations, UriColor? enumPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.EnumNullWithHttpMessagesAsync(enumPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '啊齄丂狛狜隣郎隣兀﨩' multibyte value as utf-8 encoded byte array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bytePath'>
            /// '啊齄丂狛狜隣郎隣兀﨩' multibyte value as utf-8 encoded byte array
            /// </param>
            public static void ByteMultiByte(this IPaths operations, byte[] bytePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).ByteMultiByteAsync(bytePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '啊齄丂狛狜隣郎隣兀﨩' multibyte value as utf-8 encoded byte array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bytePath'>
            /// '啊齄丂狛狜隣郎隣兀﨩' multibyte value as utf-8 encoded byte array
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ByteMultiByteAsync( this IPaths operations, byte[] bytePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ByteMultiByteWithHttpMessagesAsync(bytePath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '' as byte array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bytePath'>
            /// '' as byte array
            /// </param>
            public static void ByteEmpty(this IPaths operations, byte[] bytePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).ByteEmptyAsync(bytePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '' as byte array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bytePath'>
            /// '' as byte array
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ByteEmptyAsync( this IPaths operations, byte[] bytePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ByteEmptyWithHttpMessagesAsync(bytePath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get null as byte array (should throw)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bytePath'>
            /// null as byte array (should throw)
            /// </param>
            public static void ByteNull(this IPaths operations, byte[] bytePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).ByteNullAsync(bytePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null as byte array (should throw)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bytePath'>
            /// null as byte array (should throw)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ByteNullAsync( this IPaths operations, byte[] bytePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ByteNullWithHttpMessagesAsync(bytePath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '2012-01-01' as date
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datePath'>
            /// '2012-01-01' as date
            /// </param>
            public static void DateValid(this IPaths operations, DateTime? datePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).DateValidAsync(datePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '2012-01-01' as date
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datePath'>
            /// '2012-01-01' as date
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DateValidAsync( this IPaths operations, DateTime? datePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DateValidWithHttpMessagesAsync(datePath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get null as date - this should throw or be unusable on the client side,
            /// depending on date representation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datePath'>
            /// null as date (should throw)
            /// </param>
            public static void DateNull(this IPaths operations, DateTime? datePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).DateNullAsync(datePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null as date - this should throw or be unusable on the client side,
            /// depending on date representation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datePath'>
            /// null as date (should throw)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DateNullAsync( this IPaths operations, DateTime? datePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DateNullWithHttpMessagesAsync(datePath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '2012-01-01T01:01:01Z' as date-time
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dateTimePath'>
            /// '2012-01-01T01:01:01Z' as date-time
            /// </param>
            public static void DateTimeValid(this IPaths operations, DateTime? dateTimePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).DateTimeValidAsync(dateTimePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '2012-01-01T01:01:01Z' as date-time
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dateTimePath'>
            /// '2012-01-01T01:01:01Z' as date-time
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DateTimeValidAsync( this IPaths operations, DateTime? dateTimePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DateTimeValidWithHttpMessagesAsync(dateTimePath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get null as date-time, should be disallowed or throw depending on
            /// representation of date-time
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dateTimePath'>
            /// null as date-time
            /// </param>
            public static void DateTimeNull(this IPaths operations, DateTime? dateTimePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).DateTimeNullAsync(dateTimePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null as date-time, should be disallowed or throw depending on
            /// representation of date-time
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dateTimePath'>
            /// null as date-time
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DateTimeNullAsync( this IPaths operations, DateTime? dateTimePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DateTimeNullWithHttpMessagesAsync(dateTimePath, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
