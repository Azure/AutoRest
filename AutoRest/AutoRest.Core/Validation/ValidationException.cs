﻿namespace Microsoft.Rest.Generator
{
    public enum ValidationExceptionName
    {
        None = 0,
        DescriptionRequired,
        OnlyJsonInResponse,
        OnlyJsonInRequest,
        RequiredPropertiesMustExist,
        OnlyOneBodyParameterAllowed,
        BodyMustHaveSchema,
        BodyMustNotHaveType,
        HeaderShouldHaveClientName,
        InvalidSchemaParameter,
        AResponseMustBeDefined,
        ClientNameMustNotBeEmpty,
        DefaultMustAppearInEnum,
        RefsMustNotHaveSiblings,
        PathParametersMustBeDefined,
        FormatMustExist,
        AnonymousTypesDiscouraged,
        OnlyOneUnderscoreInOperationId,
    }
}