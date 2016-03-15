/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.http.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Defines headers for get307 operation.
 */
public class HttpRedirectsGet307Headers {
    /**
     * The redirect location for this request.
     */
    @JsonProperty(value = "Location")
    private String location;

    /**
     * Get the location value.
     *
     * @return the location value
     */
    public String getLocation() {
        return this.location;
    }

    /**
     * Set the location value.
     *
     * @param location the location value to set
     */
    public void setLocation(String location) {
        this.location = location;
    }

    /**
     * Set the location value.
     *
     * @param location the location value to set
     * @return the HttpRedirectsGet307Headers object itself.
     */
    public HttpRedirectsGet307Headers withLocation(String location) {
        this.location = location;
        return this;
    }

}
