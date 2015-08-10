// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.


package fixtures.header;

import com.microsoft.rest.ServiceClient;
import com.squareup.okhttp.OkHttpClient;
import retrofit.RestAdapter;

/**
 * Initializes a new instance of the AutoRestSwaggerBATHeaderService class.
 */
public class AutoRestSwaggerBATHeaderServiceImpl extends ServiceClient<AutoRestSwaggerBATHeaderService> implements AutoRestSwaggerBATHeaderService {
    private String baseUri;

    /**
     * Gets the URI used as the base for all cloud service requests.
     * @return The BaseUri value.
     */
    public String getBaseUri() {
        return this.baseUri;
    }

    private HeaderOperations headerOperations;

    /**
     * Test Infrastructure for AutoRest
     * @return the headerOperations value.
     */
    public HeaderOperations getHeaderOperations() {
        return this.headerOperations;
    }

    public AutoRestSwaggerBATHeaderServiceImpl() {
        this("http://localhost");
    }

    public AutoRestSwaggerBATHeaderServiceImpl(String baseUri) {
        super();
        this.baseUri = baseUri;
        initialize();
    }

    public AutoRestSwaggerBATHeaderServiceImpl(String baseUri, OkHttpClient client, RestAdapter.Builder restAdapterBuilder) {
        super(client, restAdapterBuilder);
        this.baseUri = baseUri;
        initialize();
    }

    private void initialize() {
        RestAdapter restAdapter = restAdapterBuilder.setEndpoint(baseUri).build();
        this.headerOperations = restAdapter.create(HeaderOperations.class);
    }
}
