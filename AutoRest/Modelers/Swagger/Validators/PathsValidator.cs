﻿using Microsoft.Rest.Generator;
using Microsoft.Rest.Generator.Validation;
using Microsoft.Rest.Modeler.Swagger.Model;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Rest.Modeler.Swagger
{
    public class PathsValidator : SwaggerBaseValidator, IValidator<Dictionary<string, Dictionary<string, Operation>>>
    {
        public Dictionary<string, SwaggerParameter> Parameters { get; internal set; }

        public PathsValidator(SourceContext source, Dictionary<string, SwaggerParameter> parameters) : base(source)
        {
            Parameters = parameters;
        }

        public bool IsValid(Dictionary<string, Dictionary<string, Operation>> entity)
        {
            return !ValidationExceptions(entity).Any();
        }

        public IEnumerable<ValidationMessage> ValidationExceptions(Dictionary<string, Dictionary<string, Operation>> paths)
        {
            foreach (var path in paths)
            {
                foreach (var operation in path.Value)
                {
                    var operationsValidator = new OperationsValidator(Source, path.Key, Parameters);
                    foreach (var exception in operationsValidator.ValidationExceptions(operation.Value))
                    {
                        exception.Path.Add(operation.Key);
                        exception.Path.Add(path.Key);
                        yield return exception;
                    }
                    // TODO: validate properties
                    //if (schema.Properties != null)
                    //{
                    //    foreach (var prop in schema.Properties)
                    //    {
                    //        context.PushTitle(context.Title + "/" + prop.Key);
                    //        prop.Value.Validate(context);
                    //        context.PopTitle();
                    //    }
                    //}

                    // TODO: validate external docs
                    //if (schema.ExternalDocs != null)
                    //{
                    //    ExternalDocs.Validate(context);
                    //}

                    yield break;
                }
            }
        }
    }
}
