﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using Microsoft.Rest.Generator.ClientModel;
using Microsoft.Rest.Generator.Python.TemplateModels;
using Microsoft.Rest.Generator.Utilities;
using System.Collections;
using System.Text;
using Microsoft.Rest.Generator.Python;

namespace Microsoft.Rest.Generator.Azure.Python
{
    public class AzureMethodTemplateModel : MethodTemplateModel
    {
        public AzureMethodTemplateModel(Method source, ServiceClient serviceClient)
            : base(source, serviceClient)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            
            this.ClientRequestIdString = AzureExtensions.GetClientRequestIdString(source);
        }

        public bool IsPagingMethod
        {
            get
            {
                return this.Extensions.ContainsKey(AzureExtensions.PageableExtension);
            }
        }

        public string PagedResponseClassName
        {
            get
            {
                var ext = this.Extensions[AzureExtensions.PageableExtension] as Newtonsoft.Json.Linq.JContainer;

                return (string)ext["className"];
            }
        }

        public string ClientRequestIdString { get; private set; }

        /// <summary>
        /// Returns true if method has x-ms-long-running-operation extension.
        /// </summary>
        public bool IsLongRunningOperation
        {
            get { return Extensions.ContainsKey(AzureExtensions.LongRunningExtension); }
        }

        public override string RaisedException
        {
            get
            {
                if (DefaultResponse != null && DefaultResponse.Name == "CloudError")
                {
                    return "CloudException(self._deserialize, response)";
                }

                return base.RaisedException;
            }
        }

        /// <summary>
        /// Gets the expression for default header setting. 
        /// </summary>
        public override string SetDefaultHeaders
        {
            get
            {
                var sb = new IndentedStringBuilder();
                sb.Append(base.SetDefaultHeaders).AppendLine("headers['{0}'] = str(uuid.uuid1())", this.ClientRequestIdString);
                return sb.ToString();
            }
        }
    }
}