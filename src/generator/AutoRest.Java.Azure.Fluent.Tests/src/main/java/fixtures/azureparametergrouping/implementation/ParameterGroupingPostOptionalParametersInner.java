/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.azureparametergrouping.implementation;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Additional parameters for the ParameterGrouping_postOptional operation.
 */
public class ParameterGroupingPostOptionalParametersInner {
    /**
     * The customHeader property.
     */
    @JsonProperty(value = "")
    private String customHeader;

    /**
     * Query parameter with default.
     */
    @JsonProperty(value = "")
    private Integer query;

    /**
     * Get the customHeader value.
     *
     * @return the customHeader value
     */
    public String customHeader() {
        return this.customHeader;
    }

    /**
     * Set the customHeader value.
     *
     * @param customHeader the customHeader value to set
     * @return the ParameterGroupingPostOptionalParametersInner object itself.
     */
    public ParameterGroupingPostOptionalParametersInner withCustomHeader(String customHeader) {
        this.customHeader = customHeader;
        return this;
    }

    /**
     * Get the query value.
     *
     * @return the query value
     */
    public Integer query() {
        return this.query;
    }

    /**
     * Set the query value.
     *
     * @param query the query value to set
     * @return the ParameterGroupingPostOptionalParametersInner object itself.
     */
    public ParameterGroupingPostOptionalParametersInner withQuery(Integer query) {
        this.query = query;
        return this;
    }

}
