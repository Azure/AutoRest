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
    /// Contains information about an Azure Batch account.
    /// </summary>
    [JsonTransformation]
    public partial class BatchAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccount class.
        /// </summary>
        public BatchAccount()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchAccount class.
        /// </summary>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="location">The location of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="accountEndpoint">The account endpoint used to interact
        /// with the Batch service.</param>
        /// <param name="provisioningState">The provisioned state of the
        /// resource. Possible values include: 'Invalid', 'Creating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Cancelled'</param>
        /// <param name="poolAllocationMode">The allocation mode to use for
        /// creating pools in the Batch account.</param>
        /// <param name="keyVaultReference">A reference to the Azure key vault
        /// associated with the Batch account.</param>
        /// <param name="autoStorage">The properties and status of any
        /// auto-storage account associated with the Batch account.</param>
        /// <param name="dedicatedCoreQuota">The dedicated core quota for this
        /// Batch account.</param>
        /// <param name="lowPriorityCoreQuota">The low-priority core quota for
        /// this Batch account.</param>
        /// <param name="poolQuota">The pool quota for this Batch
        /// account.</param>
        /// <param name="activeJobAndJobScheduleQuota">The active job and job
        /// schedule quota for this Batch account.</param>
        public BatchAccount(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string accountEndpoint = default(string), ProvisioningState provisioningState = default(ProvisioningState), PoolAllocationMode? poolAllocationMode = default(PoolAllocationMode?), KeyVaultReference keyVaultReference = default(KeyVaultReference), AutoStorageProperties autoStorage = default(AutoStorageProperties), int dedicatedCoreQuota = default(int), int lowPriorityCoreQuota = default(int), int poolQuota = default(int), int activeJobAndJobScheduleQuota = default(int))
            : base(id, name, type, location, tags)
        {
            AccountEndpoint = accountEndpoint;
            ProvisioningState = provisioningState;
            PoolAllocationMode = poolAllocationMode;
            KeyVaultReference = keyVaultReference;
            AutoStorage = autoStorage;
            DedicatedCoreQuota = dedicatedCoreQuota;
            LowPriorityCoreQuota = lowPriorityCoreQuota;
            PoolQuota = poolQuota;
            ActiveJobAndJobScheduleQuota = activeJobAndJobScheduleQuota;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the account endpoint used to interact with the Batch service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountEndpoint")]
        public string AccountEndpoint { get; private set; }

        /// <summary>
        /// Gets the provisioned state of the resource. Possible values
        /// include: 'Invalid', 'Creating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Cancelled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the allocation mode to use for creating pools in the Batch
        /// account.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'BatchService', 'UserSubscription'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.poolAllocationMode")]
        public PoolAllocationMode? PoolAllocationMode { get; private set; }

        /// <summary>
        /// Gets a reference to the Azure key vault associated with the Batch
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultReference")]
        public KeyVaultReference KeyVaultReference { get; private set; }

        /// <summary>
        /// Gets the properties and status of any auto-storage account
        /// associated with the Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoStorage")]
        public AutoStorageProperties AutoStorage { get; private set; }

        /// <summary>
        /// Gets the dedicated core quota for this Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dedicatedCoreQuota")]
        public int DedicatedCoreQuota { get; private set; }

        /// <summary>
        /// Gets the low-priority core quota for this Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lowPriorityCoreQuota")]
        public int LowPriorityCoreQuota { get; private set; }

        /// <summary>
        /// Gets the pool quota for this Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.poolQuota")]
        public int PoolQuota { get; private set; }

        /// <summary>
        /// Gets the active job and job schedule quota for this Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.activeJobAndJobScheduleQuota")]
        public int ActiveJobAndJobScheduleQuota { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KeyVaultReference != null)
            {
                KeyVaultReference.Validate();
            }
            if (AutoStorage != null)
            {
                AutoStorage.Validate();
            }
        }
    }
}
