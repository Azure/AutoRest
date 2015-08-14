// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.


package fixtures.bodystring;

import com.microsoft.rest.ServiceClient;
import com.squareup.okhttp.OkHttpClient;
import retrofit.RestAdapter;

/**
 * Initializes a new instance of the AutoRestSwaggerBATService class.
 */
public class AutoRestSwaggerBATServiceImpl extends ServiceClient implements AutoRestSwaggerBATService {
    private String baseUri;

    /**
     * Gets the URI used as the base for all cloud service requests.
     * @return The BaseUri value.
     */
    public String getBaseUri() {
        return this.baseUri;
    }

    private StringOperations stringOperations;

    /**
     * Gets the StringOperations object to access its operations.
     * @return the stringOperations value.
     */
    public StringOperations getStringOperations() {
        return this.stringOperations;
    }

    private EnumOperations enumOperations;

    /**
     * Gets the EnumOperations object to access its operations.
     * @return the enumOperations value.
     */
    public EnumOperations getEnumOperations() {
        return this.enumOperations;
    }

    /**
     * Initializes an instance of AutoRestSwaggerBATService client.
     */
    public AutoRestSwaggerBATServiceImpl() {
        this("http://localhost");
    }

    /**
     * Initializes an instance of AutoRestSwaggerBATService client.
     *
     * @param baseUri the base URI of the host
     */
    public AutoRestSwaggerBATServiceImpl(String baseUri) {
        super();
        this.baseUri = baseUri;
        initialize();
    }

    /**
     * Initializes an instance of AutoRestSwaggerBATService client.
     *
     * @param baseUri the base URI of the host
     * @param client the {@link OkHttpClient} client to use for REST calls
     * @param restAdapterBuilder the builder for building up a {@link RestAdapter}
     */
    public AutoRestSwaggerBATServiceImpl(String baseUri, OkHttpClient client, RestAdapter.Builder restAdapterBuilder) {
        super(client, restAdapterBuilder);
        this.baseUri = baseUri;
        initialize();
    }

    private void initialize() {
        RestAdapter restAdapter = restAdapterBuilder.setEndpoint(baseUri).build();
        this.stringOperations = new StringOperationsImpl(restAdapter);
        this.enumOperations = new EnumOperationsImpl(restAdapter);
    }
}
