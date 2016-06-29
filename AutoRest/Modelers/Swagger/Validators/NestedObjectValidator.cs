﻿using Microsoft.Rest.Generator;
using Microsoft.Rest.Generator.Logging;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Rest.Modeler.Swagger.Validators
{
    public class NestedObjectValidator : IValidator<object>
    {
        private readonly Type RuleAttributeType = typeof(RuleAttribute);
        private readonly Type IterableRuleAttributeType = typeof(IterableRuleAttribute);
        private readonly Type JsonExtensionDataType = typeof(JsonExtensionDataAttribute);

        public bool IsValid(object entity)
        {
            return !ValidationExceptions(entity).Any();
        }

        public IEnumerable<ValidationMessage> ValidationExceptions(object entity)
        {
            return ValidationExceptions(entity, null, null);
        }

        public IEnumerable<ValidationMessage> ValidationExceptions(object entity, SourceContext source, RuleAttribute[] inheritedRules)
        {
            if (entity != null)
            {
                var isList = entity is IList;
                bool isDictionary = entity is IDictionary;
                // If class, loop through properties
                if (!isList && !isDictionary && entity.GetType().IsClass && entity.GetType() != typeof(string))
                {
                    // Go through each class rule
                    var classRules = entity.GetType().GetCustomAttributes(RuleAttributeType, true) as RuleAttribute[];
                    if (inheritedRules != null)
                    {
                        classRules = inheritedRules.Concat(classRules).ToArray();
                    }
                    foreach (var rule in classRules)
                    {
                        foreach (var message in rule.GetValidationMessages(entity))
                        {
                            yield return message;
                        }
                    }

                    // Go through each prop rule
                    foreach (var prop in entity.GetType().GetProperties(BindingFlags.FlattenHierarchy
                        | BindingFlags.Public
                        | BindingFlags.Instance
                        ).Where(prop => !Attribute.IsDefined(prop, JsonExtensionDataType)).Where(prop => prop.PropertyType != typeof(object)))
                    {
                        var value = prop.GetValue(entity);
                        var rules = prop.GetCustomAttributes(RuleAttributeType, true) as RuleAttribute[];
                        foreach (var rule in rules)
                        {
                            foreach (var message in rule.GetValidationMessages(value))
                            {
                                yield return message;
                            }
                        }

                        // If the property is a class, do validation on the property value
                        var inheritableRules = prop.GetCustomAttributes(IterableRuleAttributeType, true) as IterableRuleAttribute[];
                        foreach (var exception in ValidationExceptions(value, source, inheritableRules))
                        {
                            exception.Path.Add(prop.Name);
                            yield return exception;
                        }
                    }
                }
                else if (isList)
                {
                    var list = ((IList)entity).Cast<dynamic>().ToList();
                    if (list != null)
                    {
                        var index = 0;
                        foreach (var child in list)
                        {
                            var exceptions = ValidationExceptions(child, source, inheritedRules);
                            foreach (var exception in exceptions)
                            {
                                exception.Path.Add($"[{index}]");
                                yield return exception;
                            }
                        }
                    }
                }
                else if (isDictionary)
                {
                    var dict = ((IDictionary)entity).Cast<dynamic>().ToDictionary(entry => (string)entry.Key, entry => entry.Value);
                    var dictType = entity.GetType();
                    // TODO: figure out way to stop processing more rules if it's an object property
                    if (dict != null && dictType.IsGenericType && dictType.GenericTypeArguments.Count() >=2 && dictType.GenericTypeArguments[1] != typeof(object))
                    {
                        foreach (var pair in dict)
                        {
                            var exceptions = ValidationExceptions(pair.Value, source, inheritedRules);
                            foreach (var exception in exceptions)
                            {
                                exception.Path.Add(pair.Key);
                                yield return exception;
                            }
                        }
                    }
                }
            }
            yield break;
        }
    }
}
