// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.


package fixtures.url;

import com.microsoft.rest.ServiceClient;
import com.squareup.okhtpp.OkHttpClient;
import retrofit.RestAdapter;

/**
 * Initializes a new instance of the AutoRestUrlTestService class.
 */
public class AutoRestUrlTestServiceImpl extends ServiceClient<AutoRestUrlTestService> implements AutoRestUrlTestService {
    private String baseUri;

    /**
     * Gets the URI used as the base for all cloud service requests.
     * @return The BaseUri value.
     */
    public String getBaseUri();

    private String globalStringPath;

    /**
     * A string value 'globalItemStringPath' that appears in the path
     * @return the globalStringPath value.
     */
    public String getGlobalStringPath();

    private Paths paths;

    /**
     * Test Infrastructure for AutoRest
     * @return the paths value.
     */
    Paths getPaths();

    private Queries queries;

    /**
     * Test Infrastructure for AutoRest
     * @return the queries value.
     */
    Queries getQueries();

    private PathItems pathItems;

    /**
     * Test Infrastructure for AutoRest
     * @return the pathItems value.
     */
    PathItems getPathItems();

    public AutoRestUrlTestService() {
        this("http://localhost");
    }

    public AutoRestUrlTestService(String baseUri) {
        super();
        this.baseUri = baseUri;
        initialize();
    }

    public AutoRestUrlTestService(String baseUri, OkHttpClient client, RestAdapter.Builder restAdapterBuilder) {
        super(client, restAdapterBuilder);
        this.baseUri = baseUri();
        initialize();
    }

    private void initialize() {
        RestAdapter restAdapter = restAdapterBuilder.setEndpoint(baseUri).build();
        this.paths = restAdapter.create(Paths.class);
        this.queries = restAdapter.create(Queries.class);
        this.pathItems = restAdapter.create(PathItems.class);
    }
}
