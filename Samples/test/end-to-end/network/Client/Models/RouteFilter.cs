// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApplicationGateway.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Route Filter Resource.
    /// </summary>
    [JsonTransformation]
    public partial class RouteFilter : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RouteFilter class.
        /// </summary>
        public RouteFilter()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteFilter class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="rules">Collection of RouteFilterRules contained within
        /// a route filter.</param>
        /// <param name="peerings">A collection of references to express route
        /// circuit peerings.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values are: 'Updating', 'Deleting', 'Succeeded'
        /// and 'Failed'.</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public RouteFilter(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<RouteFilterRule> rules = default(IList<RouteFilterRule>), IList<ExpressRouteCircuitPeering> peerings = default(IList<ExpressRouteCircuitPeering>), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            Rules = rules;
            Peerings = peerings;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets collection of RouteFilterRules contained within a
        /// route filter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rules")]
        public IList<RouteFilterRule> Rules { get; set; }

        /// <summary>
        /// Gets a collection of references to express route circuit peerings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerings")]
        public IList<ExpressRouteCircuitPeering> Peerings { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values are:
        /// 'Updating', 'Deleting', 'Succeeded' and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
