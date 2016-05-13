/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.requiredoptional.models;


/**
 * The ClassOptionalWrapper model.
 */
public class ClassOptionalWrapper {
    /**
     * The value property.
     */
    private Product value;

    /**
     * Get the value value.
     *
     * @return the value value
     */
    public Product value() {
        return this.value;
    }

    /**
     * Set the value value.
     *
     * @param value the value value to set
     * @return the ClassOptionalWrapper object itself.
     */
    public ClassOptionalWrapper setValue(Product value) {
        this.value = value;
        return this;
    }

}
