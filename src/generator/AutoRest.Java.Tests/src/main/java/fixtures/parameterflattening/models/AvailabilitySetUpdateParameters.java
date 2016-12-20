/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.parameterflattening.models;

import java.util.Map;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * The AvailabilitySetUpdateParameters model.
 */
public class AvailabilitySetUpdateParameters {
    /**
     * A set of tags.
     * A description about the set of tags.
     */
    @JsonProperty(required = true)
    private Map<String, String> tags;

    /**
     * Get the tags value.
     *
     * @return the tags value
     */
    public Map<String, String> tags() {
        return this.tags;
    }

    /**
     * Set the tags value.
     *
     * @param tags the tags value to set
     * @return the AvailabilitySetUpdateParameters object itself.
     */
    public AvailabilitySetUpdateParameters withTags(Map<String, String> tags) {
        this.tags = tags;
        return this;
    }

}
