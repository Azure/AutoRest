// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace .Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines a data change detection policy that captures changes using the
    /// Integrated Change Tracking feature of Azure SQL Database.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.SqlIntegratedChangeTrackingPolicy")]
    public partial class SqlIntegratedChangeTrackingPolicy : DataChangeDetectionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the SqlIntegratedChangeTrackingPolicy
        /// class.
        /// </summary>
        public SqlIntegratedChangeTrackingPolicy()
        {
          CustomInit();
        }


        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
