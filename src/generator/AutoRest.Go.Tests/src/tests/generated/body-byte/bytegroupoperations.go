package bytegroup

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
    "github.com/Azure/go-autorest/autorest/validation"
    "net/http"
)

// OperationsClient is the test Infrastructure for AutoRest Swagger BAT
type OperationsClient struct {
    ManagementClient
}
// NewOperationsClient creates an instance of the OperationsClient client.
func NewOperationsClient() OperationsClient {
    return NewOperationsClientWithBaseURI(DefaultBaseURI, )
}

// NewOperationsClientWithBaseURI creates an instance of the OperationsClient
// client.
func NewOperationsClientWithBaseURI(baseURI string, ) OperationsClient {
    return OperationsClient{NewWithBaseURI(baseURI, )}
}

// GetEmpty get empty byte value ''
func (client OperationsClient) GetEmpty() (result ByteArray, err error) {
    req, err := client.GetEmptyPreparer()
    if err != nil {
        return result, autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "GetEmpty", nil , "Failure preparing request")
    }

    resp, err := client.GetEmptySender(req)
    if err != nil {
        result.Response = autorest.Response{Response: resp}
        return result, autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "GetEmpty", resp, "Failure sending request")
    }

    result, err = client.GetEmptyResponder(resp)
    if err != nil {
        err = autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "GetEmpty", resp, "Failure responding to request")
    }

    return
}

// GetEmptyPreparer prepares the GetEmpty request.
func (client OperationsClient) GetEmptyPreparer() (*http.Request, error) {
    preparer := autorest.CreatePreparer(
                        autorest.AsGet(),
                        autorest.WithBaseURL(client.BaseURI),
                        autorest.WithPath("/byte/empty"))
    return preparer.Prepare(&http.Request{})
}

// GetEmptySender sends the GetEmpty request. The method will close the
// http.Response Body if it receives an error.
func (client OperationsClient) GetEmptySender(req *http.Request) (*http.Response, error) {
    return autorest.SendWithSender(client, req)
}

// GetEmptyResponder handles the response to the GetEmpty request. The method always
// closes the http.Response Body.
func (client OperationsClient) GetEmptyResponder(resp *http.Response) (result ByteArray, err error) { 
    err = autorest.Respond(
            resp,
            client.ByInspecting(),
            azure.WithErrorUnlessStatusCode(http.StatusOK),
            autorest.ByUnmarshallingJSON(&result.Value),
            autorest.ByClosing())
    result.Response = autorest.Response{Response: resp}
    return
}

// GetInvalid get invalid byte value ':::SWAGGER::::'
func (client OperationsClient) GetInvalid() (result ByteArray, err error) {
    req, err := client.GetInvalidPreparer()
    if err != nil {
        return result, autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "GetInvalid", nil , "Failure preparing request")
    }

    resp, err := client.GetInvalidSender(req)
    if err != nil {
        result.Response = autorest.Response{Response: resp}
        return result, autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "GetInvalid", resp, "Failure sending request")
    }

    result, err = client.GetInvalidResponder(resp)
    if err != nil {
        err = autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "GetInvalid", resp, "Failure responding to request")
    }

    return
}

// GetInvalidPreparer prepares the GetInvalid request.
func (client OperationsClient) GetInvalidPreparer() (*http.Request, error) {
    preparer := autorest.CreatePreparer(
                        autorest.AsGet(),
                        autorest.WithBaseURL(client.BaseURI),
                        autorest.WithPath("/byte/invalid"))
    return preparer.Prepare(&http.Request{})
}

// GetInvalidSender sends the GetInvalid request. The method will close the
// http.Response Body if it receives an error.
func (client OperationsClient) GetInvalidSender(req *http.Request) (*http.Response, error) {
    return autorest.SendWithSender(client, req)
}

// GetInvalidResponder handles the response to the GetInvalid request. The method always
// closes the http.Response Body.
func (client OperationsClient) GetInvalidResponder(resp *http.Response) (result ByteArray, err error) { 
    err = autorest.Respond(
            resp,
            client.ByInspecting(),
            azure.WithErrorUnlessStatusCode(http.StatusOK),
            autorest.ByUnmarshallingJSON(&result.Value),
            autorest.ByClosing())
    result.Response = autorest.Response{Response: resp}
    return
}

// GetNonASCII get non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
func (client OperationsClient) GetNonASCII() (result ByteArray, err error) {
    req, err := client.GetNonASCIIPreparer()
    if err != nil {
        return result, autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "GetNonASCII", nil , "Failure preparing request")
    }

    resp, err := client.GetNonASCIISender(req)
    if err != nil {
        result.Response = autorest.Response{Response: resp}
        return result, autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "GetNonASCII", resp, "Failure sending request")
    }

    result, err = client.GetNonASCIIResponder(resp)
    if err != nil {
        err = autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "GetNonASCII", resp, "Failure responding to request")
    }

    return
}

// GetNonASCIIPreparer prepares the GetNonASCII request.
func (client OperationsClient) GetNonASCIIPreparer() (*http.Request, error) {
    preparer := autorest.CreatePreparer(
                        autorest.AsGet(),
                        autorest.WithBaseURL(client.BaseURI),
                        autorest.WithPath("/byte/nonAscii"))
    return preparer.Prepare(&http.Request{})
}

// GetNonASCIISender sends the GetNonASCII request. The method will close the
// http.Response Body if it receives an error.
func (client OperationsClient) GetNonASCIISender(req *http.Request) (*http.Response, error) {
    return autorest.SendWithSender(client, req)
}

// GetNonASCIIResponder handles the response to the GetNonASCII request. The method always
// closes the http.Response Body.
func (client OperationsClient) GetNonASCIIResponder(resp *http.Response) (result ByteArray, err error) { 
    err = autorest.Respond(
            resp,
            client.ByInspecting(),
            azure.WithErrorUnlessStatusCode(http.StatusOK),
            autorest.ByUnmarshallingJSON(&result.Value),
            autorest.ByClosing())
    result.Response = autorest.Response{Response: resp}
    return
}

// GetNull get null byte value
func (client OperationsClient) GetNull() (result ByteArray, err error) {
    req, err := client.GetNullPreparer()
    if err != nil {
        return result, autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "GetNull", nil , "Failure preparing request")
    }

    resp, err := client.GetNullSender(req)
    if err != nil {
        result.Response = autorest.Response{Response: resp}
        return result, autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "GetNull", resp, "Failure sending request")
    }

    result, err = client.GetNullResponder(resp)
    if err != nil {
        err = autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "GetNull", resp, "Failure responding to request")
    }

    return
}

// GetNullPreparer prepares the GetNull request.
func (client OperationsClient) GetNullPreparer() (*http.Request, error) {
    preparer := autorest.CreatePreparer(
                        autorest.AsGet(),
                        autorest.WithBaseURL(client.BaseURI),
                        autorest.WithPath("/byte/null"))
    return preparer.Prepare(&http.Request{})
}

// GetNullSender sends the GetNull request. The method will close the
// http.Response Body if it receives an error.
func (client OperationsClient) GetNullSender(req *http.Request) (*http.Response, error) {
    return autorest.SendWithSender(client, req)
}

// GetNullResponder handles the response to the GetNull request. The method always
// closes the http.Response Body.
func (client OperationsClient) GetNullResponder(resp *http.Response) (result ByteArray, err error) { 
    err = autorest.Respond(
            resp,
            client.ByInspecting(),
            azure.WithErrorUnlessStatusCode(http.StatusOK),
            autorest.ByUnmarshallingJSON(&result.Value),
            autorest.ByClosing())
    result.Response = autorest.Response{Response: resp}
    return
}

// PutNonASCII put non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
//
// byteBody is base64-encoded non-ascii byte string hex(FF FE FD FC FB FA F9
// F8 F7 F6)
func (client OperationsClient) PutNonASCII(byteBody []byte) (result autorest.Response, err error) {
    if err := validation.Validate([]validation.Validation{
         {byteBody,
         []validation.Constraint{	{"byteBody", validation.Null, true, nil }}}}); err != nil {
             return result, autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "PutNonASCII", nil , "Validation error ")
    }

    req, err := client.PutNonASCIIPreparer(byteBody)
    if err != nil {
        return result, autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "PutNonASCII", nil , "Failure preparing request")
    }

    resp, err := client.PutNonASCIISender(req)
    if err != nil {
        result.Response = resp
        return result, autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "PutNonASCII", resp, "Failure sending request")
    }

    result, err = client.PutNonASCIIResponder(resp)
    if err != nil {
        err = autorest.NewErrorWithError(err, "bytegroup.OperationsClient", "PutNonASCII", resp, "Failure responding to request")
    }

    return
}

// PutNonASCIIPreparer prepares the PutNonASCII request.
func (client OperationsClient) PutNonASCIIPreparer(byteBody []byte) (*http.Request, error) {
    preparer := autorest.CreatePreparer(
                        autorest.AsJSON(),
                        autorest.AsPut(),
                        autorest.WithBaseURL(client.BaseURI),
                        autorest.WithPath("/byte/nonAscii"),
                        autorest.WithJSON(byteBody))
    return preparer.Prepare(&http.Request{})
}

// PutNonASCIISender sends the PutNonASCII request. The method will close the
// http.Response Body if it receives an error.
func (client OperationsClient) PutNonASCIISender(req *http.Request) (*http.Response, error) {
    return autorest.SendWithSender(client, req)
}

// PutNonASCIIResponder handles the response to the PutNonASCII request. The method always
// closes the http.Response Body.
func (client OperationsClient) PutNonASCIIResponder(resp *http.Response) (result autorest.Response, err error) { 
    err = autorest.Respond(
            resp,
            client.ByInspecting(),
            azure.WithErrorUnlessStatusCode(http.StatusOK),
            autorest.ByClosing())
    result.Response = resp
    return
}

