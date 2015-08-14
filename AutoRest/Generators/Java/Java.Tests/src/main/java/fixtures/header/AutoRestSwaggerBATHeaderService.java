// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.


package fixtures.header;

/**
 * The interface for AutoRestSwaggerBATHeaderService class.
 */
public interface AutoRestSwaggerBATHeaderService {
    /**
     * Gets the URI used as the base for all cloud service requests.
     * @return The BaseUri value.
     */
    String getBaseUri();

    /**
     * Gets the HeaderOperations object to access its operations.
     * @return the headerOperations value.
     */
    HeaderOperations getHeaderOperations();
}
