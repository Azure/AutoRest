// <auto-generated>
// This is my custom license header. I am a nice person so please don't steal
// my code.
//
// Cheers.
// </auto-generated>

namespace AwesomeNamespace.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters to provide for the account.
    /// </summary>
    [JsonTransformation]
    public partial class StorageAccountCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountCreateParameters
        /// class.
        /// </summary>
        public StorageAccountCreateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountCreateParameters
        /// class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="accountType">Gets or sets the account type. Possible
        /// values include: 'Standard_LRS', 'Standard_ZRS', 'Standard_GRS',
        /// 'Standard_RAGRS', 'Premium_LRS'</param>
        /// <param name="tags">Resource tags</param>
        public StorageAccountCreateParameters(string location, AccountType accountType, IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Location = location;
            Tags = tags;
            AccountType = accountType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the account type. Possible values include:
        /// 'Standard_LRS', 'Standard_ZRS', 'Standard_GRS', 'Standard_RAGRS',
        /// 'Premium_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountType")]
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
