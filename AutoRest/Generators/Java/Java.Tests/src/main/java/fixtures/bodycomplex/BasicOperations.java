/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 * 
 * Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.bodycomplex;

import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceException;
import com.microsoft.rest.ServiceResponseCallback;
import retrofit.client.Response;
import fixtures.bodycomplex.models.Basic;
import retrofit.http.GET;
import retrofit.http.PUT;
import retrofit.http.Body;

/**
 * An instance of this class provides access to all the operations defined
 * in BasicOperations.
 */
public interface BasicOperations {
    /**
     * The interface defining all the services for BasicOperations to be
     * used by Retrofit to perform actually REST calls.
     */
    interface BasicService {
        @GET("/complex/basic/valid")
        Response getValid() throws ServiceException;

        @GET("/complex/basic/valid")
        void getValidAsync(ServiceResponseCallback cb);

        @PUT("/complex/basic/valid")
        Response putValid(@Body Basic complexBody) throws ServiceException;

        @PUT("/complex/basic/valid")
        void putValidAsync(@Body Basic complexBody, ServiceResponseCallback cb);

        @GET("/complex/basic/invalid")
        Response getInvalid() throws ServiceException;

        @GET("/complex/basic/invalid")
        void getInvalidAsync(ServiceResponseCallback cb);

        @GET("/complex/basic/empty")
        Response getEmpty() throws ServiceException;

        @GET("/complex/basic/empty")
        void getEmptyAsync(ServiceResponseCallback cb);

        @GET("/complex/basic/null")
        Response getNull() throws ServiceException;

        @GET("/complex/basic/null")
        void getNullAsync(ServiceResponseCallback cb);

        @GET("/complex/basic/notprovided")
        Response getNotProvided() throws ServiceException;

        @GET("/complex/basic/notprovided")
        void getNotProvidedAsync(ServiceResponseCallback cb);

    }
    /**
     * Get complex type {id: 2, name: 'abc', color: 'YELLOW'}
     *
     * @return the Basic object if successful.
     * @throws ServiceException the exception wrapped in ServiceException if failed.
     */
    Basic getValid() throws ServiceException;

    /**
     * Get complex type {id: 2, name: 'abc', color: 'YELLOW'}
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     */
    void getValidAsync(final ServiceCallback<Basic> serviceCallback);

    /**
     * Please put {id: 2, name: 'abc', color: 'Magenta'}
     *
     * @param complexBody Please put {id: 2, name: 'abc', color: 'Magenta'}
     * @throws ServiceException the exception wrapped in ServiceException if failed.
     */
    void putValid(Basic complexBody) throws ServiceException;

    /**
     * Please put {id: 2, name: 'abc', color: 'Magenta'}
     *
     * @param complexBody Please put {id: 2, name: 'abc', color: 'Magenta'}
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     */
    void putValidAsync(Basic complexBody, final ServiceCallback<Void> serviceCallback);

    /**
     * Get a basic complex type that is invalid for the local strong type
     *
     * @return the Basic object if successful.
     * @throws ServiceException the exception wrapped in ServiceException if failed.
     */
    Basic getInvalid() throws ServiceException;

    /**
     * Get a basic complex type that is invalid for the local strong type
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     */
    void getInvalidAsync(final ServiceCallback<Basic> serviceCallback);

    /**
     * Get a basic complex type that is empty
     *
     * @return the Basic object if successful.
     * @throws ServiceException the exception wrapped in ServiceException if failed.
     */
    Basic getEmpty() throws ServiceException;

    /**
     * Get a basic complex type that is empty
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     */
    void getEmptyAsync(final ServiceCallback<Basic> serviceCallback);

    /**
     * Get a basic complex type whose properties are null
     *
     * @return the Basic object if successful.
     * @throws ServiceException the exception wrapped in ServiceException if failed.
     */
    Basic getNull() throws ServiceException;

    /**
     * Get a basic complex type whose properties are null
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     */
    void getNullAsync(final ServiceCallback<Basic> serviceCallback);

    /**
     * Get a basic complex type while the server doesn't provide a response
     * payload
     *
     * @return the Basic object if successful.
     * @throws ServiceException the exception wrapped in ServiceException if failed.
     */
    Basic getNotProvided() throws ServiceException;

    /**
     * Get a basic complex type while the server doesn't provide a response
     * payload
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     */
    void getNotProvidedAsync(final ServiceCallback<Basic> serviceCallback);

}
