/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 * 
 * Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.url;

import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceException;
import com.microsoft.rest.ServiceResponseCallback;
import retrofit.client.Response;
import retrofit.http.GET;
import retrofit.http.Path;
import retrofit.http.Query;

/**
 * An instance of this class provides access to all the operations defined
 * in PathItems.
 */
public interface PathItems {
    /**
     * The interface defining all the services for PathItems to be
     * used by Retrofit to perform actually REST calls.
     */
    interface PathItemsService {
        @GET("/pathitem/nullable/globalStringPath/{globalStringPath}/pathItemStringPath/{pathItemStringPath}/localStringPath/{localStringPath}/globalStringQuery/pathItemStringQuery/localStringQuery")
        Response getAllWithValues(@Path("localStringPath") String localStringPath, @Path("pathItemStringPath") String pathItemStringPath, @Query("localStringQuery") String localStringQuery, @Query("pathItemStringQuery") String pathItemStringQuery) throws ServiceException;

        @GET("/pathitem/nullable/globalStringPath/{globalStringPath}/pathItemStringPath/{pathItemStringPath}/localStringPath/{localStringPath}/globalStringQuery/pathItemStringQuery/localStringQuery")
        void getAllWithValuesAsync(@Path("localStringPath") String localStringPath, @Path("pathItemStringPath") String pathItemStringPath, @Query("localStringQuery") String localStringQuery, @Query("pathItemStringQuery") String pathItemStringQuery, ServiceResponseCallback cb);

        @GET("/pathitem/nullable/globalStringPath/{globalStringPath}/pathItemStringPath/{pathItemStringPath}/localStringPath/{localStringPath}/null/pathItemStringQuery/localStringQuery")
        Response getGlobalQueryNull(@Path("localStringPath") String localStringPath, @Path("pathItemStringPath") String pathItemStringPath, @Query("localStringQuery") String localStringQuery, @Query("pathItemStringQuery") String pathItemStringQuery) throws ServiceException;

        @GET("/pathitem/nullable/globalStringPath/{globalStringPath}/pathItemStringPath/{pathItemStringPath}/localStringPath/{localStringPath}/null/pathItemStringQuery/localStringQuery")
        void getGlobalQueryNullAsync(@Path("localStringPath") String localStringPath, @Path("pathItemStringPath") String pathItemStringPath, @Query("localStringQuery") String localStringQuery, @Query("pathItemStringQuery") String pathItemStringQuery, ServiceResponseCallback cb);

        @GET("/pathitem/nullable/globalStringPath/{globalStringPath}/pathItemStringPath/{pathItemStringPath}/localStringPath/{localStringPath}/null/pathItemStringQuery/null")
        Response getGlobalAndLocalQueryNull(@Path("localStringPath") String localStringPath, @Path("pathItemStringPath") String pathItemStringPath, @Query("localStringQuery") String localStringQuery, @Query("pathItemStringQuery") String pathItemStringQuery) throws ServiceException;

        @GET("/pathitem/nullable/globalStringPath/{globalStringPath}/pathItemStringPath/{pathItemStringPath}/localStringPath/{localStringPath}/null/pathItemStringQuery/null")
        void getGlobalAndLocalQueryNullAsync(@Path("localStringPath") String localStringPath, @Path("pathItemStringPath") String pathItemStringPath, @Query("localStringQuery") String localStringQuery, @Query("pathItemStringQuery") String pathItemStringQuery, ServiceResponseCallback cb);

        @GET("/pathitem/nullable/globalStringPath/{globalStringPath}/pathItemStringPath/{pathItemStringPath}/localStringPath/{localStringPath}/globalStringQuery/null/null")
        Response getLocalPathItemQueryNull(@Path("localStringPath") String localStringPath, @Path("pathItemStringPath") String pathItemStringPath, @Query("localStringQuery") String localStringQuery, @Query("pathItemStringQuery") String pathItemStringQuery) throws ServiceException;

        @GET("/pathitem/nullable/globalStringPath/{globalStringPath}/pathItemStringPath/{pathItemStringPath}/localStringPath/{localStringPath}/globalStringQuery/null/null")
        void getLocalPathItemQueryNullAsync(@Path("localStringPath") String localStringPath, @Path("pathItemStringPath") String pathItemStringPath, @Query("localStringQuery") String localStringQuery, @Query("pathItemStringQuery") String pathItemStringQuery, ServiceResponseCallback cb);

    }
    /**
     * send globalStringPath='globalStringPath',
     * pathItemStringPath='pathItemStringPath',
     * localStringPath='localStringPath',
     * globalStringQuery='globalStringQuery',
     * pathItemStringQuery='pathItemStringQuery',
     * localStringQuery='localStringQuery'
     *
     * @param localStringPath should contain value 'localStringPath'
     * @param pathItemStringPath A string value 'pathItemStringPath' that appears in the path
     * @param localStringQuery should contain value 'localStringQuery'
     * @param pathItemStringQuery A string value 'pathItemStringQuery' that appears as a query parameter
     * @throws ServiceException the exception wrapped in ServiceException if failed.
     */
    void getAllWithValues(String localStringPath, String pathItemStringPath, String localStringQuery, String pathItemStringQuery) throws ServiceException;

    /**
     * send globalStringPath='globalStringPath',
     * pathItemStringPath='pathItemStringPath',
     * localStringPath='localStringPath',
     * globalStringQuery='globalStringQuery',
     * pathItemStringQuery='pathItemStringQuery',
     * localStringQuery='localStringQuery'
     *
     * @param localStringPath should contain value 'localStringPath'
     * @param pathItemStringPath A string value 'pathItemStringPath' that appears in the path
     * @param localStringQuery should contain value 'localStringQuery'
     * @param pathItemStringQuery A string value 'pathItemStringQuery' that appears as a query parameter
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     */
    void getAllWithValuesAsync(String localStringPath, String pathItemStringPath, String localStringQuery, String pathItemStringQuery, final ServiceCallback<Void> serviceCallback);

    /**
     * send globalStringPath='globalStringPath',
     * pathItemStringPath='pathItemStringPath',
     * localStringPath='localStringPath', globalStringQuery=null,
     * pathItemStringQuery='pathItemStringQuery',
     * localStringQuery='localStringQuery'
     *
     * @param localStringPath should contain value 'localStringPath'
     * @param pathItemStringPath A string value 'pathItemStringPath' that appears in the path
     * @param localStringQuery should contain value 'localStringQuery'
     * @param pathItemStringQuery A string value 'pathItemStringQuery' that appears as a query parameter
     * @throws ServiceException the exception wrapped in ServiceException if failed.
     */
    void getGlobalQueryNull(String localStringPath, String pathItemStringPath, String localStringQuery, String pathItemStringQuery) throws ServiceException;

    /**
     * send globalStringPath='globalStringPath',
     * pathItemStringPath='pathItemStringPath',
     * localStringPath='localStringPath', globalStringQuery=null,
     * pathItemStringQuery='pathItemStringQuery',
     * localStringQuery='localStringQuery'
     *
     * @param localStringPath should contain value 'localStringPath'
     * @param pathItemStringPath A string value 'pathItemStringPath' that appears in the path
     * @param localStringQuery should contain value 'localStringQuery'
     * @param pathItemStringQuery A string value 'pathItemStringQuery' that appears as a query parameter
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     */
    void getGlobalQueryNullAsync(String localStringPath, String pathItemStringPath, String localStringQuery, String pathItemStringQuery, final ServiceCallback<Void> serviceCallback);

    /**
     * send globalStringPath=globalStringPath,
     * pathItemStringPath='pathItemStringPath',
     * localStringPath='localStringPath', globalStringQuery=null,
     * pathItemStringQuery='pathItemStringQuery', localStringQuery=null
     *
     * @param localStringPath should contain value 'localStringPath'
     * @param pathItemStringPath A string value 'pathItemStringPath' that appears in the path
     * @param localStringQuery should contain null value
     * @param pathItemStringQuery A string value 'pathItemStringQuery' that appears as a query parameter
     * @throws ServiceException the exception wrapped in ServiceException if failed.
     */
    void getGlobalAndLocalQueryNull(String localStringPath, String pathItemStringPath, String localStringQuery, String pathItemStringQuery) throws ServiceException;

    /**
     * send globalStringPath=globalStringPath,
     * pathItemStringPath='pathItemStringPath',
     * localStringPath='localStringPath', globalStringQuery=null,
     * pathItemStringQuery='pathItemStringQuery', localStringQuery=null
     *
     * @param localStringPath should contain value 'localStringPath'
     * @param pathItemStringPath A string value 'pathItemStringPath' that appears in the path
     * @param localStringQuery should contain null value
     * @param pathItemStringQuery A string value 'pathItemStringQuery' that appears as a query parameter
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     */
    void getGlobalAndLocalQueryNullAsync(String localStringPath, String pathItemStringPath, String localStringQuery, String pathItemStringQuery, final ServiceCallback<Void> serviceCallback);

    /**
     * send globalStringPath='globalStringPath',
     * pathItemStringPath='pathItemStringPath',
     * localStringPath='localStringPath',
     * globalStringQuery='globalStringQuery', pathItemStringQuery=null,
     * localStringQuery=null
     *
     * @param localStringPath should contain value 'localStringPath'
     * @param pathItemStringPath A string value 'pathItemStringPath' that appears in the path
     * @param localStringQuery should contain value null
     * @param pathItemStringQuery should contain value null
     * @throws ServiceException the exception wrapped in ServiceException if failed.
     */
    void getLocalPathItemQueryNull(String localStringPath, String pathItemStringPath, String localStringQuery, String pathItemStringQuery) throws ServiceException;

    /**
     * send globalStringPath='globalStringPath',
     * pathItemStringPath='pathItemStringPath',
     * localStringPath='localStringPath',
     * globalStringQuery='globalStringQuery', pathItemStringQuery=null,
     * localStringQuery=null
     *
     * @param localStringPath should contain value 'localStringPath'
     * @param pathItemStringPath A string value 'pathItemStringPath' that appears in the path
     * @param localStringQuery should contain value null
     * @param pathItemStringQuery should contain value null
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     */
    void getLocalPathItemQueryNullAsync(String localStringPath, String pathItemStringPath, String localStringQuery, String pathItemStringQuery, final ServiceCallback<Void> serviceCallback);

}
