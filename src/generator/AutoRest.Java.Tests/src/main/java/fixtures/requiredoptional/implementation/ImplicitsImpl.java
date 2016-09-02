/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.requiredoptional.implementation;

import retrofit2.Retrofit;
import fixtures.requiredoptional.Implicits;
import com.google.common.reflect.TypeToken;
import com.microsoft.rest.ServiceCall;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceResponse;
import com.microsoft.rest.ServiceResponseBuilder;
import fixtures.requiredoptional.models.Error;
import fixtures.requiredoptional.models.ErrorException;
import java.io.IOException;
import okhttp3.ResponseBody;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.Header;
import retrofit2.http.Headers;
import retrofit2.http.Path;
import retrofit2.http.PUT;
import retrofit2.http.Query;
import retrofit2.Response;
import rx.functions.Func1;
import rx.Observable;

/**
 * An instance of this class provides access to all the operations defined
 * in Implicits.
 */
public final class ImplicitsImpl implements Implicits {
    /** The Retrofit service to perform REST calls. */
    private ImplicitsService service;
    /** The service client containing this operation class. */
    private AutoRestRequiredOptionalTestServiceImpl client;

    /**
     * Initializes an instance of Implicits.
     *
     * @param retrofit the Retrofit instance built from a Retrofit Builder.
     * @param client the instance of the service client containing this operation class.
     */
    public ImplicitsImpl(Retrofit retrofit, AutoRestRequiredOptionalTestServiceImpl client) {
        this.service = retrofit.create(ImplicitsService.class);
        this.client = client;
    }

    /**
     * The interface defining all the services for Implicits to be
     * used by Retrofit to perform actually REST calls.
     */
    interface ImplicitsService {
        @Headers("Content-Type: application/json; charset=utf-8")
        @GET("reqopt/implicit/required/path/{pathParameter}")
        Observable<Response<ResponseBody>> getRequiredPath(@Path("pathParameter") String pathParameter);

        @Headers("Content-Type: application/json; charset=utf-8")
        @PUT("reqopt/implicit/optional/query")
        Observable<Response<ResponseBody>> putOptionalQuery(@Query("queryParameter") String queryParameter);

        @Headers("Content-Type: application/json; charset=utf-8")
        @PUT("reqopt/implicit/optional/header")
        Observable<Response<ResponseBody>> putOptionalHeader(@Header("queryParameter") String queryParameter);

        @Headers("Content-Type: application/json; charset=utf-8")
        @PUT("reqopt/implicit/optional/body")
        Observable<Response<ResponseBody>> putOptionalBody(@Body String bodyParameter);

        @Headers("Content-Type: application/json; charset=utf-8")
        @GET("reqopt/global/required/path/{required-global-path}")
        Observable<Response<ResponseBody>> getRequiredGlobalPath(@Path("required-global-path") String requiredGlobalPath);

        @Headers("Content-Type: application/json; charset=utf-8")
        @GET("reqopt/global/required/query")
        Observable<Response<ResponseBody>> getRequiredGlobalQuery(@Query("required-global-query") String requiredGlobalQuery);

        @Headers("Content-Type: application/json; charset=utf-8")
        @GET("reqopt/global/optional/query")
        Observable<Response<ResponseBody>> getOptionalGlobalQuery(@Query("optional-global-query") Integer optionalGlobalQuery);

    }

    /**
     * Test implicitly required path parameter.
     *
     * @param pathParameter the String value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @throws IllegalArgumentException exception thrown from invalid parameters
     * @return the Error object wrapped in {@link ServiceResponse} if successful.
     */
    public ServiceResponse<Error> getRequiredPath(String pathParameter) throws ErrorException, IOException, IllegalArgumentException {
        return getRequiredPathAsync(pathParameter).toBlocking().single();
    }

    /**
     * Test implicitly required path parameter.
     *
     * @param pathParameter the String value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Error> getRequiredPathAsync(String pathParameter, final ServiceCallback<Error> serviceCallback) {
        return ServiceCall.create(getRequiredPathAsync(pathParameter), serviceCallback);
    }

    /**
     * Test implicitly required path parameter.
     *
     * @param pathParameter the String value
     * @return the observable to the Error object
     */
    public Observable<ServiceResponse<Error>> getRequiredPathAsync(String pathParameter) {
        if (pathParameter == null) {
            throw new IllegalArgumentException("Parameter pathParameter is required and cannot be null.");
        }
        return service.getRequiredPath(pathParameter)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Error>>>() {
                @Override
                public Observable<ServiceResponse<Error>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Error> clientResponse = getRequiredPathDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Error> getRequiredPathDelegate(Response<ResponseBody> response) throws ErrorException, IOException, IllegalArgumentException {
        return new ServiceResponseBuilder<Error, ErrorException>(this.client.mapperAdapter())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Test implicitly optional query parameter.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    public ServiceResponse<Void> putOptionalQuery() throws ErrorException, IOException {
        return putOptionalQueryAsync().toBlocking().single();
    }

    /**
     * Test implicitly optional query parameter.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> putOptionalQueryAsync(final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(putOptionalQueryAsync(), serviceCallback);
    }

    /**
     * Test implicitly optional query parameter.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> putOptionalQueryAsync() {
        final String queryParameter = null;
        return service.putOptionalQuery(queryParameter)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = putOptionalQueryDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    /**
     * Test implicitly optional query parameter.
     *
     * @param queryParameter the String value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    public ServiceResponse<Void> putOptionalQuery(String queryParameter) throws ErrorException, IOException {
        return putOptionalQueryAsync(queryParameter).toBlocking().single();
    }

    /**
     * Test implicitly optional query parameter.
     *
     * @param queryParameter the String value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> putOptionalQueryAsync(String queryParameter, final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(putOptionalQueryAsync(queryParameter), serviceCallback);
    }

    /**
     * Test implicitly optional query parameter.
     *
     * @param queryParameter the String value
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> putOptionalQueryAsync(String queryParameter) {
        return service.putOptionalQuery(queryParameter)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = putOptionalQueryDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> putOptionalQueryDelegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return new ServiceResponseBuilder<Void, ErrorException>(this.client.mapperAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Test implicitly optional header parameter.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    public ServiceResponse<Void> putOptionalHeader() throws ErrorException, IOException {
        return putOptionalHeaderAsync().toBlocking().single();
    }

    /**
     * Test implicitly optional header parameter.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> putOptionalHeaderAsync(final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(putOptionalHeaderAsync(), serviceCallback);
    }

    /**
     * Test implicitly optional header parameter.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> putOptionalHeaderAsync() {
        final String queryParameter = null;
        return service.putOptionalHeader(queryParameter)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = putOptionalHeaderDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    /**
     * Test implicitly optional header parameter.
     *
     * @param queryParameter the String value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    public ServiceResponse<Void> putOptionalHeader(String queryParameter) throws ErrorException, IOException {
        return putOptionalHeaderAsync(queryParameter).toBlocking().single();
    }

    /**
     * Test implicitly optional header parameter.
     *
     * @param queryParameter the String value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> putOptionalHeaderAsync(String queryParameter, final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(putOptionalHeaderAsync(queryParameter), serviceCallback);
    }

    /**
     * Test implicitly optional header parameter.
     *
     * @param queryParameter the String value
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> putOptionalHeaderAsync(String queryParameter) {
        return service.putOptionalHeader(queryParameter)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = putOptionalHeaderDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> putOptionalHeaderDelegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return new ServiceResponseBuilder<Void, ErrorException>(this.client.mapperAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Test implicitly optional body parameter.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    public ServiceResponse<Void> putOptionalBody() throws ErrorException, IOException {
        return putOptionalBodyAsync().toBlocking().single();
    }

    /**
     * Test implicitly optional body parameter.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> putOptionalBodyAsync(final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(putOptionalBodyAsync(), serviceCallback);
    }

    /**
     * Test implicitly optional body parameter.
     *
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> putOptionalBodyAsync() {
        final String bodyParameter = null;
        return service.putOptionalBody(bodyParameter)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = putOptionalBodyDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    /**
     * Test implicitly optional body parameter.
     *
     * @param bodyParameter the String value
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the {@link ServiceResponse} object if successful.
     */
    public ServiceResponse<Void> putOptionalBody(String bodyParameter) throws ErrorException, IOException {
        return putOptionalBodyAsync(bodyParameter).toBlocking().single();
    }

    /**
     * Test implicitly optional body parameter.
     *
     * @param bodyParameter the String value
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> putOptionalBodyAsync(String bodyParameter, final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(putOptionalBodyAsync(bodyParameter), serviceCallback);
    }

    /**
     * Test implicitly optional body parameter.
     *
     * @param bodyParameter the String value
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> putOptionalBodyAsync(String bodyParameter) {
        return service.putOptionalBody(bodyParameter)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = putOptionalBodyDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> putOptionalBodyDelegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return new ServiceResponseBuilder<Void, ErrorException>(this.client.mapperAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Test implicitly required path parameter.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @throws IllegalArgumentException exception thrown from invalid parameters
     * @return the Error object wrapped in {@link ServiceResponse} if successful.
     */
    public ServiceResponse<Error> getRequiredGlobalPath() throws ErrorException, IOException, IllegalArgumentException {
        return getRequiredGlobalPathAsync().toBlocking().single();
    }

    /**
     * Test implicitly required path parameter.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Error> getRequiredGlobalPathAsync(final ServiceCallback<Error> serviceCallback) {
        return ServiceCall.create(getRequiredGlobalPathAsync(), serviceCallback);
    }

    /**
     * Test implicitly required path parameter.
     *
     * @return the observable to the Error object
     */
    public Observable<ServiceResponse<Error>> getRequiredGlobalPathAsync() {
        if (this.client.requiredGlobalPath() == null) {
            throw new IllegalArgumentException("Parameter this.client.requiredGlobalPath() is required and cannot be null.");
        }
        return service.getRequiredGlobalPath(this.client.requiredGlobalPath())
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Error>>>() {
                @Override
                public Observable<ServiceResponse<Error>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Error> clientResponse = getRequiredGlobalPathDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Error> getRequiredGlobalPathDelegate(Response<ResponseBody> response) throws ErrorException, IOException, IllegalArgumentException {
        return new ServiceResponseBuilder<Error, ErrorException>(this.client.mapperAdapter())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Test implicitly required query parameter.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @throws IllegalArgumentException exception thrown from invalid parameters
     * @return the Error object wrapped in {@link ServiceResponse} if successful.
     */
    public ServiceResponse<Error> getRequiredGlobalQuery() throws ErrorException, IOException, IllegalArgumentException {
        return getRequiredGlobalQueryAsync().toBlocking().single();
    }

    /**
     * Test implicitly required query parameter.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Error> getRequiredGlobalQueryAsync(final ServiceCallback<Error> serviceCallback) {
        return ServiceCall.create(getRequiredGlobalQueryAsync(), serviceCallback);
    }

    /**
     * Test implicitly required query parameter.
     *
     * @return the observable to the Error object
     */
    public Observable<ServiceResponse<Error>> getRequiredGlobalQueryAsync() {
        if (this.client.requiredGlobalQuery() == null) {
            throw new IllegalArgumentException("Parameter this.client.requiredGlobalQuery() is required and cannot be null.");
        }
        return service.getRequiredGlobalQuery(this.client.requiredGlobalQuery())
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Error>>>() {
                @Override
                public Observable<ServiceResponse<Error>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Error> clientResponse = getRequiredGlobalQueryDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Error> getRequiredGlobalQueryDelegate(Response<ResponseBody> response) throws ErrorException, IOException, IllegalArgumentException {
        return new ServiceResponseBuilder<Error, ErrorException>(this.client.mapperAdapter())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Test implicitly optional query parameter.
     *
     * @throws ErrorException exception thrown from REST call
     * @throws IOException exception thrown from serialization/deserialization
     * @return the Error object wrapped in {@link ServiceResponse} if successful.
     */
    public ServiceResponse<Error> getOptionalGlobalQuery() throws ErrorException, IOException {
        return getOptionalGlobalQueryAsync().toBlocking().single();
    }

    /**
     * Test implicitly optional query parameter.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Error> getOptionalGlobalQueryAsync(final ServiceCallback<Error> serviceCallback) {
        return ServiceCall.create(getOptionalGlobalQueryAsync(), serviceCallback);
    }

    /**
     * Test implicitly optional query parameter.
     *
     * @return the observable to the Error object
     */
    public Observable<ServiceResponse<Error>> getOptionalGlobalQueryAsync() {
        return service.getOptionalGlobalQuery(this.client.optionalGlobalQuery())
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Error>>>() {
                @Override
                public Observable<ServiceResponse<Error>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Error> clientResponse = getOptionalGlobalQueryDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Error> getOptionalGlobalQueryDelegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return new ServiceResponseBuilder<Error, ErrorException>(this.client.mapperAdapter())
                .registerError(ErrorException.class)
                .build(response);
    }

}
