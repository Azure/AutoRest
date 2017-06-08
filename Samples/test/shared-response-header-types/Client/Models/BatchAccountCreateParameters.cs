// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SharedHeaders.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Create operation.
    /// </summary>
    [JsonTransformation]
    public partial class BatchAccountCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccountCreateParameters
        /// class.
        /// </summary>
        public BatchAccountCreateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchAccountCreateParameters
        /// class.
        /// </summary>
        /// <param name="location">The region in which to create the
        /// account.</param>
        /// <param name="tags">The user-specified tags associated with the
        /// account.</param>
        /// <param name="autoStorage">The properties related to the
        /// auto-storage account.</param>
        /// <param name="poolAllocationMode">The allocation mode to use for
        /// creating pools in the Batch account.</param>
        /// <param name="keyVaultReference">A reference to the Azure key vault
        /// associated with the Batch account.</param>
        public BatchAccountCreateParameters(string location, IDictionary<string, string> tags = default(IDictionary<string, string>), AutoStorageBaseProperties autoStorage = default(AutoStorageBaseProperties), PoolAllocationMode? poolAllocationMode = default(PoolAllocationMode?), KeyVaultReference keyVaultReference = default(KeyVaultReference))
        {
            Location = location;
            Tags = tags;
            AutoStorage = autoStorage;
            PoolAllocationMode = poolAllocationMode;
            KeyVaultReference = keyVaultReference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the region in which to create the account.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the user-specified tags associated with the account.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the properties related to the auto-storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoStorage")]
        public AutoStorageBaseProperties AutoStorage { get; set; }

        /// <summary>
        /// Gets or sets the allocation mode to use for creating pools in the
        /// Batch account.
        /// </summary>
        /// <remarks>
        /// The pool allocation mode also affects how clients may authenticate
        /// to the Batch Service API. If the mode is BatchService, clients may
        /// authenticate using access keys or Azure Active Directory. If the
        /// mode is UserSubscription, clients must use Azure Active Directory.
        /// The default is BatchService. Possible values include:
        /// 'BatchService', 'UserSubscription'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.poolAllocationMode")]
        public PoolAllocationMode? PoolAllocationMode { get; set; }

        /// <summary>
        /// Gets or sets a reference to the Azure key vault associated with the
        /// Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultReference")]
        public KeyVaultReference KeyVaultReference { get; set; }

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
            if (AutoStorage != null)
            {
                AutoStorage.Validate();
            }
            if (KeyVaultReference != null)
            {
                KeyVaultReference.Validate();
            }
        }
    }
}
