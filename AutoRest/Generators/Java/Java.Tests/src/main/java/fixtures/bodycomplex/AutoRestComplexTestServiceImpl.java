/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.bodycomplex;

import com.microsoft.rest.ServiceClient;
import com.microsoft.rest.AutoRestBaseUrl;
import okhttp3.OkHttpClient;
import retrofit2.Retrofit;

/**
 * Initializes a new instance of the AutoRestComplexTestService class.
 */
public final class AutoRestComplexTestServiceImpl extends ServiceClient implements AutoRestComplexTestService {
    /**
     * The URL used as the base for all cloud service requests.
     */
    private final AutoRestBaseUrl baseUrl;

    /**
     * Gets the URL used as the base for all cloud service requests.
     *
     * @return The BaseUrl value.
     */
    public AutoRestBaseUrl getBaseUrl() {
        return this.baseUrl;
    }

    /** API ID. */
    private String apiVersion;

    /**
     * Gets API ID.
     *
     * @return the apiVersion value.
     */
    public String getApiVersion() {
        return this.apiVersion;
    }

    /**
     * Sets API ID.
     *
     * @param apiVersion the apiVersion value.
     */
    public void setApiVersion(String apiVersion) {
        this.apiVersion = apiVersion;
    }

    /**
     * Gets the BasicOperations object to access its operations.
     * @return the BasicOperations object.
     */
    public BasicOperations basic() {
        return new BasicOperationsImpl(this.retrofitBuilder.client(clientBuilder.build()).build(), this);
    }

    /**
     * Gets the PrimitiveOperations object to access its operations.
     * @return the PrimitiveOperations object.
     */
    public PrimitiveOperations primitive() {
        return new PrimitiveOperationsImpl(this.retrofitBuilder.client(clientBuilder.build()).build(), this);
    }

    /**
     * Gets the ArrayOperations object to access its operations.
     * @return the ArrayOperations object.
     */
    public ArrayOperations array() {
        return new ArrayOperationsImpl(this.retrofitBuilder.client(clientBuilder.build()).build(), this);
    }

    /**
     * Gets the DictionaryOperations object to access its operations.
     * @return the DictionaryOperations object.
     */
    public DictionaryOperations dictionary() {
        return new DictionaryOperationsImpl(this.retrofitBuilder.client(clientBuilder.build()).build(), this);
    }

    /**
     * Gets the InheritanceOperations object to access its operations.
     * @return the InheritanceOperations object.
     */
    public InheritanceOperations inheritance() {
        return new InheritanceOperationsImpl(this.retrofitBuilder.client(clientBuilder.build()).build(), this);
    }

    /**
     * Gets the PolymorphismOperations object to access its operations.
     * @return the PolymorphismOperations object.
     */
    public PolymorphismOperations polymorphism() {
        return new PolymorphismOperationsImpl(this.retrofitBuilder.client(clientBuilder.build()).build(), this);
    }

    /**
     * Gets the PolymorphicrecursiveOperations object to access its operations.
     * @return the PolymorphicrecursiveOperations object.
     */
    public PolymorphicrecursiveOperations polymorphicrecursive() {
        return new PolymorphicrecursiveOperationsImpl(this.retrofitBuilder.client(clientBuilder.build()).build(), this);
    }

    /**
     * Gets the ReadonlypropertyOperations object to access its operations.
     * @return the ReadonlypropertyOperations object.
     */
    public ReadonlypropertyOperations readonlyproperty() {
        return new ReadonlypropertyOperationsImpl(this.retrofitBuilder.client(clientBuilder.build()).build(), this);
    }

    /**
     * Initializes an instance of AutoRestComplexTestService client.
     */
    public AutoRestComplexTestServiceImpl() {
        this("http://localhost");
    }

    /**
     * Initializes an instance of AutoRestComplexTestService client.
     *
     * @param baseUrl the base URL of the host
     */
    public AutoRestComplexTestServiceImpl(String baseUrl) {
        super();
        this.baseUrl = new AutoRestBaseUrl(baseUrl);
        initialize();
    }

    /**
     * Initializes an instance of AutoRestComplexTestService client.
     *
     * @param baseUrl the base URL of the host
     * @param clientBuilder the builder for building up an {@link OkHttpClient}
     * @param retrofitBuilder the builder for building up a {@link Retrofit}
     */
    public AutoRestComplexTestServiceImpl(String baseUrl, OkHttpClient.Builder clientBuilder, Retrofit.Builder retrofitBuilder) {
        super(clientBuilder, retrofitBuilder);
        this.baseUrl = new AutoRestBaseUrl(baseUrl);
        initialize();
    }

    @Override
    protected void initialize() {
        super.initialize();
        this.retrofitBuilder.baseUrl(baseUrl);
    }
}
