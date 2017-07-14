// Code generated by Microsoft (R) AutoRest Code Generator 1.2.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Swagger.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines properties of an Azure Search service that can be modified.
    /// </summary>
    public partial class SearchServiceProperties
    {
        /// <summary>
        /// Initializes a new instance of the SearchServiceProperties class.
        /// </summary>
        public SearchServiceProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchServiceProperties class.
        /// </summary>
        /// <param name="replicaCount">The number of replicas in the Search
        /// service.</param>
        /// <param name="partitionCount">The number of partitions in the Search
        /// service; if specified, it can be 1, 2, 3, 4, 6, or 12.</param>
        public SearchServiceProperties(int? replicaCount = default(int?), int? partitionCount = default(int?))
        {
            ReplicaCount = replicaCount;
            PartitionCount = partitionCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of replicas in the Search service.
        /// </summary>
        [JsonProperty(PropertyName = "replicaCount")]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// Gets or sets the number of partitions in the Search service; if
        /// specified, it can be 1, 2, 3, 4, 6, or 12.
        /// </summary>
        [JsonProperty(PropertyName = "partitionCount")]
        public int? PartitionCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReplicaCount > 6)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "ReplicaCount", 6);
            }
            if (ReplicaCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "ReplicaCount", 1);
            }
        }
    }
}
