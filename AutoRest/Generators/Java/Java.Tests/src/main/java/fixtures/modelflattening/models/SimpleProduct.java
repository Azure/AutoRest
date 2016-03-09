/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.modelflattening.models;

import com.fasterxml.jackson.annotation.JsonProperty;
import com.microsoft.rest.serializer.JsonFlatten;

/**
 * The product documentation.
 */
@JsonFlatten
public class SimpleProduct extends BaseProduct {
    /**
     * Display name of product.
     */
    @JsonProperty(value = "details.max_product_display_name", required = true)
    private String maxProductDisplayName;

    /**
     * Capacity of product. For example, 4 people. Possible values include:
     * 'Large'.
     */
    @JsonProperty(value = "details.max_product_capacity", required = true)
    private String maxProductCapacity;

    /**
     * URL value.
     */
    @JsonProperty(value = "details.max_product_image.@odata\\.value")
    private String odatavalue;

    /**
     * Creates an instance of SimpleProduct class.
     */
    public SimpleProduct() {
        maxProductCapacity = "Large";
    }

    /**
     * Get the maxProductDisplayName value.
     *
     * @return the maxProductDisplayName value
     */
    public String getMaxProductDisplayName() {
        return this.maxProductDisplayName;
    }

    /**
     * Set the maxProductDisplayName value.
     *
     * @param maxProductDisplayName the maxProductDisplayName value to set
     */
    public void setMaxProductDisplayName(String maxProductDisplayName) {
        this.maxProductDisplayName = maxProductDisplayName;
    }

    /**
     * Get the maxProductCapacity value.
     *
     * @return the maxProductCapacity value
     */
    public String getMaxProductCapacity() {
        return this.maxProductCapacity;
    }

    /**
     * Set the maxProductCapacity value.
     *
     * @param maxProductCapacity the maxProductCapacity value to set
     */
    public void setMaxProductCapacity(String maxProductCapacity) {
        this.maxProductCapacity = maxProductCapacity;
    }

    /**
     * Get the odatavalue value.
     *
     * @return the odatavalue value
     */
    public String getOdatavalue() {
        return this.odatavalue;
    }

    /**
     * Set the odatavalue value.
     *
     * @param odatavalue the odatavalue value to set
     */
    public void setOdatavalue(String odatavalue) {
        this.odatavalue = odatavalue;
    }

}
