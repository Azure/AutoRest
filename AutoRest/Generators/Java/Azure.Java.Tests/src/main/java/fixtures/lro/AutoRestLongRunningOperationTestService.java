/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 * 
 * Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.lro;

import com.microsoft.rest.AzureClient;
import com.microsoft.rest.credentials.ServiceClientCredentials;
import com.squareup.okhttp.Interceptor;
import java.util.List;

/**
 * The interface for AutoRestLongRunningOperationTestService class.
 */
public interface AutoRestLongRunningOperationTestService {
    /**
     * Gets the URI used as the base for all cloud service requests.
     * @return The BaseUri value.
     */
    String getBaseUri();

    /**
     * Gets the list of interceptors the OkHttp client will execute.
     * @return the list of interceptors.
     */
    List<Interceptor> getClientInterceptors();

    /**
     * Gets the {@link AzureClient} used for long running operations.
     * @return the azure client;
     */
    AzureClient getAzureClient();

    /**
     * Gets The management credentials for Azure..
     *
     * @return the credentials value.
     */
    ServiceClientCredentials getCredentials();

    /**
     * Gets Gets or sets the preferred language for the response..
     *
     * @return the acceptLanguage value.
     */
    String getAcceptLanguage();

    /**
     * Sets Gets or sets the preferred language for the response..
     *
     * @param acceptLanguage the acceptLanguage value.
     */
    void setAcceptLanguage(String acceptLanguage);

    /**
     * Gets The retry timeout for Long Running Operations..
     *
     * @return the longRunningOperationRetryTimeout value.
     */
    int getLongRunningOperationRetryTimeout();

    /**
     * Sets The retry timeout for Long Running Operations..
     *
     * @param longRunningOperationRetryTimeout the longRunningOperationRetryTimeout value.
     */
    void setLongRunningOperationRetryTimeout(int longRunningOperationRetryTimeout);

    /**
     * Gets the LROsOperations object to access its operations.
     * @return the lROs value.
     */
    LROsOperations getLROs();

    /**
     * Gets the LRORetrysOperations object to access its operations.
     * @return the lRORetrys value.
     */
    LRORetrysOperations getLRORetrys();

    /**
     * Gets the LROSADsOperations object to access its operations.
     * @return the lROSADs value.
     */
    LROSADsOperations getLROSADs();

    /**
     * Gets the LROsCustomHeaderOperations object to access its operations.
     * @return the lROsCustomHeader value.
     */
    LROsCustomHeaderOperations getLROsCustomHeader();

}
