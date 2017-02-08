/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
*/

import { ServiceClientOptions, RequestOptions, ServiceCallback } from 'ms-rest';
import * as models from '../models';


/**
 * @class
 * PagingOperations
 * __NOTE__: An instance of this class is automatically created for an
 * instance of the AutoRestPagingTestService.
 */
export interface PagingOperations {

    /**
     * A paging operation that finishes on the first call without a nextlink
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getSinglePages(options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getSinglePages(callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that includes a nextLink that has 10 pages
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {string} [options.clientRequestId]
     *
     * @param {object} [options.pagingGetMultiplePagesOptions] Additional
     * parameters for the operation
     *
     * @param {number} [options.pagingGetMultiplePagesOptions.maxresults] Sets the
     * maximum number of items to return in the response.
     *
     * @param {number} [options.pagingGetMultiplePagesOptions.timeout] Sets the
     * maximum time that the server can spend processing the request, in seconds.
     * The default is 30 seconds.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePages(options: { clientRequestId? : string, pagingGetMultiplePagesOptions? : models.PagingGetMultiplePagesOptions, customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getMultiplePages(callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that includes a nextLink in odata format that has 10
     * pages
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {string} [options.clientRequestId]
     *
     * @param {object} [options.pagingGetOdataMultiplePagesOptions] Additional
     * parameters for the operation
     *
     * @param {number} [options.pagingGetOdataMultiplePagesOptions.maxresults] Sets
     * the maximum number of items to return in the response.
     *
     * @param {number} [options.pagingGetOdataMultiplePagesOptions.timeout] Sets
     * the maximum time that the server can spend processing the request, in
     * seconds. The default is 30 seconds.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getOdataMultiplePages(options: { clientRequestId? : string, pagingGetOdataMultiplePagesOptions? : models.PagingGetOdataMultiplePagesOptions, customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.OdataProductResult>): void;
    getOdataMultiplePages(callback: ServiceCallback<models.OdataProductResult>): void;

    /**
     * A paging operation that includes a nextLink that has 10 pages
     *
     * @param {object} pagingGetMultiplePagesWithOffsetOptions Additional
     * parameters for the operation
     *
     * @param {number} [pagingGetMultiplePagesWithOffsetOptions.maxresults] Sets
     * the maximum number of items to return in the response.
     *
     * @param {number} pagingGetMultiplePagesWithOffsetOptions.offset Offset of
     * return value
     *
     * @param {number} [pagingGetMultiplePagesWithOffsetOptions.timeout] Sets the
     * maximum time that the server can spend processing the request, in seconds.
     * The default is 30 seconds.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {string} [options.clientRequestId]
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesWithOffset(pagingGetMultiplePagesWithOffsetOptions: models.PagingGetMultiplePagesWithOffsetOptions, options: { clientRequestId? : string, customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getMultiplePagesWithOffset(pagingGetMultiplePagesWithOffsetOptions: models.PagingGetMultiplePagesWithOffsetOptions, callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that fails on the first call with 500 and then retries
     * and then get a response including a nextLink that has 10 pages
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesRetryFirst(options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getMultiplePagesRetryFirst(callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that includes a nextLink that has 10 pages, of which the
     * 2nd call fails first with 500. The client should retry and finish all 10
     * pages eventually.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesRetrySecond(options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getMultiplePagesRetrySecond(callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that receives a 400 on the first call
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getSinglePagesFailure(options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getSinglePagesFailure(callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that receives a 400 on the second call
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesFailure(options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getMultiplePagesFailure(callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that receives an invalid nextLink
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesFailureUri(options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getMultiplePagesFailureUri(callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that doesn't return a full URL, just a fragment
     *
     * @param {string} apiVersion Sets the api version to use.
     *
     * @param {string} tenant Sets the tenant to use.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesFragmentNextLink(apiVersion: string, tenant: string, options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.OdataProductResult>): void;
    getMultiplePagesFragmentNextLink(apiVersion: string, tenant: string, callback: ServiceCallback<models.OdataProductResult>): void;

    /**
     * A paging operation that doesn't return a full URL, just a fragment with
     * parameters grouped
     *
     * @param {object} customParameterGroup Additional parameters for the operation
     *
     * @param {string} customParameterGroup.apiVersion Sets the api version to use.
     *
     * @param {string} customParameterGroup.tenant Sets the tenant to use.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesFragmentWithGroupingNextLink(customParameterGroup: models.CustomParameterGroup, options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.OdataProductResult>): void;
    getMultiplePagesFragmentWithGroupingNextLink(customParameterGroup: models.CustomParameterGroup, callback: ServiceCallback<models.OdataProductResult>): void;

    /**
     * A paging operation that doesn't return a full URL, just a fragment
     *
     * @param {string} apiVersion Sets the api version to use.
     *
     * @param {string} tenant Sets the tenant to use.
     *
     * @param {string} nextLink Next link for list operation.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    nextFragment(apiVersion: string, tenant: string, nextLink: string, options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.OdataProductResult>): void;
    nextFragment(apiVersion: string, tenant: string, nextLink: string, callback: ServiceCallback<models.OdataProductResult>): void;

    /**
     * A paging operation that doesn't return a full URL, just a fragment
     *
     * @param {string} nextLink Next link for list operation.
     *
     * @param {object} customParameterGroup Additional parameters for the operation
     *
     * @param {string} customParameterGroup.apiVersion Sets the api version to use.
     *
     * @param {string} customParameterGroup.tenant Sets the tenant to use.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    nextFragmentWithGrouping(nextLink: string, customParameterGroup: models.CustomParameterGroup, options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.OdataProductResult>): void;
    nextFragmentWithGrouping(nextLink: string, customParameterGroup: models.CustomParameterGroup, callback: ServiceCallback<models.OdataProductResult>): void;

    /**
     * A paging operation that finishes on the first call without a nextlink
     *
     * @param {string} nextPageLink The NextLink from the previous successful call
     * to List operation.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getSinglePagesNext(nextPageLink: string, options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getSinglePagesNext(nextPageLink: string, callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that includes a nextLink that has 10 pages
     *
     * @param {string} nextPageLink The NextLink from the previous successful call
     * to List operation.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {string} [options.clientRequestId]
     *
     * @param {object} [options.pagingGetMultiplePagesOptions] Additional
     * parameters for the operation
     *
     * @param {number} [options.pagingGetMultiplePagesOptions.maxresults] Sets the
     * maximum number of items to return in the response.
     *
     * @param {number} [options.pagingGetMultiplePagesOptions.timeout] Sets the
     * maximum time that the server can spend processing the request, in seconds.
     * The default is 30 seconds.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesNext(nextPageLink: string, options: { clientRequestId? : string, pagingGetMultiplePagesOptions? : models.PagingGetMultiplePagesOptions, customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getMultiplePagesNext(nextPageLink: string, callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that includes a nextLink in odata format that has 10
     * pages
     *
     * @param {string} nextPageLink The NextLink from the previous successful call
     * to List operation.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {string} [options.clientRequestId]
     *
     * @param {object} [options.pagingGetOdataMultiplePagesOptions] Additional
     * parameters for the operation
     *
     * @param {number} [options.pagingGetOdataMultiplePagesOptions.maxresults] Sets
     * the maximum number of items to return in the response.
     *
     * @param {number} [options.pagingGetOdataMultiplePagesOptions.timeout] Sets
     * the maximum time that the server can spend processing the request, in
     * seconds. The default is 30 seconds.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getOdataMultiplePagesNext(nextPageLink: string, options: { clientRequestId? : string, pagingGetOdataMultiplePagesOptions? : models.PagingGetOdataMultiplePagesOptions, customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.OdataProductResult>): void;
    getOdataMultiplePagesNext(nextPageLink: string, callback: ServiceCallback<models.OdataProductResult>): void;

    /**
     * A paging operation that includes a nextLink that has 10 pages
     *
     * @param {string} nextPageLink The NextLink from the previous successful call
     * to List operation.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {string} [options.clientRequestId]
     *
     * @param {object} [options.pagingGetMultiplePagesWithOffsetNextOptions]
     * Additional parameters for the operation
     *
     * @param {number}
     * [options.pagingGetMultiplePagesWithOffsetNextOptions.maxresults] Sets the
     * maximum number of items to return in the response.
     *
     * @param {number}
     * [options.pagingGetMultiplePagesWithOffsetNextOptions.timeout] Sets the
     * maximum time that the server can spend processing the request, in seconds.
     * The default is 30 seconds.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesWithOffsetNext(nextPageLink: string, options: { clientRequestId? : string, pagingGetMultiplePagesWithOffsetNextOptions? : models.PagingGetMultiplePagesWithOffsetNextOptions, customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getMultiplePagesWithOffsetNext(nextPageLink: string, callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that fails on the first call with 500 and then retries
     * and then get a response including a nextLink that has 10 pages
     *
     * @param {string} nextPageLink The NextLink from the previous successful call
     * to List operation.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesRetryFirstNext(nextPageLink: string, options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getMultiplePagesRetryFirstNext(nextPageLink: string, callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that includes a nextLink that has 10 pages, of which the
     * 2nd call fails first with 500. The client should retry and finish all 10
     * pages eventually.
     *
     * @param {string} nextPageLink The NextLink from the previous successful call
     * to List operation.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesRetrySecondNext(nextPageLink: string, options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getMultiplePagesRetrySecondNext(nextPageLink: string, callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that receives a 400 on the first call
     *
     * @param {string} nextPageLink The NextLink from the previous successful call
     * to List operation.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getSinglePagesFailureNext(nextPageLink: string, options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getSinglePagesFailureNext(nextPageLink: string, callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that receives a 400 on the second call
     *
     * @param {string} nextPageLink The NextLink from the previous successful call
     * to List operation.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesFailureNext(nextPageLink: string, options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getMultiplePagesFailureNext(nextPageLink: string, callback: ServiceCallback<models.ProductResult>): void;

    /**
     * A paging operation that receives an invalid nextLink
     *
     * @param {string} nextPageLink The NextLink from the previous successful call
     * to List operation.
     *
     * @param {object} [options] Optional Parameters.
     *
     * @param {object} [options.customHeaders] Headers that will be added to the
     * request
     *
     * @param {ServiceCallback} [callback] callback function; see ServiceCallback
     * doc in ms-rest index.d.ts for details
     */
    getMultiplePagesFailureUriNext(nextPageLink: string, options: { customHeaders? : { [headerName: string]: string; } }, callback: ServiceCallback<models.ProductResult>): void;
    getMultiplePagesFailureUriNext(nextPageLink: string, callback: ServiceCallback<models.ProductResult>): void;
}
