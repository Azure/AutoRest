﻿using System;
using Microsoft.Rest.Generator;
using Microsoft.Rest.Modeler.Swagger.Model;

namespace Microsoft.Rest.Modeler.Swagger.Validators
{
    public class EnumContainsDefault : TypeRule<SwaggerObject>
    {
        public override bool IsValid(SwaggerObject entity)
        {
            bool valid = true;

            if (entity != null && !string.IsNullOrEmpty(entity.Default) && entity.Enum != null)
            {
                // There's a default, and there's an list of valid values. Make sure the default is one 
                // of them.
                if (!entity.Enum.Contains(entity.Default))
                {
                    valid = false;
                }
            }
            return valid;
        }

        public override ValidationExceptionName Exception
        {
            get
            {
                return ValidationExceptionName.DefaultMustAppearInEnum;
            }
        }
    }
}
