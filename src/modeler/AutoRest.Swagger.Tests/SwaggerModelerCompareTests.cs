﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.IO;
using System.Linq;
using Xunit;
using System.Collections.Generic;
using AutoRest.Core.Validation;
using AutoRest.Core.Logging;
using AutoRest.Core;
using AutoRest.Core.Utilities.Collections;
using AutoRest.Swagger.Validation;

namespace AutoRest.Swagger.Tests
{
    [Collection("Comparison Tests")]
    public class SwaggerModelerCompareTests
    {
        private IEnumerable<ComparisonMessage> CompareSwagger(string input)
        {
            var settings = new Settings
            {
                Namespace = "Test",
                Input = Path.Combine("Swagger", "Comparison", "Modified", input),
                Previous = Path.Combine("Swagger", "Comparison", "Original", input)
            };

            var modeler = new SwaggerModeler(settings);
            IEnumerable<ComparisonMessage> messages = modeler.Compare();

            // remove debug-level messages
            messages = messages.Where(each => each.Severity > LogEntrySeverity.Debug);

            return messages;
        }

        /// <summary>
        /// Verifies that raising the version number does not result in a strict comparison.
        /// </summary>
        [Fact]
        public void UpdatedMajorVersionNumberNotStrict()
        {
            var messages = CompareSwagger("version_check_01.json").ToArray();
            Assert.NotEmpty(messages.Where(m => m.Severity == LogEntrySeverity.Warning));
            Assert.Empty(messages.Where(m => m.Severity >= LogEntrySeverity.Error));
        }

        [Fact]
        public void UpdatedMinorVersionNumberNotStrict()
        {
            var messages = CompareSwagger("version_check_03.json").ToArray();
            Assert.NotEmpty(messages.Where(m => m.Severity == LogEntrySeverity.Warning));
            Assert.Empty(messages.Where(m => m.Severity >= LogEntrySeverity.Error));
        }

        /// <summary>
        /// Verifies that not raising the version number results in a strict comparison.
        /// </summary>
        [Fact]
        public void SameMajorVersionNumberStrict()
        {
            var messages = CompareSwagger("version_check_02.json").ToArray();
            Assert.Empty(messages.Where(m => m.Severity == LogEntrySeverity.Warning));
            Assert.NotEmpty(messages.Where(m => m.Severity >= LogEntrySeverity.Error));
        }

        /// <summary>
        /// Verifies that lowering the version number results in an error.
        /// </summary>
        [Fact]
        public void ReversedVersionNumberChange()
        {
            var messages = CompareSwagger("version_check_04.json").ToArray();
            Assert.NotEmpty(messages.Where(m => m.Severity >= LogEntrySeverity.Error));
            var reversed = messages.Where(m => m.Id == ComparisonMessages.VersionsReversed.Id);
            Assert.NotEmpty(reversed);
            Assert.Equal(LogEntrySeverity.Error, reversed.First().Severity);
        }

        /// <summary>
        /// Verifies that if you remove a supported protocol when updating the specification, it's caught.
        /// </summary>
        [Fact]
        public void ProtocolMissing()
        {
            var messages = CompareSwagger("misc_checks_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.ProtocolNoLongerSupported.Id);
            Assert.NotEmpty(missing);
            Assert.Equal(LogEntrySeverity.Error, missing.First().Severity);
        }

        /// <summary>
        /// Verifies that if you remove a supported request body format, it's caught.
        /// </summary>
        [Fact]
        public void RequestFormatMissing()
        {
            var messages = CompareSwagger("misc_checks_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.RequestBodyFormatNoLongerSupported.Id);
            Assert.NotEmpty(missing);
            Assert.Equal(LogEntrySeverity.Error, missing.First().Severity);
        }

        /// <summary>
        /// Verifies that if you add an expected response body format, it's caught.
        /// </summary>
        [Fact]
        public void ResponseFormatAdded()
        {
            var messages = CompareSwagger("misc_checks_01.json").ToArray();
            var added = messages.Where(m => m.Id == ComparisonMessages.ResponseBodyFormatNowSupported.Id);
            Assert.NotEmpty(added);
            Assert.Equal(LogEntrySeverity.Error, added.First().Severity);
        }

        /// <summary>
        /// Verifies that if you remove a schema, it's caught.
        /// </summary>
        [Fact]
        public void DefinitionRemoved()
        {
            var messages = CompareSwagger("misc_checks_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.RemovedDefinition.Id);
            Assert.NotEmpty(missing);
            Assert.Equal(LogEntrySeverity.Error, missing.First().Severity);
        }

        /// <summary>
        /// Verifies that if you change the type of a schema property, it's caught.
        /// </summary>
        [Fact]
        public void PropertyTypeChanged()
        {
            var messages = CompareSwagger("misc_checks_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.TypeChanged.Id);
            var error = missing.First();
            Assert.Equal(LogEntrySeverity.Error, error.Severity);
            Assert.Equal("#/definitions/Database/properties/b", error.Path);
        }

        /// <summary>
        /// Verifies that if you change the type format of a schema property, it's caught.
        /// </summary>
        [Fact]
        public void PropertyTypeFormatChanged()
        {
            var messages = CompareSwagger("misc_checks_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.TypeFormatChanged.Id);
            Assert.NotEmpty(missing);
            var error = missing.First();
            Assert.Equal(LogEntrySeverity.Error, error.Severity);
            Assert.Equal("#/definitions/Database/properties/c", error.Path);
        }

        /// <summary>
        /// Verifies that if you remove (or rename) a path, it's caught.
        /// </summary>
        public void PathRemoved()
        {
            var messages = CompareSwagger("operation_check_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.RemovedPath.Id);
            Assert.NotEmpty(missing);
            var error = missing.First();
            Assert.Equal(LogEntrySeverity.Error, error.Severity);
            Assert.Equal("#/paths//api/Paths", error.Path);
        }

        /// <summary>
        /// Verifies that if you remove an operation, it's caught.
        /// </summary>
        [Fact]
        public void OperationRemoved()
        { 
            var messages = CompareSwagger("operation_check_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.RemovedOperation.Id);
            Assert.NotEmpty(missing);
            var error = missing.First();
            Assert.Equal(LogEntrySeverity.Error, error.Severity);
            Assert.Equal("#/paths//api/Operations", error.Path);
        }

        /// <summary>
        /// Verifies that if you change the operations id for a path, it's caught.
        /// </summary>
        [Fact]
        public void OperationIdChanged()
        {
            var messages = CompareSwagger("operation_check_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.ModifiedOperationId.Id);
            Assert.NotEmpty(missing);
            var error = missing.First();
            Assert.Equal(LogEntrySeverity.Error, error.Severity);
            Assert.Equal("#/paths//api/Operations/post", error.Path);
        }

        /// <summary>
        /// Verifies that if you remove a required parameter, it's found.
        /// </summary>
        [Fact]
        public void RequiredParameterRemoved()
        {
            var messages = CompareSwagger("operation_check_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.RemovedRequiredParameter.Id);
            Assert.NotEmpty(missing);
            var error = missing.First();
            Assert.Equal(LogEntrySeverity.Error, error.Severity);
            Assert.Equal("#/paths//api/Parameters/{a}/get/a", error.Path);
        }

        /// <summary>
        /// Verifies that if you add a required parameter, it is flagged
        /// </summary>
        [Fact]
        public void RequiredParameterAdded()
        {
            var messages = CompareSwagger("operation_check_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.AddingRequiredParameter.Id);
            Assert.NotEmpty(missing);
            var error = missing.First();
            Assert.Equal(LogEntrySeverity.Error, error.Severity);
            Assert.Equal("#/paths//api/Parameters/{a}/get/c", error.Path);
        }

        /// <summary>
        /// Verifies that if you change where a parameter is passed, it is flagged.
        /// </summary>
        [Fact]
        public void ParameterMoved()
        {
            var messages = CompareSwagger("operation_check_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.ParameterInHasChanged.Id);
            Assert.NotEmpty(missing);
            var error = missing.First();
            Assert.Equal(LogEntrySeverity.Error, error.Severity);
            Assert.Equal("#/paths//api/Parameters/{a}/get/b", error.Path);
        }

        /// <summary>
        /// Verifies that if you make a required parameter optional, it's flagged, but not as an error.
        /// </summary>
        [Fact]
        public void ParameterStatusLess()
        {
            var messages = CompareSwagger("operation_check_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.RequiredStatusChange.Id);
            Assert.NotEmpty(missing);
            var error = missing.First();
            Assert.Equal(LogEntrySeverity.Info, error.Severity);
            Assert.Equal("#/paths//api/Parameters/{a}/get/d", error.Path);
        }

        /// <summary>
        /// Verifieds that if you make an optional parameter required, it's caught.
        /// </summary>
        [Fact]
        public void ParameterStatusMore()
        {
            var messages = CompareSwagger("operation_check_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.RequiredStatusChange.Id);
            Assert.NotEmpty(missing);
            var error = missing.Skip(1).First();
            Assert.Equal(LogEntrySeverity.Error, error.Severity);
            Assert.Equal("#/paths//api/Parameters/{a}/get/e", error.Path);
        }

        /// <summary>
        /// If a parameter used to be constant (only had one valid value), but is changed to take more than one
        /// value, then it should be flagged.
        /// </summary>
        [Fact]
        public void ParameterConstantChanged()
        {
            var messages = CompareSwagger("operation_check_01.json").ToArray();
            var missing = messages.Where(m => m.Id == ComparisonMessages.ConstantStatusHasChanged.Id);
            Assert.NotEmpty(missing);
            var error = missing.First();
            Assert.Equal(LogEntrySeverity.Error, error.Severity);
            Assert.Equal("#/paths//api/Parameters/{a}/get/f", error.Path);
        }

        /// <summary>
        /// Just changing the name of a parameter schema in the definitions section does not change the wire format for
        /// the parameter, so it shouldn't result in a separate error for the parameter.
        /// </summary>
        [Fact]
        public void ParameterSchemaNameChanged()
        {
            var messages = CompareSwagger("operation_check_02.json").ToArray();
            var redirected = messages.Where(m => m.Id == ComparisonMessages.ReferenceRedirection.Id);
            Assert.Empty(redirected);
        }

        /// <summary>
        /// Just changing the name of a parameter schema in the definitions section does not change the wire format for
        /// the parameter, so it shouldn't result in a separate error for the parameter.
        /// </summary>
        [Fact]
        public void ParameterSchemaContentsChanged()
        {
            var messages = CompareSwagger("operation_check_02.json").ToArray();
            var changed = messages.Where(m => m.Id == ComparisonMessages.TypeChanged.Id);
            Assert.NotEmpty(changed);
            var error = changed.First();
            Assert.Equal(LogEntrySeverity.Error, error.Severity);
            Assert.Equal("#/paths//api/Parameters/post/registry/properties/b", error.Path);
        }
    }
}
