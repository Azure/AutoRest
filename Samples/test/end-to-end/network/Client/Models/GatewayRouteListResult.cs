// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApplicationGateway.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of virtual network gateway routes
    /// </summary>
    public partial class GatewayRouteListResult
    {
        /// <summary>
        /// Initializes a new instance of the GatewayRouteListResult class.
        /// </summary>
        public GatewayRouteListResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayRouteListResult class.
        /// </summary>
        /// <param name="value">List of gateway routes</param>
        public GatewayRouteListResult(IList<GatewayRoute> value = default(IList<GatewayRoute>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of gateway routes
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<GatewayRoute> Value { get; set; }

    }
}
