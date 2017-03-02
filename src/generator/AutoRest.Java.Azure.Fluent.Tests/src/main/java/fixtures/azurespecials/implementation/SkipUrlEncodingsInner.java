/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.azurespecials.implementation;

import retrofit2.Retrofit;
import com.google.common.reflect.TypeToken;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceFuture;
import com.microsoft.rest.ServiceResponse;
import fixtures.azurespecials.ErrorException;
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
 * in SkipUrlEncodings.
 */
public class SkipUrlEncodingsInner {
    /** The Retrofit service to perform REST calls. */
    private SkipUrlEncodingsService service;
    /** The service client containing this operation class. */
    private AutoRestAzureSpecialParametersTestClientImpl client;

    /**
     * Initializes an instance of SkipUrlEncodingsInner.
     *
     * @param retrofit the Retrofit instance built from a Retrofit Builder.
     * @param client the instance of the service client containing this operation class.
     */
    public SkipUrlEncodingsInner(Retrofit retrofit, AutoRestAzureSpecialParametersTestClientImpl client) {
        this.service = retrofit.create(SkipUrlEncodingsService.class);
        this.client = client;
    }

    /**
     * The interface defining all the services for SkipUrlEncodings to be
     * used by Retrofit to perform actually REST calls.
     */
    interface SkipUrlEncodingsService {
        @Headers({ "Content-Type: application/json; charset=utf-8", "x-ms-logging-context: fixtures.azurespecials.SkipUrlEncodings getMethodPathValid" })
        @GET("azurespecials/skipUrlEncoding/method/path/valid/{unencodedPathParam}")
        Observable<Response<ResponseBody>> getMethodPathValid(@Path(value = "unencodedPathParam", encoded = true) String unencodedPathParam, @Header("accept-language") String acceptLanguage, @Header("User-Agent") String userAgent);

        @Headers({ "Content-Type: application/json; charset=utf-8", "x-ms-logging-context: fixtures.azurespecials.SkipUrlEncodings getPathPathValid" })
        @GET("azurespecials/skipUrlEncoding/path/path/valid/{unencodedPathParam}")
        Observable<Response<ResponseBody>> getPathPathValid(@Path(value = "unencodedPathParam", encoded = true) String unencodedPathParam, @Header("accept-language") String acceptLanguage, @Header("User-Agent") String userAgent);

        @Headers({ "Content-Type: application/json; charset=utf-8", "x-ms-logging-context: fixtures.azurespecials.SkipUrlEncodings getSwaggerPathValid" })
        @GET("azurespecials/skipUrlEncoding/swagger/path/valid/{unencodedPathParam}")
        Observable<Response<ResponseBody>> getSwaggerPathValid(@Path(value = "unencodedPathParam", encoded = true) String unencodedPathParam, @Header("accept-language") String acceptLanguage, @Header("User-Agent") String userAgent);

        @Headers({ "Content-Type: application/json; charset=utf-8", "x-ms-logging-context: fixtures.azurespecials.SkipUrlEncodings getMethodQueryValid" })
        @GET("azurespecials/skipUrlEncoding/method/query/valid")
        Observable<Response<ResponseBody>> getMethodQueryValid(@Query(value = "q1", encoded = true) String q1, @Header("accept-language") String acceptLanguage, @Header("User-Agent") String userAgent);

        @Headers({ "Content-Type: application/json; charset=utf-8", "x-ms-logging-context: fixtures.azurespecials.SkipUrlEncodings getMethodQueryNull" })
        @GET("azurespecials/skipUrlEncoding/method/query/null")
        Observable<Response<ResponseBody>> getMethodQueryNull(@Query(value = "q1", encoded = true) String q1, @Header("accept-language") String acceptLanguage, @Header("User-Agent") String userAgent);

        @Headers({ "Content-Type: application/json; charset=utf-8", "x-ms-logging-context: fixtures.azurespecials.SkipUrlEncodings getPathQueryValid" })
        @GET("azurespecials/skipUrlEncoding/path/query/valid")
        Observable<Response<ResponseBody>> getPathQueryValid(@Query(value = "q1", encoded = true) String q1, @Header("accept-language") String acceptLanguage, @Header("User-Agent") String userAgent);

        @Headers({ "Content-Type: application/json; charset=utf-8", "x-ms-logging-context: fixtures.azurespecials.SkipUrlEncodings getSwaggerQueryValid" })
        @GET("azurespecials/skipUrlEncoding/swagger/query/valid")
        Observable<Response<ResponseBody>> getSwaggerQueryValid(@Query(value = "q1", encoded = true) String q1, @Header("accept-language") String acceptLanguage, @Header("User-Agent") String userAgent);

    }

    /**
     * Get method with unencoded path parameter with value 'path1/path2/path3'.
     *
     * @param unencodedPathParam Unencoded path parameter with value 'path1/path2/path3'
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @throws ErrorException thrown if the request is rejected by server
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent
     */
    public void getMethodPathValid(String unencodedPathParam) {
        getMethodPathValidWithServiceResponseAsync(unencodedPathParam).toBlocking().single().body();
    }

    /**
     * Get method with unencoded path parameter with value 'path1/path2/path3'.
     *
     * @param unencodedPathParam Unencoded path parameter with value 'path1/path2/path3'
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceFuture} object
     */
    public ServiceFuture<Void> getMethodPathValidAsync(String unencodedPathParam, final ServiceCallback<Void> serviceCallback) {
        return ServiceFuture.fromResponse(getMethodPathValidWithServiceResponseAsync(unencodedPathParam), serviceCallback);
    }

    /**
     * Get method with unencoded path parameter with value 'path1/path2/path3'.
     *
     * @param unencodedPathParam Unencoded path parameter with value 'path1/path2/path3'
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> getMethodPathValidAsync(String unencodedPathParam) {
        return getMethodPathValidWithServiceResponseAsync(unencodedPathParam).map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.body();
            }
        });
    }

    /**
     * Get method with unencoded path parameter with value 'path1/path2/path3'.
     *
     * @param unencodedPathParam Unencoded path parameter with value 'path1/path2/path3'
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> getMethodPathValidWithServiceResponseAsync(String unencodedPathParam) {
        if (unencodedPathParam == null) {
            throw new IllegalArgumentException("Parameter unencodedPathParam is required and cannot be null.");
        }
        return service.getMethodPathValid(unencodedPathParam, this.client.acceptLanguage(), this.client.userAgent())
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = getMethodPathValidDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> getMethodPathValidDelegate(Response<ResponseBody> response) throws ErrorException, IOException, IllegalArgumentException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Get method with unencoded path parameter with value 'path1/path2/path3'.
     *
     * @param unencodedPathParam Unencoded path parameter with value 'path1/path2/path3'
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @throws ErrorException thrown if the request is rejected by server
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent
     */
    public void getPathPathValid(String unencodedPathParam) {
        getPathPathValidWithServiceResponseAsync(unencodedPathParam).toBlocking().single().body();
    }

    /**
     * Get method with unencoded path parameter with value 'path1/path2/path3'.
     *
     * @param unencodedPathParam Unencoded path parameter with value 'path1/path2/path3'
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceFuture} object
     */
    public ServiceFuture<Void> getPathPathValidAsync(String unencodedPathParam, final ServiceCallback<Void> serviceCallback) {
        return ServiceFuture.fromResponse(getPathPathValidWithServiceResponseAsync(unencodedPathParam), serviceCallback);
    }

    /**
     * Get method with unencoded path parameter with value 'path1/path2/path3'.
     *
     * @param unencodedPathParam Unencoded path parameter with value 'path1/path2/path3'
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> getPathPathValidAsync(String unencodedPathParam) {
        return getPathPathValidWithServiceResponseAsync(unencodedPathParam).map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.body();
            }
        });
    }

    /**
     * Get method with unencoded path parameter with value 'path1/path2/path3'.
     *
     * @param unencodedPathParam Unencoded path parameter with value 'path1/path2/path3'
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> getPathPathValidWithServiceResponseAsync(String unencodedPathParam) {
        if (unencodedPathParam == null) {
            throw new IllegalArgumentException("Parameter unencodedPathParam is required and cannot be null.");
        }
        return service.getPathPathValid(unencodedPathParam, this.client.acceptLanguage(), this.client.userAgent())
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = getPathPathValidDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> getPathPathValidDelegate(Response<ResponseBody> response) throws ErrorException, IOException, IllegalArgumentException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Get method with unencoded path parameter with value 'path1/path2/path3'.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @throws ErrorException thrown if the request is rejected by server
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent
     */
    public void getSwaggerPathValid() {
        getSwaggerPathValidWithServiceResponseAsync().toBlocking().single().body();
    }

    /**
     * Get method with unencoded path parameter with value 'path1/path2/path3'.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceFuture} object
     */
    public ServiceFuture<Void> getSwaggerPathValidAsync(final ServiceCallback<Void> serviceCallback) {
        return ServiceFuture.fromResponse(getSwaggerPathValidWithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Get method with unencoded path parameter with value 'path1/path2/path3'.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> getSwaggerPathValidAsync() {
        return getSwaggerPathValidWithServiceResponseAsync().map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.body();
            }
        });
    }

    /**
     * Get method with unencoded path parameter with value 'path1/path2/path3'.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> getSwaggerPathValidWithServiceResponseAsync() {
        final String unencodedPathParam = "path1/path2/path3";
        return service.getSwaggerPathValid(unencodedPathParam, this.client.acceptLanguage(), this.client.userAgent())
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = getSwaggerPathValidDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> getSwaggerPathValidDelegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Get method with unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'.
     *
     * @param q1 Unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @throws ErrorException thrown if the request is rejected by server
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent
     */
    public void getMethodQueryValid(String q1) {
        getMethodQueryValidWithServiceResponseAsync(q1).toBlocking().single().body();
    }

    /**
     * Get method with unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'.
     *
     * @param q1 Unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceFuture} object
     */
    public ServiceFuture<Void> getMethodQueryValidAsync(String q1, final ServiceCallback<Void> serviceCallback) {
        return ServiceFuture.fromResponse(getMethodQueryValidWithServiceResponseAsync(q1), serviceCallback);
    }

    /**
     * Get method with unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'.
     *
     * @param q1 Unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> getMethodQueryValidAsync(String q1) {
        return getMethodQueryValidWithServiceResponseAsync(q1).map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.body();
            }
        });
    }

    /**
     * Get method with unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'.
     *
     * @param q1 Unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> getMethodQueryValidWithServiceResponseAsync(String q1) {
        if (q1 == null) {
            throw new IllegalArgumentException("Parameter q1 is required and cannot be null.");
        }
        return service.getMethodQueryValid(q1, this.client.acceptLanguage(), this.client.userAgent())
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = getMethodQueryValidDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> getMethodQueryValidDelegate(Response<ResponseBody> response) throws ErrorException, IOException, IllegalArgumentException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Get method with unencoded query parameter with value null.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @throws ErrorException thrown if the request is rejected by server
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent
     */
    public void getMethodQueryNull() {
        getMethodQueryNullWithServiceResponseAsync().toBlocking().single().body();
    }

    /**
     * Get method with unencoded query parameter with value null.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceFuture} object
     */
    public ServiceFuture<Void> getMethodQueryNullAsync(final ServiceCallback<Void> serviceCallback) {
        return ServiceFuture.fromResponse(getMethodQueryNullWithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Get method with unencoded query parameter with value null.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> getMethodQueryNullAsync() {
        return getMethodQueryNullWithServiceResponseAsync().map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.body();
            }
        });
    }

    /**
     * Get method with unencoded query parameter with value null.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> getMethodQueryNullWithServiceResponseAsync() {
        final String q1 = null;
        return service.getMethodQueryNull(q1, this.client.acceptLanguage(), this.client.userAgent())
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = getMethodQueryNullDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    /**
     * Get method with unencoded query parameter with value null.
     *
     * @param q1 Unencoded query parameter with value null
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @throws ErrorException thrown if the request is rejected by server
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent
     */
    public void getMethodQueryNull(String q1) {
        getMethodQueryNullWithServiceResponseAsync(q1).toBlocking().single().body();
    }

    /**
     * Get method with unencoded query parameter with value null.
     *
     * @param q1 Unencoded query parameter with value null
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceFuture} object
     */
    public ServiceFuture<Void> getMethodQueryNullAsync(String q1, final ServiceCallback<Void> serviceCallback) {
        return ServiceFuture.fromResponse(getMethodQueryNullWithServiceResponseAsync(q1), serviceCallback);
    }

    /**
     * Get method with unencoded query parameter with value null.
     *
     * @param q1 Unencoded query parameter with value null
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> getMethodQueryNullAsync(String q1) {
        return getMethodQueryNullWithServiceResponseAsync(q1).map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.body();
            }
        });
    }

    /**
     * Get method with unencoded query parameter with value null.
     *
     * @param q1 Unencoded query parameter with value null
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> getMethodQueryNullWithServiceResponseAsync(String q1) {
        return service.getMethodQueryNull(q1, this.client.acceptLanguage(), this.client.userAgent())
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = getMethodQueryNullDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> getMethodQueryNullDelegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Get method with unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'.
     *
     * @param q1 Unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @throws ErrorException thrown if the request is rejected by server
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent
     */
    public void getPathQueryValid(String q1) {
        getPathQueryValidWithServiceResponseAsync(q1).toBlocking().single().body();
    }

    /**
     * Get method with unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'.
     *
     * @param q1 Unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceFuture} object
     */
    public ServiceFuture<Void> getPathQueryValidAsync(String q1, final ServiceCallback<Void> serviceCallback) {
        return ServiceFuture.fromResponse(getPathQueryValidWithServiceResponseAsync(q1), serviceCallback);
    }

    /**
     * Get method with unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'.
     *
     * @param q1 Unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> getPathQueryValidAsync(String q1) {
        return getPathQueryValidWithServiceResponseAsync(q1).map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.body();
            }
        });
    }

    /**
     * Get method with unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'.
     *
     * @param q1 Unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> getPathQueryValidWithServiceResponseAsync(String q1) {
        if (q1 == null) {
            throw new IllegalArgumentException("Parameter q1 is required and cannot be null.");
        }
        return service.getPathQueryValid(q1, this.client.acceptLanguage(), this.client.userAgent())
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = getPathQueryValidDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> getPathQueryValidDelegate(Response<ResponseBody> response) throws ErrorException, IOException, IllegalArgumentException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Get method with unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @throws ErrorException thrown if the request is rejected by server
     * @throws RuntimeException all other wrapped checked exceptions if the request fails to be sent
     */
    public void getSwaggerQueryValid() {
        getSwaggerQueryValidWithServiceResponseAsync().toBlocking().single().body();
    }

    /**
     * Get method with unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceFuture} object
     */
    public ServiceFuture<Void> getSwaggerQueryValidAsync(final ServiceCallback<Void> serviceCallback) {
        return ServiceFuture.fromResponse(getSwaggerQueryValidWithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Get method with unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> getSwaggerQueryValidAsync() {
        return getSwaggerQueryValidWithServiceResponseAsync().map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.body();
            }
        });
    }

    /**
     * Get method with unencoded query parameter with value 'value1&amp;q2=value2&amp;q3=value3'.
     *
     * @throws IllegalArgumentException thrown if parameters fail the validation
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> getSwaggerQueryValidWithServiceResponseAsync() {
        final String q1 = "value1&q2=value2&q3=value3";
        return service.getSwaggerQueryValid(q1, this.client.acceptLanguage(), this.client.userAgent())
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = getSwaggerQueryValidDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> getSwaggerQueryValidDelegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

}
