// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AwesomeNamespace.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters to update on the account.
    /// </summary>
    [JsonTransformation]
    public partial class StorageAccountUpdateParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountUpdateParameters
        /// class.
        /// </summary>
        public StorageAccountUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountUpdateParameters
        /// class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="accountType">Gets or sets the account type. Note that
        /// StandardZRS and PremiumLRS accounts cannot be changed to other
        /// account types, and other account types cannot be changed to
        /// StandardZRS or PremiumLRS. Possible values include: 'Standard_LRS',
        /// 'Standard_ZRS', 'Standard_GRS', 'Standard_RAGRS',
        /// 'Premium_LRS'</param>
        /// <param name="customDomain">User domain assigned to the storage
        /// account. Name is the CNAME source. Only one custom domain is
        /// supported per storage account at this time. To clear the existing
        /// custom domain, use an empty string for the custom domain name
        /// property.</param>
        public StorageAccountUpdateParameters(IDictionary<string, string> tags = default(IDictionary<string, string>), AccountType? accountType = default(AccountType?), CustomDomain customDomain = default(CustomDomain))
        {
            Tags = tags;
            AccountType = accountType;
            CustomDomain = customDomain;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the account type. Note that StandardZRS and PremiumLRS
        /// accounts cannot be changed to other account types, and other
        /// account types cannot be changed to StandardZRS or PremiumLRS.
        /// Possible values include: 'Standard_LRS', 'Standard_ZRS',
        /// 'Standard_GRS', 'Standard_RAGRS', 'Premium_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountType")]
        public AccountType? AccountType { get; set; }

        /// <summary>
        /// Gets or sets user domain assigned to the storage account. Name is
        /// the CNAME source. Only one custom domain is supported per storage
        /// account at this time. To clear the existing custom domain, use an
        /// empty string for the custom domain name property.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomain")]
        public CustomDomain CustomDomain { get; set; }

    }
}
