package

// Code generated by Microsoft (R) AutoRest Code Generator 1.2.0.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

import (
    "github.com/Azure/go-autorest/autorest"
)

// ErrorType is
type ErrorType struct {
    Code *int32 `json:"code,omitempty"`
    Message *string `json:"message,omitempty"`
}

// ListPetType is
type ListPetType struct {
    autorest.Response `json:"-"`
    Value *[]PetType `json:"value,omitempty"`
}

// PetType is
type PetType struct {
    ID *int64 `json:"id,omitempty"`
    Name *string `json:"name,omitempty"`
    Tag *string `json:"tag,omitempty"`
}

