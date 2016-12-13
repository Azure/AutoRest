﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using AutoRest.Core;
using AutoRest.Core.Utilities;
using AutoRest.Extensions;
using AutoRest.Core.Model;
using Newtonsoft.Json;

namespace AutoRest.Java.Model
{
    public class MethodJv : Method
    {
        public virtual IEnumerable<ParameterJv> RetrofitParameters
        {
            get
            {
                var parameters = LogicalParameters.OfType<ParameterJv>().Where(p => p.Location != ParameterLocation.None)
                    .Where(p => !p.Extensions.ContainsKey("hostParameter")).ToList();
                if (IsParameterizedHost)
                {
                    parameters.Add(new ParameterJv
                    {
                        Name = "parameterizedHost",
                        SerializedName = "x-ms-parameterized-host",
                        Location = ParameterLocation.Header,
                        IsRequired = true,
                        ModelType = new PrimaryTypeJv(KnownPrimaryType.String)
                    });
                }
                return parameters;
            }
        }

        public IEnumerable<ParameterJv> OrderedRetrofitParameters
        {
            get
            {
                return RetrofitParameters.Where(p => p.Location == ParameterLocation.Path)
                    .Union(RetrofitParameters.Where(p => p.Location != ParameterLocation.Path));
            }
        }

        /// <summary>
        /// Generate the method parameter declarations for a method
        /// </summary>
        public virtual string MethodParameterApiDeclaration
        {
            get
            {
                List<string> declarations = new List<string>();
                foreach (ParameterJv parameter in OrderedRetrofitParameters)
                {
                    StringBuilder declarationBuilder = new StringBuilder();
                    if (Url.Contains("{" + parameter.Name + "}"))
                    {
                        parameter.Location = ParameterLocation.Path;
                    }
                    if (parameter.Location == ParameterLocation.Path ||
                        parameter.Location == ParameterLocation.Query ||
                        parameter.Location == ParameterLocation.Header)
                    {
                        declarationBuilder.Append(string.Format(CultureInfo.InvariantCulture,
                            "@{0}(\"{1}\") ",
                            parameter.Location.ToString(),
                            parameter.SerializedName));
                    }
                    else if (parameter.Location == ParameterLocation.Body)
                    {
                        declarationBuilder.Append(string.Format(CultureInfo.InvariantCulture,
                            "@{0} ",
                            parameter.Location.ToString()));
                    }
                    else if (parameter.Location == ParameterLocation.FormData)
                    {
                        declarationBuilder.Append(string.Format(CultureInfo.InvariantCulture,
                            "@Part(\"{0}\") ",
                            parameter.SerializedName));
                    }
                    var declarativeName = parameter.ClientProperty != null ? parameter.ClientProperty.Name : parameter.Name;
                    declarationBuilder.Append(parameter.WireType.Name);
                    declarationBuilder.Append(" " + declarativeName);
                    declarations.Add(declarationBuilder.ToString());
                }

                var declaration = string.Join(", ", declarations);
                return declaration;
            }
        }

        public virtual string MethodParameterDeclaration
        {
            get
            {
                List<string> declarations = new List<string>();
                foreach (var parameter in LocalParameters.Where(p => !p.IsConstant))
                {
                    declarations.Add(parameter.ClientType.Name + " " + parameter.Name);
                }

                var declaration = string.Join(", ", declarations);
                return declaration;
            }
        }

        public virtual string MethodRequiredParameterDeclaration
        {
            get
            {
                List<string> declarations = new List<string>();
                foreach (var parameter in LocalParameters.Where(p => !p.IsConstant && p.IsRequired))
                {
                    declarations.Add(parameter.ClientType.Name + " " + parameter.Name);
                }

                var declaration = string.Join(", ", declarations);
                return declaration;
            }
        }

        public string MethodParameterInvocation
        {
            get
            {
                List<string> invocations = new List<string>();
                foreach (var parameter in LocalParameters.Where(p => !p.IsConstant))
                {
                    invocations.Add(parameter.Name);
                }

                var declaration = string.Join(", ", invocations);
                return declaration;
            }
        }

        public string MethodDefaultParameterInvocation
        {
            get
            {
                List<string> invocations = new List<string>();
                foreach (var parameter in LocalParameters)
                {
                    if (parameter.IsRequired)
                    {
                        invocations.Add(parameter.Name);
                    }
                    else
                    {
                        invocations.Add("null");
                    }
                }

                var declaration = string.Join(", ", invocations);
                return declaration;
            }
        }

        public string MethodRequiredParameterInvocation
        {
            get
            {
                List<string> invocations = new List<string>();
                foreach (var parameter in LocalParameters)
                {
                    if (parameter.IsRequired && !parameter.IsConstant)
                    {
                        invocations.Add(parameter.Name);
                    }
                }

                var declaration = string.Join(", ", invocations);
                return declaration;
            }
        }

        public string MethodParameterApiInvocation
        {
            get
            {
                List<string> invocations = new List<string>();
                foreach (var parameter in OrderedRetrofitParameters)
                {
                    invocations.Add(parameter.WireName);
                }

                var declaration = string.Join(", ", invocations);
                return declaration;
            }
        }

        public string MethodRequiredParameterApiInvocation
        {
            get
            {
                List<string> invocations = new List<string>();
                foreach (var parameter in OrderedRetrofitParameters)
                {
                    invocations.Add(parameter.WireName);
                }

                var declaration = string.Join(", ", invocations);
                return declaration;
            }
        }

        public virtual bool IsParameterizedHost => Extensions.ContainsKey(SwaggerExtensions.ParameterizedHostExtension);
        
        /// <summary>
        /// Generate a reference to the ServiceClient
        /// </summary>
        [JsonIgnore]
        public string ClientReference => Group.IsNullOrEmpty() ? "this" : "this.Client";

        public string ParameterConversion
        {
            get
            {
                IndentedStringBuilder builder = new IndentedStringBuilder();
                foreach (var p in RetrofitParameters)
                {
                    if (p.NeedsConversion)
                    {
                        builder.Append(p.ConvertToWireType(p.Name, ClientReference));
                    }
                }
                return builder.ToString();
            }
        }

        public string RequiredParameterConversion
        {
            get
            {
                IndentedStringBuilder builder = new IndentedStringBuilder();
                foreach (var p in RetrofitParameters.Where(p => p.IsRequired))
                {
                    if (p.NeedsConversion)
                    {
                        builder.Append(p.ConvertToWireType(p.Name, ClientReference));
                    }
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// Generates input mapping code block.
        /// </summary>
        /// <returns></returns>
        public virtual string BuildInputMappings(bool filterRequired = false)
        {
            var builder = new IndentedStringBuilder();
            foreach (var transformation in InputParameterTransformation)
            {
                var nullCheck = BuildNullCheckExpression(transformation);
                bool conditionalAssignment = !string.IsNullOrEmpty(nullCheck) && !transformation.OutputParameter.IsRequired && !filterRequired;
                if (conditionalAssignment)
                {
                    builder.AppendLine("{0} {1} = null;",
                            ((ParameterJv) transformation.OutputParameter).ClientType.Name,
                            transformation.OutputParameter.Name);
                    builder.AppendLine("if ({0}) {{", nullCheck).Indent();
                }

                if (transformation.ParameterMappings.Any(m => !string.IsNullOrEmpty(m.OutputParameterProperty)) &&
                    transformation.OutputParameter.ModelType is CompositeType)
                {
                    builder.AppendLine("{0}{1} = new {2}();",
                        !conditionalAssignment ? ((ParameterJv)transformation.OutputParameter).ClientType + " " : "",
                        transformation.OutputParameter.Name,
                        transformation.OutputParameter.ModelType.Name);
                }

                foreach (var mapping in transformation.ParameterMappings)
                {
                    builder.AppendLine("{0}{1}{2};",
                        !conditionalAssignment && !(transformation.OutputParameter.ModelType is CompositeType) ?
                            ((ParameterJv)transformation.OutputParameter).ClientType.Name + " " : "",
                        transformation.OutputParameter.Name,
                        GetMapping(mapping, filterRequired));
                }

                if (conditionalAssignment)
                {
                    builder.Outdent()
                       .AppendLine("}");
                }
            }

            return builder.ToString();
        }

        private static string GetMapping(ParameterMapping mapping, bool filterRequired = false)
        {
            string inputPath = mapping.InputParameter.Name;
            if (mapping.InputParameterProperty != null)
            {
                inputPath += "." + CodeNamer.Instance.CamelCase(mapping.InputParameterProperty) + "()";
            }
            if (filterRequired && !mapping.InputParameter.IsRequired)
            {
                inputPath = "null";
            }

            string outputPath = "";
            if (mapping.OutputParameterProperty != null)
            {
                outputPath += ".with" + CodeNamer.Instance.PascalCase(mapping.OutputParameterProperty);
                return string.Format(CultureInfo.InvariantCulture, "{0}({1})", outputPath, inputPath);
            }
            else
            {
                return string.Format(CultureInfo.InvariantCulture, "{0} = {1}", outputPath, inputPath);
            }
        }

        private static string BuildNullCheckExpression(ParameterTransformation transformation)
        {
            if (transformation == null)
            {
                throw new ArgumentNullException("transformation");
            }

            return string.Join(" || ",
                transformation.ParameterMappings
                    .Where(m => !m.InputParameter.IsRequired)
                    .Select(m => m.InputParameter.Name + " != null"));
        }

        public IEnumerable<ParameterJv> RequiredNullableParameters
        {
            get
            {
                foreach (ParameterJv param in Parameters)
                {
                    if (!param.ModelType.IsPrimaryType(KnownPrimaryType.Int) &&
                        !param.ModelType.IsPrimaryType(KnownPrimaryType.Double) &&
                        !param.ModelType.IsPrimaryType(KnownPrimaryType.Boolean) &&
                        !param.ModelType.IsPrimaryType(KnownPrimaryType.Long) &&
                        !param.ModelType.IsPrimaryType(KnownPrimaryType.UnixTime) &&
                        !param.IsConstant && param.IsRequired)
                    {
                        yield return param;
                    }
                }
            }
        }

        public IEnumerable<ParameterJv> ParametersToValidate
        {
            get
            {
                foreach (ParameterJv param in Parameters)
                {
                    if (param.ModelType is PrimaryType ||
                        param.ModelType is EnumType ||
                        param.IsConstant)
                    {
                        continue;
                    }
                    yield return param;
                }
            }
        }

        /// <summary>
        /// Gets the expression for response body initialization 
        /// </summary>
        public virtual string InitializeResponseBody
        {
            get
            {
                return string.Empty;
            }
        }

        public virtual string MethodParameterDeclarationWithCallback
        {
            get
            {
                var parameters = MethodParameterDeclaration;
                if (!parameters.IsNullOrEmpty())
                {
                    parameters += ", ";
                }
                parameters += string.Format(CultureInfo.InvariantCulture, "final ServiceCallback<{0}> serviceCallback",
                    ReturnTypeJv.GenericBodyClientTypeString);
                return parameters;
            }
        }

        public virtual string MethodRequiredParameterDeclarationWithCallback
        {
            get
            {
                var parameters = MethodRequiredParameterDeclaration;
                if (!parameters.IsNullOrEmpty())
                {
                    parameters += ", ";
                }
                parameters += string.Format(CultureInfo.InvariantCulture, "final ServiceCallback<{0}> serviceCallback",
                    ReturnTypeJv.GenericBodyClientTypeString);
                return parameters;
            }
        }

        public virtual string MethodParameterInvocationWithCallback
        {
            get
            {
                var parameters = MethodParameterInvocation;
                if (!parameters.IsNullOrEmpty())
                {
                    parameters += ", ";
                }
                parameters += "serviceCallback";
                return parameters;
            }
        }

        public virtual string MethodRequiredParameterInvocationWithCallback
        {
            get
            {
                var parameters = MethodDefaultParameterInvocation;
                if (!parameters.IsNullOrEmpty())
                {
                    parameters += ", ";
                }
                parameters += "serviceCallback";
                return parameters;
            }
        }

        /// <summary>
        /// Get the parameters that are actually method parameters in the order they appear in the method signature
        /// exclude global parameters
        /// </summary>
        public IEnumerable<ParameterJv> LocalParameters
        {
            get
            {
                //Omit parameter-group properties for now since Java doesn't support them yet
                return Parameters
                    .OfType<ParameterJv>()
                    .Where(p => p != null && p.ClientProperty == null && !string.IsNullOrWhiteSpace(p.Name))
                    .OrderBy(item => !item.IsRequired);
            }
        }

        public string HostParameterReplacementArgs
        {
            get
            {
                var args = new List<string>();
                foreach (var param in Parameters.Where(p => p.Extensions.ContainsKey("hostParameter")))
                {
                    args.Add("\"{" + param.SerializedName + "}\", " + param.Name);
                }
                return string.Join(", ", args);
            }
        }

        /// <summary>
        /// Get the type for operation exception
        /// </summary>
        public virtual string OperationExceptionTypeString
        {
            get
            {
                if (this.DefaultResponse.Body is CompositeType)
                {
                    var type = this.DefaultResponse.Body as CompositeTypeJv;
                    return type.ExceptionTypeDefinitionName;
                }
                else
                {
                    return "ServiceException";
                }
            }
        }

        public virtual IEnumerable<string> Exceptions
        {
            get
            {
                yield return OperationExceptionTypeString;
                yield return "IOException";
                if (RequiredNullableParameters.Any())
                {
                    yield return "IllegalArgumentException";
                }
            }
        }

        public virtual string ExceptionString
        {
            get
            {
                return string.Join(", ", Exceptions);
            }
        }

        public virtual List<string> ExceptionStatements
        {
            get
            {
                List<string> exceptions = new List<string>();
                exceptions.Add(OperationExceptionTypeString + " exception thrown from REST call");
                exceptions.Add("IOException exception thrown from serialization/deserialization");
                if (RequiredNullableParameters.Any())
                {
                    exceptions.Add("IllegalArgumentException exception thrown from invalid parameters");
                }
                return exceptions;
            }
        }

        public string CallType
        {
            get
            {
                if (this.HttpMethod == HttpMethod.Head)
                {
                    return "Void";
                }
                else
                {
                    return "ResponseBody";
                }
            }
        }

        public string InternalCallback
        {
            get
            {
                if (this.HttpMethod == HttpMethod.Head)
                {
                    return "ServiceResponseEmptyCallback";
                }
                else
                {
                    return "ServiceResponseCallback";
                }
            }
        }

        public virtual string ResponseBuilder
        {
            get
            {
                return "ServiceResponseBuilder";
            }
        }

        public virtual string RuntimeBasePackage
        {
            get
            {
                return "com.microsoft.rest";
            }
        }

        public ResponseJv ReturnTypeJv => ReturnType as ResponseJv;

        public virtual string ResponseGeneration(bool filterRequired = false)
        {
            if (ReturnTypeJv.NeedsConversion)
            {
                IndentedStringBuilder builder= new IndentedStringBuilder();
                builder.AppendLine("ServiceResponse<{0}> response = {1}Delegate(call.execute());",
                    ReturnTypeJv.GenericBodyWireTypeString, this.Name.ToCamelCase());
                builder.AppendLine("{0} body = null;", ReturnTypeJv.BodyClientType.Name)
                    .AppendLine("if (response.getBody() != null) {")
                    .Indent().AppendLine("{0}", ReturnTypeJv.ConvertBodyToClientType("response.getBody()", "body"))
                    .Outdent().AppendLine("}");
                return builder.ToString();
            }
            return "";
        }

        public virtual string ReturnValue
        {
            get
            {
                if (ReturnTypeJv.NeedsConversion)
                {
                    return "new ServiceResponse<" + ReturnTypeJv.GenericBodyClientTypeString + ">(body, response.getResponse())";
                }
                return this.Name + "Delegate(call.execute())";
            }
        }

        public virtual string SuccessCallback(bool filterRequired = false)
        {
            IndentedStringBuilder builder = new IndentedStringBuilder();
            if (ReturnTypeJv.NeedsConversion)
            {
                builder.AppendLine("ServiceResponse<{0}> result = {1}Delegate(response);", ReturnTypeJv.GenericBodyWireTypeString, this.Name);
                builder.AppendLine("{0} body = null;", ReturnTypeJv.BodyClientType)
                    .AppendLine("if (result.getBody() != null) {")
                    .Indent().AppendLine("{0}", ReturnTypeJv.ConvertBodyToClientType("result.getBody()", "body"))
                    .Outdent().AppendLine("}");
                builder.AppendLine("ServiceResponse<{0}> clientResponse = new ServiceResponse<{0}>(body, result.getResponse());",
                    ReturnTypeJv.GenericBodyClientTypeString);
                builder.AppendLine("if (serviceCallback != null) {")
                    .Indent().AppendLine("serviceCallback.success(clientResponse);", ReturnTypeJv.GenericBodyClientTypeString)
                    .Outdent().AppendLine("}");
                builder.AppendLine("serviceCall.success(clientResponse);");
            }
            else
            {
                builder.AppendLine("{0} clientResponse = {1}Delegate(response);", ReturnTypeJv.WireResponseTypeString, this.Name);
                builder.AppendLine("if (serviceCallback != null) {")
                    .Indent().AppendLine("serviceCallback.success(clientResponse);", this.Name)
                    .Outdent().AppendLine("}");
                builder.AppendLine("serviceCall.success(clientResponse);");
            }
            return builder.ToString();
        }

        public virtual string ClientResponse(bool filterRequired = false)
        {
            IndentedStringBuilder builder = new IndentedStringBuilder();
            if (ReturnTypeJv.NeedsConversion)
            {
                builder.AppendLine("ServiceResponse<{0}> result = {1}Delegate(response);", ReturnTypeJv.GenericBodyWireTypeString, this.Name);
                builder.AppendLine("{0} body = null;", ReturnTypeJv.BodyClientType)
                    .AppendLine("if (result.getBody() != null) {")
                    .Indent().AppendLine("{0}", ReturnTypeJv.ConvertBodyToClientType("result.getBody()", "body"))
                    .Outdent().AppendLine("}");
                builder.AppendLine("ServiceResponse<{0}> clientResponse = new ServiceResponse<{0}>(body, result.getResponse());",
                    ReturnTypeJv.GenericBodyClientTypeString);
            }
            else
            {
                builder.AppendLine("{0} clientResponse = {1}Delegate(response);", ReturnTypeJv.WireResponseTypeString, this.Name);
            }
            return builder.ToString();
        }

        public virtual string ServiceCallConstruction
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture,
                    "final ServiceCall<{0}> serviceCall = ServiceCall.{1}(call);",
                    ReturnTypeJv.GenericBodyClientTypeString, ServiceCallFactoryMethod);
            }
        }

        public virtual string ServiceCallFactoryMethod
        {
            get
            {
                string factoryMethod = "create";
                if (ReturnType.Headers != null)
                {
                    factoryMethod = "createWithHeaders";
                }
                return factoryMethod;
            }
        }

        public virtual string CallbackDocumentation
        {
            get
            {
                return " * @param serviceCallback the async ServiceCallback to handle successful and failed responses.";
            }
        }

        public virtual List<string> InterfaceImports
        {
            get
            {
                HashSet<string> imports = new HashSet<string>();
                // static imports
                imports.Add("rx.Observable");
                imports.Add("com.microsoft.rest.ServiceCall");
                imports.Add("com.microsoft.rest." + ReturnTypeJv.ClientResponseType);
                imports.Add("com.microsoft.rest.ServiceCallback");
                // parameter types
                this.Parameters.OfType<ParameterJv>().ForEach(p => imports.AddRange(p.InterfaceImports));
                // return type
                imports.AddRange(this.ReturnTypeJv.InterfaceImports);
                return imports.ToList();
            }
        }

        public virtual List<string> ImplImports
        {
            get
            {
                HashSet<string> imports = new HashSet<string>();
                // static imports
                imports.Add("rx.Observable");
                imports.Add("rx.functions.Func1");
                if (RequestContentType == "multipart/form-data" || RequestContentType == "application/x-www-form-urlencoded")
                {
                    imports.Add("retrofit2.http.Multipart");
                }
                else
                {
                    imports.Add("retrofit2.http.Headers");
                }
                imports.Add("retrofit2.Response");
                if (this.HttpMethod != HttpMethod.Head)
                {
                    imports.Add("okhttp3.ResponseBody");
                }
                imports.Add("com.microsoft.rest.ServiceCall");
                imports.Add("com.microsoft.rest." + ReturnTypeJv.ClientResponseType);
                imports.Add(RuntimeBasePackage + "." + ResponseBuilder);
                imports.Add("com.microsoft.rest.ServiceCallback");
//                this.RetrofitParameters.ForEach(p => imports.AddRange(p.RetrofitImports));
                // Http verb annotations
                imports.Add(this.HttpMethod.ImportFrom());
                // response type conversion
                if (this.Responses.Any())
                {
                    imports.Add("com.google.common.reflect.TypeToken");
                }
                // validation
                if (!ParametersToValidate.IsNullOrEmpty())
                {
                    imports.Add("com.microsoft.rest.Validator");
                }
                // parameters
                this.LocalParameters.Concat(this.LogicalParameters.OfType<ParameterJv>())
                    .ForEach(p => imports.AddRange(p.ClientImplImports));
//                this.RetrofitParameters.ForEach(p => imports.AddRange(p.WireImplImports));
                // return type
                imports.AddRange(this.ReturnTypeJv.ImplImports);
                if (ReturnType.Body.IsPrimaryType(KnownPrimaryType.Stream))
                {
                    imports.Add("retrofit2.http.Streaming");
                }
                // response type (can be different from return type)
                this.Responses.ForEach(r => imports.AddRange((r.Value as ResponseJv).ImplImports));
                // exceptions
                this.ExceptionString.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ForEach(ex =>
                    {
                        string exceptionImport = CodeNamerJv.GetJavaException(ex, CodeModel);
                        if (exceptionImport != null) imports.Add(CodeNamerJv.GetJavaException(ex, CodeModel));
                    });
                // parameterized host
                if (IsParameterizedHost)
                {
                    imports.Add("com.google.common.base.Joiner");
                }
                return imports.ToList();
            }
        }
    }
}