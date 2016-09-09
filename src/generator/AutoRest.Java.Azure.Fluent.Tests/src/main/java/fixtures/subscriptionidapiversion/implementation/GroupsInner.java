/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.subscriptionidapiversion.implementation;

import retrofit2.Retrofit;
import com.google.common.reflect.TypeToken;
import com.microsoft.azure.AzureServiceResponseBuilder;
import com.microsoft.rest.ServiceCall;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceResponse;
import fixtures.subscriptionidapiversion.ErrorException;
import java.io.IOException;
import okhttp3.ResponseBody;
import retrofit2.http.GET;
import retrofit2.http.Header;
import retrofit2.http.Headers;
import retrofit2.http.Path;
import retrofit2.http.Query;
import retrofit2.Response;
import rx.functions.Func1;
import rx.Observable;

/**
 * An instance of this class provides access to all the operations defined
 * in Groups.
 */
public final class GroupsInner {
    /** The Retrofit service to perform REST calls. */
    private GroupsService service;
    /** The service client containing this operation class. */
    private MicrosoftAzureTestUrlImpl client;

    /**
     * Initializes an instance of GroupsInner.
     *
     * @param retrofit the Retrofit instance built from a Retrofit Builder.
     * @param client the instance of the service client containing this operation class.
     */
    public GroupsInner(Retrofit retrofit, MicrosoftAzureTestUrlImpl client) {
        this.service = retrofit.create(GroupsService.class);
        this.client = client;
    }

    /**
     * The interface defining all the services for Groups to be
     * used by Retrofit to perform actually REST calls.
     */
    interface GroupsService {
        @Headers("Content-Type: application/json; charset=utf-8")
        @GET("subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}")
        Observable<Response<ResponseBody>> getSampleResourceGroup(@Path("subscriptionId") String subscriptionId, @Path("resourceGroupName") String resourceGroupName, @Query("api-version") String apiVersion, @Header("accept-language") String acceptLanguage, @Header("User-Agent") String userAgent);

    }

    /**
     * Provides a resouce group with name 'testgroup101' and location 'West US'.
     *
     * @param resourceGroupName Resource Group name 'testgroup101'.
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @throws IllegalArgumentException exception thrown from invalid parameters
     * @return the SampleResourceGroupInner object if successful.
     */
    public SampleResourceGroupInner getSampleResourceGroup(String resourceGroupName) throws ErrorException, IOException, IllegalArgumentException {
        return getSampleResourceGroupWithServiceResponseAsync(resourceGroupName).toBlocking().single().getBody();
    }

    /**
     * Provides a resouce group with name 'testgroup101' and location 'West US'.
     *
     * @param resourceGroupName Resource Group name 'testgroup101'.
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<SampleResourceGroupInner> getSampleResourceGroupAsync(String resourceGroupName, final ServiceCallback<SampleResourceGroupInner> serviceCallback) {
        return ServiceCall.create(getSampleResourceGroupWithServiceResponseAsync(resourceGroupName), serviceCallback);
    }

    /**
     * Provides a resouce group with name 'testgroup101' and location 'West US'.
     *
     * @param resourceGroupName Resource Group name 'testgroup101'.
     * @return the observable to the SampleResourceGroupInner object
     */
    public Observable<SampleResourceGroupInner> getSampleResourceGroupAsync(String resourceGroupName) {
        return getSampleResourceGroupWithServiceResponseAsync(resourceGroupName).map(new Func1<ServiceResponse<SampleResourceGroupInner>, SampleResourceGroupInner>() {
            @Override
            public SampleResourceGroupInner call(ServiceResponse<SampleResourceGroupInner> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Provides a resouce group with name 'testgroup101' and location 'West US'.
     *
     * @param resourceGroupName Resource Group name 'testgroup101'.
     * @return the observable to the SampleResourceGroupInner object
     */
    public Observable<ServiceResponse<SampleResourceGroupInner>> getSampleResourceGroupWithServiceResponseAsync(String resourceGroupName) {
        if (this.client.subscriptionId() == null) {
            throw new IllegalArgumentException("Parameter this.client.subscriptionId() is required and cannot be null.");
        }
        if (resourceGroupName == null) {
            throw new IllegalArgumentException("Parameter resourceGroupName is required and cannot be null.");
        }
        if (this.client.apiVersion() == null) {
            throw new IllegalArgumentException("Parameter this.client.apiVersion() is required and cannot be null.");
        }
        return service.getSampleResourceGroup(this.client.subscriptionId(), resourceGroupName, this.client.apiVersion(), this.client.acceptLanguage(), this.client.userAgent())
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<SampleResourceGroupInner>>>() {
                @Override
                public Observable<ServiceResponse<SampleResourceGroupInner>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<SampleResourceGroupInner> clientResponse = getSampleResourceGroupDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<SampleResourceGroupInner> getSampleResourceGroupDelegate(Response<ResponseBody> response) throws ErrorException, IOException, IllegalArgumentException {
        return new AzureServiceResponseBuilder<SampleResourceGroupInner, ErrorException>(this.client.mapperAdapter())
                .register(200, new TypeToken<SampleResourceGroupInner>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

}
