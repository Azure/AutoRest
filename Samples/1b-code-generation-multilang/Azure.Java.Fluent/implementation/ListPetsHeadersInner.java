/**
 * Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package petstore.implementation;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Defines headers for listPets operation.
 */
public class ListPetsHeadersInner {
    /**
     * A link to the next page of responses.
     */
    @JsonProperty(value = "x-next")
    private String xNext;

    /**
     * Get the xNext value.
     *
     * @return the xNext value
     */
    public String xNext() {
        return this.xNext;
    }

    /**
     * Set the xNext value.
     *
     * @param xNext the xNext value to set
     * @return the ListPetsHeadersInner object itself.
     */
    public ListPetsHeadersInner withXNext(String xNext) {
        this.xNext = xNext;
        return this;
    }

}
