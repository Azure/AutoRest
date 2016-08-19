package complexgroup

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

import (
    "github.com/Azure/go-autorest/autorest"
    "github.com/Azure/go-autorest/autorest/azure"
    "net/http"
)

// BasicOperationsClient is the test Infrastructure for AutoRest
type BasicOperationsClient struct {
    ManagementClient
}
// NewBasicOperationsClient creates an instance of the BasicOperationsClient
// client.
func NewBasicOperationsClient() BasicOperationsClient {
    return NewBasicOperationsClientWithBaseURI(DefaultBaseURI, )
}

// NewBasicOperationsClientWithBaseURI creates an instance of the
// BasicOperationsClient client.
func NewBasicOperationsClientWithBaseURI(baseURI string, ) BasicOperationsClient {
    return BasicOperationsClient{NewWithBaseURI(baseURI, )}
}

// GetEmpty get a basic complex type that is empty
func (client BasicOperationsClient) GetEmpty() (result Basic, err error) {
    req, err := client.GetEmptyPreparer()
    if err != nil {
        return result, autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetEmpty", nil , "Failure preparing request")
    }

    resp, err := client.GetEmptySender(req)
    if err != nil {
        result.Response = autorest.Response{Response: resp}
        return result, autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetEmpty", resp, "Failure sending request")
    }

    result, err = client.GetEmptyResponder(resp)
    if err != nil {
        err = autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetEmpty", resp, "Failure responding to request")
    }

    return
}

// GetEmptyPreparer prepares the GetEmpty request.
func (client BasicOperationsClient) GetEmptyPreparer() (*http.Request, error) {
    preparer := autorest.CreatePreparer(
                        autorest.AsGet(),
                        autorest.WithBaseURL(client.BaseURI),
                        autorest.WithPath("/complex/basic/empty"))
    return preparer.Prepare(&http.Request{})
}

// GetEmptySender sends the GetEmpty request. The method will close the
// http.Response Body if it receives an error.
func (client BasicOperationsClient) GetEmptySender(req *http.Request) (*http.Response, error) {
    return autorest.SendWithSender(client, req)
}

// GetEmptyResponder handles the response to the GetEmpty request. The method always
// closes the http.Response Body.
func (client BasicOperationsClient) GetEmptyResponder(resp *http.Response) (result Basic, err error) { 
    err = autorest.Respond(
            resp,
            client.ByInspecting(),
            azure.WithErrorUnlessStatusCode(http.StatusOK),
            autorest.ByUnmarshallingJSON(&result),
            autorest.ByClosing())
    result.Response = autorest.Response{Response: resp}
    return
}

// GetInvalid get a basic complex type that is invalid for the local strong
// type
func (client BasicOperationsClient) GetInvalid() (result Basic, err error) {
    req, err := client.GetInvalidPreparer()
    if err != nil {
        return result, autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetInvalid", nil , "Failure preparing request")
    }

    resp, err := client.GetInvalidSender(req)
    if err != nil {
        result.Response = autorest.Response{Response: resp}
        return result, autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetInvalid", resp, "Failure sending request")
    }

    result, err = client.GetInvalidResponder(resp)
    if err != nil {
        err = autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetInvalid", resp, "Failure responding to request")
    }

    return
}

// GetInvalidPreparer prepares the GetInvalid request.
func (client BasicOperationsClient) GetInvalidPreparer() (*http.Request, error) {
    preparer := autorest.CreatePreparer(
                        autorest.AsGet(),
                        autorest.WithBaseURL(client.BaseURI),
                        autorest.WithPath("/complex/basic/invalid"))
    return preparer.Prepare(&http.Request{})
}

// GetInvalidSender sends the GetInvalid request. The method will close the
// http.Response Body if it receives an error.
func (client BasicOperationsClient) GetInvalidSender(req *http.Request) (*http.Response, error) {
    return autorest.SendWithSender(client, req)
}

// GetInvalidResponder handles the response to the GetInvalid request. The method always
// closes the http.Response Body.
func (client BasicOperationsClient) GetInvalidResponder(resp *http.Response) (result Basic, err error) { 
    err = autorest.Respond(
            resp,
            client.ByInspecting(),
            azure.WithErrorUnlessStatusCode(http.StatusOK),
            autorest.ByUnmarshallingJSON(&result),
            autorest.ByClosing())
    result.Response = autorest.Response{Response: resp}
    return
}

// GetNotProvided get a basic complex type while the server doesn't provide a
// response payload
func (client BasicOperationsClient) GetNotProvided() (result Basic, err error) {
    req, err := client.GetNotProvidedPreparer()
    if err != nil {
        return result, autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetNotProvided", nil , "Failure preparing request")
    }

    resp, err := client.GetNotProvidedSender(req)
    if err != nil {
        result.Response = autorest.Response{Response: resp}
        return result, autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetNotProvided", resp, "Failure sending request")
    }

    result, err = client.GetNotProvidedResponder(resp)
    if err != nil {
        err = autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetNotProvided", resp, "Failure responding to request")
    }

    return
}

// GetNotProvidedPreparer prepares the GetNotProvided request.
func (client BasicOperationsClient) GetNotProvidedPreparer() (*http.Request, error) {
    preparer := autorest.CreatePreparer(
                        autorest.AsGet(),
                        autorest.WithBaseURL(client.BaseURI),
                        autorest.WithPath("/complex/basic/notprovided"))
    return preparer.Prepare(&http.Request{})
}

// GetNotProvidedSender sends the GetNotProvided request. The method will close the
// http.Response Body if it receives an error.
func (client BasicOperationsClient) GetNotProvidedSender(req *http.Request) (*http.Response, error) {
    return autorest.SendWithSender(client, req)
}

// GetNotProvidedResponder handles the response to the GetNotProvided request. The method always
// closes the http.Response Body.
func (client BasicOperationsClient) GetNotProvidedResponder(resp *http.Response) (result Basic, err error) { 
    err = autorest.Respond(
            resp,
            client.ByInspecting(),
            azure.WithErrorUnlessStatusCode(http.StatusOK),
            autorest.ByUnmarshallingJSON(&result),
            autorest.ByClosing())
    result.Response = autorest.Response{Response: resp}
    return
}

// GetNull get a basic complex type whose properties are null
func (client BasicOperationsClient) GetNull() (result Basic, err error) {
    req, err := client.GetNullPreparer()
    if err != nil {
        return result, autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetNull", nil , "Failure preparing request")
    }

    resp, err := client.GetNullSender(req)
    if err != nil {
        result.Response = autorest.Response{Response: resp}
        return result, autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetNull", resp, "Failure sending request")
    }

    result, err = client.GetNullResponder(resp)
    if err != nil {
        err = autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetNull", resp, "Failure responding to request")
    }

    return
}

// GetNullPreparer prepares the GetNull request.
func (client BasicOperationsClient) GetNullPreparer() (*http.Request, error) {
    preparer := autorest.CreatePreparer(
                        autorest.AsGet(),
                        autorest.WithBaseURL(client.BaseURI),
                        autorest.WithPath("/complex/basic/null"))
    return preparer.Prepare(&http.Request{})
}

// GetNullSender sends the GetNull request. The method will close the
// http.Response Body if it receives an error.
func (client BasicOperationsClient) GetNullSender(req *http.Request) (*http.Response, error) {
    return autorest.SendWithSender(client, req)
}

// GetNullResponder handles the response to the GetNull request. The method always
// closes the http.Response Body.
func (client BasicOperationsClient) GetNullResponder(resp *http.Response) (result Basic, err error) { 
    err = autorest.Respond(
            resp,
            client.ByInspecting(),
            azure.WithErrorUnlessStatusCode(http.StatusOK),
            autorest.ByUnmarshallingJSON(&result),
            autorest.ByClosing())
    result.Response = autorest.Response{Response: resp}
    return
}

// GetValid get complex type {id: 2, name: 'abc', color: 'YELLOW'}
func (client BasicOperationsClient) GetValid() (result Basic, err error) {
    req, err := client.GetValidPreparer()
    if err != nil {
        return result, autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetValid", nil , "Failure preparing request")
    }

    resp, err := client.GetValidSender(req)
    if err != nil {
        result.Response = autorest.Response{Response: resp}
        return result, autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetValid", resp, "Failure sending request")
    }

    result, err = client.GetValidResponder(resp)
    if err != nil {
        err = autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "GetValid", resp, "Failure responding to request")
    }

    return
}

// GetValidPreparer prepares the GetValid request.
func (client BasicOperationsClient) GetValidPreparer() (*http.Request, error) {
    preparer := autorest.CreatePreparer(
                        autorest.AsGet(),
                        autorest.WithBaseURL(client.BaseURI),
                        autorest.WithPath("/complex/basic/valid"))
    return preparer.Prepare(&http.Request{})
}

// GetValidSender sends the GetValid request. The method will close the
// http.Response Body if it receives an error.
func (client BasicOperationsClient) GetValidSender(req *http.Request) (*http.Response, error) {
    return autorest.SendWithSender(client, req)
}

// GetValidResponder handles the response to the GetValid request. The method always
// closes the http.Response Body.
func (client BasicOperationsClient) GetValidResponder(resp *http.Response) (result Basic, err error) { 
    err = autorest.Respond(
            resp,
            client.ByInspecting(),
            azure.WithErrorUnlessStatusCode(http.StatusOK),
            autorest.ByUnmarshallingJSON(&result),
            autorest.ByClosing())
    result.Response = autorest.Response{Response: resp}
    return
}

// PutValid please put {id: 2, name: 'abc', color: 'Magenta'}
//
// complexBody is please put {id: 2, name: 'abc', color: 'Magenta'}
func (client BasicOperationsClient) PutValid(complexBody Basic) (result autorest.Response, err error) {
    req, err := client.PutValidPreparer(complexBody)
    if err != nil {
        return result, autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "PutValid", nil , "Failure preparing request")
    }

    resp, err := client.PutValidSender(req)
    if err != nil {
        result.Response = resp
        return result, autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "PutValid", resp, "Failure sending request")
    }

    result, err = client.PutValidResponder(resp)
    if err != nil {
        err = autorest.NewErrorWithError(err, "complexgroup.BasicOperationsClient", "PutValid", resp, "Failure responding to request")
    }

    return
}

// PutValidPreparer prepares the PutValid request.
func (client BasicOperationsClient) PutValidPreparer(complexBody Basic) (*http.Request, error) {
    queryParameters := map[string]interface{} {
    "api-version": client.APIVersion,
    }

    preparer := autorest.CreatePreparer(
                        autorest.AsJSON(),
                        autorest.AsPut(),
                        autorest.WithBaseURL(client.BaseURI),
                        autorest.WithPath("/complex/basic/valid"),
                        autorest.WithJSON(complexBody),
                        autorest.WithQueryParameters(queryParameters))
    return preparer.Prepare(&http.Request{})
}

// PutValidSender sends the PutValid request. The method will close the
// http.Response Body if it receives an error.
func (client BasicOperationsClient) PutValidSender(req *http.Request) (*http.Response, error) {
    return autorest.SendWithSender(client, req)
}

// PutValidResponder handles the response to the PutValid request. The method always
// closes the http.Response Body.
func (client BasicOperationsClient) PutValidResponder(resp *http.Response) (result autorest.Response, err error) { 
    err = autorest.Respond(
            resp,
            client.ByInspecting(),
            azure.WithErrorUnlessStatusCode(http.StatusOK),
            autorest.ByClosing())
    result.Response = resp
    return
}

