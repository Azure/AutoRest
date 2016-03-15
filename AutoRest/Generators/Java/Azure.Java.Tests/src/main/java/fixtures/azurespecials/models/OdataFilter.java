/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.azurespecials.models;


/**
 * The OdataFilter model.
 */
public class OdataFilter {
    /**
     * The id property.
     */
    private Integer id;

    /**
     * The name property.
     */
    private String name;

    /**
     * Get the id value.
     *
     * @return the id value
     */
    public Integer getId() {
        return this.id;
    }

    /**
     * Set the id value.
     *
     * @param id the id value to set
     */
    public void setId(Integer id) {
        this.id = id;
    }

    /**
     * Set the id value.
     *
     * @param id the id value to set
     * @return the OdataFilter object itself.
     */
    public OdataFilter withId(Integer id) {
        this.id = id;
        return this;
    }

    /**
     * Get the name value.
     *
     * @return the name value
     */
    public String getName() {
        return this.name;
    }

    /**
     * Set the name value.
     *
     * @param name the name value to set
     */
    public void setName(String name) {
        this.name = name;
    }

    /**
     * Set the name value.
     *
     * @param name the name value to set
     * @return the OdataFilter object itself.
     */
    public OdataFilter withName(String name) {
        this.name = name;
        return this;
    }

}
