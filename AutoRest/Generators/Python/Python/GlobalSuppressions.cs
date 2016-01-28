﻿// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.ServiceClientTemplateModel.#ModelTemplateModels", Justification="Using another type would add unneeded complexity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.MethodGroupTemplateModel.#MethodTemplateModels", Justification="Using another type would add unneeded complexity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#ParameterTemplateModels", Justification="Using another type would add unneeded complexity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.ServiceClientTemplateModel.#MethodTemplateModels", Justification="Using another type would add unneeded complexity")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", 
    Scope = "namespace", Target = "Microsoft.Rest.Generator.Python.TemplateModels", Justification = "Parallel with other generators")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", 
    Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String)", Justification="Code simplification")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", 
    Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#DeserializeType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String)", Justification="Code simplification")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", 
    Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#GetDeserializationString(Microsoft.Rest.Generator.ClientModel.IType,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", 
    MessageId = "0#", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#RemoveDuplicateForwardSlashes(System.String)", Justification="Uri will not pass uri validation")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings", 
    Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#BuildUrl(System.String)", Justification="Uri will not pass uri validation")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", 
    MessageId = "1", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#.ctor(Microsoft.Rest.Generator.ClientModel.Method,Microsoft.Rest.Generator.ClientModel.ServiceClient)", Justification="Validated by LoadFrom method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", 
    MessageId = "0", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#.ctor(Microsoft.Rest.Generator.ClientModel.Method,Microsoft.Rest.Generator.ClientModel.ServiceClient)", Justification="Validated by LoadFrom method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", 
    MessageId = "0", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.ModelTemplateModel.#.ctor(Microsoft.Rest.Generator.ClientModel.CompositeType,Microsoft.Rest.Generator.ClientModel.ServiceClient)", Justification="Validated by LoadFrom method")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", 
    "CA1303:Do not pass literals as localized parameters", 
    MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#DeserializeType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String)", Justification="Literal string is generated code, no localization concerns")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", 
    "CA1303:Do not pass literals as localized parameters", 
    MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateRequiredType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String)", Justification="Literal string is generated code, no localization concerns")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", 
    "CA1303:Do not pass literals as localized parameters", 
    MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String)", Justification="Literal string is generated code, no localization concerns")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", 
    "CA1303:Do not pass literals as localized parameters", 
    MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#GetDeserializationString(Microsoft.Rest.Generator.ClientModel.IType,System.String)", Justification="Literal string is generated code, no localization concerns")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", 
    "CA1303:Do not pass literals as localized parameters", 
    MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.ServiceClientTemplateModel.#PolymorphicDictionary", Justification="Literal string is generated code, no localization concerns")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", 
    "CA1303:Do not pass literals as localized parameters", 
    MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#BuildUrl(System.String)", Justification="Literal string is generated code, no localization concerns")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", 
    "CA1303:Do not pass literals as localized parameters", 
    MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#RemoveDuplicateForwardSlashes(System.String)", Justification="Literal string is generated code, no localization concerns")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.Append(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.ServiceClientTemplateModel.#PolymorphicDictionary", Justification="Literal string is generated code, no localization concerns")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", 
    Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String)", Justification="Node conventions require lower casing")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", 
    Scope = "member", 
    Target = "Microsoft.Rest.Generator.Python.ModelTemplateModel.#isSpecial(Microsoft.Rest.Generator.ClientModel.IType)", Justification="False Positive")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", 
    MessageId = "gi", Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#RemoveDuplicateForwardSlashes(System.String)", Justification="Generated code parameters to regular expression")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#AddQueryParametersToUrl(System.String,Microsoft.Rest.Generator.Utilities.IndentedStringBuilder)", Justification="Literal string is generated code, no localization concerns.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#BuildQueryParameterArray(Microsoft.Rest.Generator.Utilities.IndentedStringBuilder)", Justification="Literal string is generated code, no localization concerns.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "QueryParameters", Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#HasQueryParameters()", Justification="False Positive")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1703:ResourceStringsShouldBeSpelledCorrectly", MessageId = "ms-rest", Scope = "resource", Target = "Microsoft.Rest.Generator.Python.Properties.Resources.resources", Justification="ms-rest is a valid npm package name")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.Append(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "isArray", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "util", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "isDuration", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidatePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ConstructValidationCheck(System.String,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ConstructValidationCheck(System.String,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "instanceof", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidatePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidatePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "valueOf", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidatePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "typeof", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidatePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateDictionaryType(Microsoft.Rest.Generator.ClientModel.DictionaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateDictionaryType(Microsoft.Rest.Generator.ClientModel.DictionaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateSequenceType(Microsoft.Rest.Generator.ClientModel.SequenceType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateSequenceType(Microsoft.Rest.Generator.ClientModel.SequenceType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.Append(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateCompositeType(Microsoft.Rest.Generator.ClientModel.CompositeType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateCompositeType(Microsoft.Rest.Generator.ClientModel.CompositeType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.Append(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateEnumType(Microsoft.Rest.Generator.ClientModel.EnumType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateEnumType(Microsoft.Rest.Generator.ClientModel.EnumType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "isNaN", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidatePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidatePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "isNaN", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidatePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "valueOf", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidatePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "typeof", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidatePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "instanceof", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidatePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateEnumType(Microsoft.Rest.Generator.ClientModel.EnumType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.Append(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateEnumType(Microsoft.Rest.Generator.ClientModel.EnumType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ConstructValidationCheck(Microsoft.Rest.Generator.Utilities.IndentedStringBuilder,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ConstructValidationCheck(Microsoft.Rest.Generator.Utilities.IndentedStringBuilder,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidatePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#SerializePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#SerializePrimaryType(Microsoft.Rest.Generator.ClientModel.PrimaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ConstructBasePropertyCheck(Microsoft.Rest.Generator.Utilities.IndentedStringBuilder,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#SerializeEnumType(Microsoft.Rest.Generator.ClientModel.EnumType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.Append(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#SerializeEnumType(Microsoft.Rest.Generator.ClientModel.EnumType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#SerializeCompositeType(Microsoft.Rest.Generator.ClientModel.CompositeType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.Append(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#SerializeCompositeType(Microsoft.Rest.Generator.ClientModel.CompositeType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#SerializeSequenceType(Microsoft.Rest.Generator.ClientModel.SequenceType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#SerializeDictionaryType(Microsoft.Rest.Generator.ClientModel.DictionaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#SerializeDictionaryType(Microsoft.Rest.Generator.ClientModel.DictionaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#SerializeType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#DeserializeType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#DeserializeType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#InitializeType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#InitializeSerializationType(Microsoft.Rest.Generator.ClientModel.IType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ProcessBasicType(System.String,System.String,Microsoft.Rest.Generator.Utilities.IndentedStringBuilder)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ProcessCompositeType(Microsoft.Rest.Generator.ClientModel.CompositeType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.String,Microsoft.Rest.Generator.Utilities.IndentedStringBuilder,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ProcessSequenceType(Microsoft.Rest.Generator.ClientModel.SequenceType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.String,Microsoft.Rest.Generator.Utilities.IndentedStringBuilder,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ProcessDictionaryType(Microsoft.Rest.Generator.ClientModel.DictionaryType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.String,Microsoft.Rest.Generator.Utilities.IndentedStringBuilder,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#InitializeResponseBody(Microsoft.Rest.Generator.ClientModel.IType)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#ConstructParameterDocumentation(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#GetDeserializationString(Microsoft.Rest.Generator.ClientModel.IType,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#GetDeserializationString(Microsoft.Rest.Generator.ClientModel.IType,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#GetValidationString()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#DeserializeResponse(Microsoft.Rest.Generator.ClientModel.IType,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#DeserializeResponse(Microsoft.Rest.Generator.ClientModel.IType,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.ModelTemplateModel.#ConstructPropertyDocumentation(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#SerializeSequenceType(Microsoft.Rest.Generator.ClientModel.SequenceType,Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.String,System.Boolean,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ProcessCompositeType(Microsoft.Rest.Generator.ClientModel.CompositeType,System.String,System.String,System.String,Microsoft.Rest.Generator.Utilities.IndentedStringBuilder,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.MethodTemplateModel.#ValidationString")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.IndentedStringBuilder.AppendLine(System.String)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.TemplateModels.ClientModelExtensions.#ValidateCompositeType(Microsoft.Rest.Generator.Python.IScopeProvider,System.String,System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Microsoft.Rest.Generator.Python.ModelTemplateModel.#isSpecial(Microsoft.Rest.Generator.ClientModel.IType)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "PolymorphicDiscriminator", Scope = "member", Target = "Microsoft.Rest.Generator.Python.ModelTemplateModel.#GetPolymorphicDiscriminator()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "Microsoft.Rest.Generator.Utilities.Extensions.WordWrap(System.String,System.Int32)", Scope = "member", Target = "Microsoft.Rest.Generator.Python.PythonTemplate`1.#ParameterWrapComment(System.String,System.String)")]
