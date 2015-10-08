/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 * 
 * Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package fixtures.url.models;

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;

/**
 * Defines values for UriColor.
 */
public enum UriColor {
    RED_COLOR("red color"),

    GREEN_COLOR("green color"),

    BLUE_COLOR("blue color");

    private String value;

    private UriColor(String value) {
        this.value = value;
    }

    @JsonValue
    public String toValue() {
        return this.value;
    }

    @JsonCreator
    public static UriColor fromValue(String value) {
        UriColor[] items = UriColor.values();
        for (UriColor item : items) {
            if (item.toValue().equals(value)) {
                return item;
            }
        }
        return null;
    }
}
