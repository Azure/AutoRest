/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.http.implementation;

import retrofit2.Retrofit;
import fixtures.http.HttpFailures;
import com.google.common.reflect.TypeToken;
import com.microsoft.rest.ServiceCall;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceException;
import com.microsoft.rest.ServiceResponse;
import com.microsoft.rest.ServiceResponseBuilder;
import fixtures.http.models.ErrorException;
import java.io.IOException;
import okhttp3.ResponseBody;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.Response;
import rx.functions.Func1;
import rx.Observable;

/**
 * An instance of this class provides access to all the operations defined
 * in HttpFailures.
 */
public final class HttpFailuresImpl implements HttpFailures {
    /** The Retrofit service to perform REST calls. */
    private HttpFailuresService service;
    /** The service client containing this operation class. */
    private AutoRestHttpInfrastructureTestServiceImpl client;

    /**
     * Initializes an instance of HttpFailures.
     *
     * @param retrofit the Retrofit instance built from a Retrofit Builder.
     * @param client the instance of the service client containing this operation class.
     */
    public HttpFailuresImpl(Retrofit retrofit, AutoRestHttpInfrastructureTestServiceImpl client) {
        this.service = retrofit.create(HttpFailuresService.class);
        this.client = client;
    }

    /**
     * The interface defining all the services for HttpFailures to be
     * used by Retrofit to perform actually REST calls.
     */
    interface HttpFailuresService {
        @Headers("Content-Type: application/json; charset=utf-8")
        @GET("http/failure/emptybody/error")
        Observable<Response<ResponseBody>> getEmptyError();

        @Headers("Content-Type: application/json; charset=utf-8")
        @GET("http/failure/nomodel/error")
        Observable<Response<ResponseBody>> getNoModelError();

        @Headers("Content-Type: application/json; charset=utf-8")
        @GET("http/failure/nomodel/empty")
        Observable<Response<ResponseBody>> getNoModelEmpty();

    }

    /**
     * Get empty error form server.
     *
     * @return the Boolean object if successful.
     */
    public Boolean getEmptyError() {
        return getEmptyErrorWithServiceResponseAsync().toBlocking().single().getBody();
    }

    /**
     * Get empty error form server.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Boolean> getEmptyErrorAsync(final ServiceCallback<Boolean> serviceCallback) {
        return ServiceCall.create(getEmptyErrorWithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Get empty error form server.
     *
     * @return the observable to the Boolean object
     */
    public Observable<Boolean> getEmptyErrorAsync() {
        return getEmptyErrorWithServiceResponseAsync().map(new Func1<ServiceResponse<Boolean>, Boolean>() {
            @Override
            public Boolean call(ServiceResponse<Boolean> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Get empty error form server.
     *
     * @return the observable to the Boolean object
     */
    public Observable<ServiceResponse<Boolean>> getEmptyErrorWithServiceResponseAsync() {
        return service.getEmptyError()
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Boolean>>>() {
                @Override
                public Observable<ServiceResponse<Boolean>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Boolean> clientResponse = getEmptyErrorDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Boolean> getEmptyErrorDelegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return new ServiceResponseBuilder<Boolean, ErrorException>(this.client.mapperAdapter())
                .register(200, new TypeToken<Boolean>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Get empty error form server.
     *
     * @return the Boolean object if successful.
     */
    public Boolean getNoModelError() {
        return getNoModelErrorWithServiceResponseAsync().toBlocking().single().getBody();
    }

    /**
     * Get empty error form server.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Boolean> getNoModelErrorAsync(final ServiceCallback<Boolean> serviceCallback) {
        return ServiceCall.create(getNoModelErrorWithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Get empty error form server.
     *
     * @return the observable to the Boolean object
     */
    public Observable<Boolean> getNoModelErrorAsync() {
        return getNoModelErrorWithServiceResponseAsync().map(new Func1<ServiceResponse<Boolean>, Boolean>() {
            @Override
            public Boolean call(ServiceResponse<Boolean> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Get empty error form server.
     *
     * @return the observable to the Boolean object
     */
    public Observable<ServiceResponse<Boolean>> getNoModelErrorWithServiceResponseAsync() {
        return service.getNoModelError()
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Boolean>>>() {
                @Override
                public Observable<ServiceResponse<Boolean>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Boolean> clientResponse = getNoModelErrorDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Boolean> getNoModelErrorDelegate(Response<ResponseBody> response) throws ServiceException, IOException {
        return new ServiceResponseBuilder<Boolean, ServiceException>(this.client.mapperAdapter())
                .register(200, new TypeToken<Boolean>() { }.getType())
                .build(response);
    }

    /**
     * Get empty response from server.
     *
     * @return the Boolean object if successful.
     */
    public Boolean getNoModelEmpty() {
        return getNoModelEmptyWithServiceResponseAsync().toBlocking().single().getBody();
    }

    /**
     * Get empty response from server.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Boolean> getNoModelEmptyAsync(final ServiceCallback<Boolean> serviceCallback) {
        return ServiceCall.create(getNoModelEmptyWithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Get empty response from server.
     *
     * @return the observable to the Boolean object
     */
    public Observable<Boolean> getNoModelEmptyAsync() {
        return getNoModelEmptyWithServiceResponseAsync().map(new Func1<ServiceResponse<Boolean>, Boolean>() {
            @Override
            public Boolean call(ServiceResponse<Boolean> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Get empty response from server.
     *
     * @return the observable to the Boolean object
     */
    public Observable<ServiceResponse<Boolean>> getNoModelEmptyWithServiceResponseAsync() {
        return service.getNoModelEmpty()
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Boolean>>>() {
                @Override
                public Observable<ServiceResponse<Boolean>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Boolean> clientResponse = getNoModelEmptyDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Boolean> getNoModelEmptyDelegate(Response<ResponseBody> response) throws ServiceException, IOException {
        return new ServiceResponseBuilder<Boolean, ServiceException>(this.client.mapperAdapter())
                .register(200, new TypeToken<Boolean>() { }.getType())
                .build(response);
    }

}
