/**
 * Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package javanamespace.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * The Pet model.
 */
public class Pet {
    /**
     * The id property.
     */
    @JsonProperty(value = "id", required = true)
    private long id;

    /**
     * The name property.
     */
    @JsonProperty(value = "name", required = true)
    private String name;

    /**
     * The tag property.
     */
    @JsonProperty(value = "tag")
    private String tag;

    /**
     * Get the id value.
     *
     * @return the id value
     */
    public long id() {
        return this.id;
    }

    /**
     * Set the id value.
     *
     * @param id the id value to set
     * @return the Pet object itself.
     */
    public Pet withId(long id) {
        this.id = id;
        return this;
    }

    /**
     * Get the name value.
     *
     * @return the name value
     */
    public String name() {
        return this.name;
    }

    /**
     * Set the name value.
     *
     * @param name the name value to set
     * @return the Pet object itself.
     */
    public Pet withName(String name) {
        this.name = name;
        return this;
    }

    /**
     * Get the tag value.
     *
     * @return the tag value
     */
    public String tag() {
        return this.tag;
    }

    /**
     * Set the tag value.
     *
     * @param tag the tag value to set
     * @return the Pet object itself.
     */
    public Pet withTag(String tag) {
        this.tag = tag;
        return this;
    }

}
