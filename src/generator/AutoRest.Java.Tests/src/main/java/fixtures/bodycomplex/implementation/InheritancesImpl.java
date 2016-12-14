/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.bodycomplex.implementation;

import retrofit2.Retrofit;
import fixtures.bodycomplex.Inheritances;
import com.google.common.reflect.TypeToken;
import com.microsoft.rest.ServiceCall;
import com.microsoft.rest.ServiceCallback;
import com.microsoft.rest.ServiceResponse;
import com.microsoft.rest.ServiceResponseBuilder;
import com.microsoft.rest.Validator;
import fixtures.bodycomplex.models.ErrorException;
import fixtures.bodycomplex.models.Siamese;
import java.io.IOException;
import okhttp3.ResponseBody;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.PUT;
import retrofit2.Response;
import rx.functions.Func1;
import rx.Observable;

/**
 * An instance of this class provides access to all the operations defined
 * in Inheritances.
 */
public final class InheritancesImpl implements Inheritances {
    /** The Retrofit service to perform REST calls. */
    private InheritancesService service;
    /** The service client containing this operation class. */
    private AutoRestComplexTestServiceImpl client;

    /**
     * Initializes an instance of Inheritances.
     *
     * @param retrofit the Retrofit instance built from a Retrofit Builder.
     * @param client the instance of the service client containing this operation class.
     */
    public InheritancesImpl(Retrofit retrofit, AutoRestComplexTestServiceImpl client) {
        this.service = retrofit.create(InheritancesService.class);
        this.client = client;
    }

    /**
     * The interface defining all the services for Inheritances to be
     * used by Retrofit to perform actually REST calls.
     */
    interface InheritancesService {
        @Headers("Content-Type: application/json; charset=utf-8")
        @GET("complex/inheritance/valid")
        Observable<Response<ResponseBody>> getValid();

        @Headers("Content-Type: application/json; charset=utf-8")
        @PUT("complex/inheritance/valid")
        Observable<Response<ResponseBody>> putValid(@Body Siamese complexBody);

    }

    /**
     * Get complex types that extend others.
     *
     * @return the Siamese object if successful.
     */
    public Siamese getValid() {
        return getValidWithServiceResponseAsync().toBlocking().single().getBody();
    }

    /**
     * Get complex types that extend others.
     *
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Siamese> getValidAsync(final ServiceCallback<Siamese> serviceCallback) {
        return ServiceCall.create(getValidWithServiceResponseAsync(), serviceCallback);
    }

    /**
     * Get complex types that extend others.
     *
     * @return the observable to the Siamese object
     */
    public Observable<Siamese> getValidAsync() {
        return getValidWithServiceResponseAsync().map(new Func1<ServiceResponse<Siamese>, Siamese>() {
            @Override
            public Siamese call(ServiceResponse<Siamese> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Get complex types that extend others.
     *
     * @return the observable to the Siamese object
     */
    public Observable<ServiceResponse<Siamese>> getValidWithServiceResponseAsync() {
        return service.getValid()
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Siamese>>>() {
                @Override
                public Observable<ServiceResponse<Siamese>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Siamese> clientResponse = getValidDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Siamese> getValidDelegate(Response<ResponseBody> response) throws ErrorException, IOException {
        return new ServiceResponseBuilder<Siamese, ErrorException>(this.client.mapperAdapter())
                .register(200, new TypeToken<Siamese>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

    /**
     * Put complex types that extend others.
     *
     * @param complexBody Please put a siamese with id=2, name="Siameee", color=green, breed=persion, which hates 2 dogs, the 1st one named "Potato" with id=1 and food="tomato", and the 2nd one named "Tomato" with id=-1 and food="french fries".
     */
    public void putValid(Siamese complexBody) {
        putValidWithServiceResponseAsync(complexBody).toBlocking().single().getBody();
    }

    /**
     * Put complex types that extend others.
     *
     * @param complexBody Please put a siamese with id=2, name="Siameee", color=green, breed=persion, which hates 2 dogs, the 1st one named "Potato" with id=1 and food="tomato", and the 2nd one named "Tomato" with id=-1 and food="french fries".
     * @param serviceCallback the async ServiceCallback to handle successful and failed responses.
     * @return the {@link ServiceCall} object
     */
    public ServiceCall<Void> putValidAsync(Siamese complexBody, final ServiceCallback<Void> serviceCallback) {
        return ServiceCall.create(putValidWithServiceResponseAsync(complexBody), serviceCallback);
    }

    /**
     * Put complex types that extend others.
     *
     * @param complexBody Please put a siamese with id=2, name="Siameee", color=green, breed=persion, which hates 2 dogs, the 1st one named "Potato" with id=1 and food="tomato", and the 2nd one named "Tomato" with id=-1 and food="french fries".
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<Void> putValidAsync(Siamese complexBody) {
        return putValidWithServiceResponseAsync(complexBody).map(new Func1<ServiceResponse<Void>, Void>() {
            @Override
            public Void call(ServiceResponse<Void> response) {
                return response.getBody();
            }
        });
    }

    /**
     * Put complex types that extend others.
     *
     * @param complexBody Please put a siamese with id=2, name="Siameee", color=green, breed=persion, which hates 2 dogs, the 1st one named "Potato" with id=1 and food="tomato", and the 2nd one named "Tomato" with id=-1 and food="french fries".
     * @return the {@link ServiceResponse} object if successful.
     */
    public Observable<ServiceResponse<Void>> putValidWithServiceResponseAsync(Siamese complexBody) {
        if (complexBody == null) {
            throw new IllegalArgumentException("Parameter complexBody is required and cannot be null.");
        }
        Validator.validate(complexBody);
        return service.putValid(complexBody)
            .flatMap(new Func1<Response<ResponseBody>, Observable<ServiceResponse<Void>>>() {
                @Override
                public Observable<ServiceResponse<Void>> call(Response<ResponseBody> response) {
                    try {
                        ServiceResponse<Void> clientResponse = putValidDelegate(response);
                        return Observable.just(clientResponse);
                    } catch (Throwable t) {
                        return Observable.error(t);
                    }
                }
            });
    }

    private ServiceResponse<Void> putValidDelegate(Response<ResponseBody> response) throws ErrorException, IOException, IllegalArgumentException {
        return new ServiceResponseBuilder<Void, ErrorException>(this.client.mapperAdapter())
                .register(200, new TypeToken<Void>() { }.getType())
                .registerError(ErrorException.class)
                .build(response);
    }

}
