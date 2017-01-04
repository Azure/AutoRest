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
import fixtures.http.HttpRetrys;
import com.google.common.reflect.TypeToken;
import com.microsoft.rest.ServiceCall;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceResponse;
import fixtures.http.models.ErrorException;
import java.io.IOException;
import okhttp3.ResponseBody;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.HEAD;
import retrofit2.http.Headers;
import retrofit2.http.HTTP;
import retrofit2.http.PATCH;
import retrofit2.http.POST;
import retrofit2.http.PUT;
import retrofit2.Response;
import rx.functions.Func1;
import rx.Observable;

/**
 * An instance of this class provides access to all the operations defined
 * in HttpRetrys.
 */
public final class HttpRetrysImpl implements HttpRetrys {
    /** The Retrofit service to perform REST calls. */
    private HttpRetrysService service;
    /** The service client containing this operation class. */
    private AutoRestHttpInfrastructureTestServiceImpl client;

    /**
     * Initializes an instance of HttpRetrys.
     *
     * @param retrofit the Retrofit instance built from a Retrofit Builder.
     * @param client the instance of the service client containing this operation class.
     */
    public HttpRetrysImpl(Retrofit retrofit, AutoRestHttpInfrastructureTestServiceImpl client) {
        this.service = retrofit.create(HttpRetrysService.class);
        this.client = client;
    }

    /**
     * The interface defining all the services for HttpRetrys to be
     * used by Retrofit to perform actually REST calls.
     */
    interface HttpRetrysService {
        @Headers("Content-Type: application/json; charset=utf-8")
        @HEAD("http/retry/408")
        Observable<Response<Void>> head408();

        @Headers("Content-Type: application/json; charset=utf-8")
        @PUT("http/retry/500")
        Observable<Response<ResponseBody>> put500(@Body Boolean booleanValue);

        @Headers("Content-Type: application/json; charset=utf-8")
        @PATCH("http/retry/500")
        Observable<Response<ResponseBody>> patch500(@Body Boolean booleanValue);

        @Headers("Content-Type: application/json; charset=utf-8")
        @GET("http/retry/502")
        Observable<Response<ResponseBody>> get502();

        @Headers("Content-Type: application/json; charset=utf-8")
        @POST("http/retry/503")
        Observable<Response<ResponseBody>> post503(@Body Boolean booleanValue);

        @Headers("Content-Type: application/json; charset=utf-8")
        @HTTP(path = "http/retry/503", method = "DELETE", hasBody = true)
        Observable<Response<ResponseBody>> delete503(@Body Boolean booleanValue);

        @Headers("Content-Type: application/json; charset=utf-8")
        @PUT("http/retry/504")
        Observable<Response<ResponseBody>> put504(@Body Boolean booleanValue);

        @Headers("Content-Type: application/json; charset=utf-8")
        @PATCH("http/retry/504")
        Observable<Response<ResponseBody>> patch504(@Body Boolean booleanValue);

    }

    /**
     * Return 408 status code, then 200 after retry.
     *
     */
    public void head408() {
        head408WithServiceResponseAsync().toBlocking().single().getBody();
    }

    /**
     * Return 408 status code, then 200 after retry.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> head408Async(final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(head408WithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Return 408 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> head408Async() {
        return head408WithServiceResponseAsync().map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 408 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> head408WithServiceResponseAsync() {
        return service.head408()
            .flatMap(new Func1<Response<Void>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<Void> response) {
                    try {
                        ServiceResponse<Void> clientResponse = head408Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> head408Delegate(Response<Void> response) throws ErrorException, IOException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .buildEmpty(response);
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     */
    public void put500() {
        put500WithServiceResponseAsync().toBlocking().single().getBody();
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> put500Async(final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(put500WithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> put500Async() {
        return put500WithServiceResponseAsync().map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> put500WithServiceResponseAsync() {
        final Boolean booleanValue = null;
        return service.put500(booleanValue)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = put500Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     */
    public void put500(Boolean booleanValue) {
        put500WithServiceResponseAsync(booleanValue).toBlocking().single().getBody();
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> put500Async(Boolean booleanValue, final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(put500WithServiceResponseAsync(booleanValue), serviceCallback);
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> put500Async(Boolean booleanValue) {
        return put500WithServiceResponseAsync(booleanValue).map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> put500WithServiceResponseAsync(Boolean booleanValue) {
        return service.put500(booleanValue)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = put500Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> put500Delegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     */
    public void patch500() {
        patch500WithServiceResponseAsync().toBlocking().single().getBody();
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> patch500Async(final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(patch500WithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> patch500Async() {
        return patch500WithServiceResponseAsync().map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> patch500WithServiceResponseAsync() {
        final Boolean booleanValue = null;
        return service.patch500(booleanValue)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = patch500Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     */
    public void patch500(Boolean booleanValue) {
        patch500WithServiceResponseAsync(booleanValue).toBlocking().single().getBody();
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> patch500Async(Boolean booleanValue, final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(patch500WithServiceResponseAsync(booleanValue), serviceCallback);
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> patch500Async(Boolean booleanValue) {
        return patch500WithServiceResponseAsync(booleanValue).map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 500 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> patch500WithServiceResponseAsync(Boolean booleanValue) {
        return service.patch500(booleanValue)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = patch500Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> patch500Delegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Return 502 status code, then 200 after retry.
     *
     */
    public void get502() {
        get502WithServiceResponseAsync().toBlocking().single().getBody();
    }

    /**
     * Return 502 status code, then 200 after retry.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> get502Async(final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(get502WithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Return 502 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> get502Async() {
        return get502WithServiceResponseAsync().map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 502 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> get502WithServiceResponseAsync() {
        return service.get502()
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = get502Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> get502Delegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     */
    public void post503() {
        post503WithServiceResponseAsync().toBlocking().single().getBody();
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> post503Async(final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(post503WithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> post503Async() {
        return post503WithServiceResponseAsync().map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> post503WithServiceResponseAsync() {
        final Boolean booleanValue = null;
        return service.post503(booleanValue)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = post503Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     */
    public void post503(Boolean booleanValue) {
        post503WithServiceResponseAsync(booleanValue).toBlocking().single().getBody();
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> post503Async(Boolean booleanValue, final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(post503WithServiceResponseAsync(booleanValue), serviceCallback);
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> post503Async(Boolean booleanValue) {
        return post503WithServiceResponseAsync(booleanValue).map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> post503WithServiceResponseAsync(Boolean booleanValue) {
        return service.post503(booleanValue)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = post503Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> post503Delegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     */
    public void delete503() {
        delete503WithServiceResponseAsync().toBlocking().single().getBody();
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> delete503Async(final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(delete503WithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> delete503Async() {
        return delete503WithServiceResponseAsync().map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> delete503WithServiceResponseAsync() {
        final Boolean booleanValue = null;
        return service.delete503(booleanValue)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = delete503Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     */
    public void delete503(Boolean booleanValue) {
        delete503WithServiceResponseAsync(booleanValue).toBlocking().single().getBody();
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> delete503Async(Boolean booleanValue, final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(delete503WithServiceResponseAsync(booleanValue), serviceCallback);
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> delete503Async(Boolean booleanValue) {
        return delete503WithServiceResponseAsync(booleanValue).map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 503 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> delete503WithServiceResponseAsync(Boolean booleanValue) {
        return service.delete503(booleanValue)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = delete503Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> delete503Delegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     */
    public void put504() {
        put504WithServiceResponseAsync().toBlocking().single().getBody();
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> put504Async(final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(put504WithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> put504Async() {
        return put504WithServiceResponseAsync().map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> put504WithServiceResponseAsync() {
        final Boolean booleanValue = null;
        return service.put504(booleanValue)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = put504Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     */
    public void put504(Boolean booleanValue) {
        put504WithServiceResponseAsync(booleanValue).toBlocking().single().getBody();
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> put504Async(Boolean booleanValue, final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(put504WithServiceResponseAsync(booleanValue), serviceCallback);
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> put504Async(Boolean booleanValue) {
        return put504WithServiceResponseAsync(booleanValue).map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> put504WithServiceResponseAsync(Boolean booleanValue) {
        return service.put504(booleanValue)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = put504Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> put504Delegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     */
    public void patch504() {
        patch504WithServiceResponseAsync().toBlocking().single().getBody();
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> patch504Async(final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(patch504WithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> patch504Async() {
        return patch504WithServiceResponseAsync().map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> patch504WithServiceResponseAsync() {
        final Boolean booleanValue = null;
        return service.patch504(booleanValue)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = patch504Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     */
    public void patch504(Boolean booleanValue) {
        patch504WithServiceResponseAsync(booleanValue).toBlocking().single().getBody();
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> patch504Async(Boolean booleanValue, final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(patch504WithServiceResponseAsync(booleanValue), serviceCallback);
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> patch504Async(Boolean booleanValue) {
        return patch504WithServiceResponseAsync(booleanValue).map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Return 504 status code, then 200 after retry.
     *
     * @param booleanValue Simple boolean value true
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> patch504WithServiceResponseAsync(Boolean booleanValue) {
        return service.patch504(booleanValue)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = patch504Delegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> patch504Delegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return this.client.restClient().responseBuilderFactory().<Void, ErrorException>newInstance(this.client.serializerAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

}
