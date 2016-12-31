/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.parameterflattening.implementation;

import fixtures.parameterflattening.AutoRestParameterFlattening;
import fixtures.parameterflattening.AvailabilitySets;
import com.microsoft.rest.ServiceClient;
import com.microsoft.rest.RestClient;
import okhttp3.OkHttpClient;
import retrofit2.Retrofit;

/**
 * Initializes a new instance of the AutoRestParameterFlattening class.
 */
public final class AutoRestParameterFlatteningImpl extends ServiceClient implements AutoRestParameterFlattening {

    /**
     * The AvailabilitySets object to access its operations.
     */
    private AvailabilitySets availabilitySets;

    /**
     * Gets the AvailabilitySets object to access its operations.
     * @return the AvailabilitySets object.
     */
    public AvailabilitySets availabilitySets() {
        return this.availabilitySets;
    }

    /**
     * Initializes an instance of AutoRestParameterFlattening client.
     */
    public AutoRestParameterFlatteningImpl() {
        this("http://localhost");
    }

    /**
     * Initializes an instance of AutoRestParameterFlattening client.
     *
     * @param baseUrl the base URL of the host
     */
    public AutoRestParameterFlatteningImpl(String baseUrl) {
        super(baseUrl);
        initialize();
    }

    /**
     * Initializes an instance of AutoRestParameterFlattening client.
     *
     * @param clientBuilder the builder for building an OkHttp client, bundled with user configurations
     * @param restBuilder the builder for building an Retrofit client, bundled with user configurations
     */
    public AutoRestParameterFlatteningImpl(OkHttpClient.Builder clientBuilder, Retrofit.Builder restBuilder) {
        this("http://localhost", clientBuilder, restBuilder);
        initialize();
    }

    /**
     * Initializes an instance of AutoRestParameterFlattening client.
     *
     * @param baseUrl the base URL of the host
     * @param clientBuilder the builder for building an OkHttp client, bundled with user configurations
     * @param restBuilder the builder for building an Retrofit client, bundled with user configurations
     */
    public AutoRestParameterFlatteningImpl(String baseUrl, OkHttpClient.Builder clientBuilder, Retrofit.Builder restBuilder) {
        super(baseUrl, clientBuilder, restBuilder);
        initialize();
    }

    /**
     * Initializes an instance of AutoRestParameterFlattening client.
     *
     * @param restClient the REST client containing pre-configured settings
     */
    public AutoRestParameterFlatteningImpl(RestClient restClient) {
        super(restClient);
        initialize();
    }

    private void initialize() {
        this.availabilitySets = new AvailabilitySetsImpl(retrofit(), this);
    }
}
