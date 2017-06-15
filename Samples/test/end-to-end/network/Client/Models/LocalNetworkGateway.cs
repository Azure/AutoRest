// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
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
    /// A common class for general resource information
    /// </summary>
    [JsonTransformation]
    public partial class LocalNetworkGateway : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LocalNetworkGateway class.
        /// </summary>
        public LocalNetworkGateway()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocalNetworkGateway class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="localNetworkAddressSpace">Local network site address
        /// space.</param>
        /// <param name="gatewayIpAddress">IP address of local network
        /// gateway.</param>
        /// <param name="bgpSettings">Local network gateway's BGP speaker
        /// settings.</param>
        /// <param name="resourceGuid">The resource GUID property of the
        /// LocalNetworkGateway resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// LocalNetworkGateway resource. Possible values are: 'Updating',
        /// 'Deleting', and 'Failed'.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public LocalNetworkGateway(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), AddressSpace localNetworkAddressSpace = default(AddressSpace), string gatewayIpAddress = default(string), BgpSettings bgpSettings = default(BgpSettings), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            LocalNetworkAddressSpace = localNetworkAddressSpace;
            GatewayIpAddress = gatewayIpAddress;
            BgpSettings = bgpSettings;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets local network site address space.
        /// </summary>
        [JsonProperty(PropertyName = "properties.localNetworkAddressSpace")]
        public AddressSpace LocalNetworkAddressSpace { get; set; }

        /// <summary>
        /// Gets or sets IP address of local network gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayIpAddress")]
        public string GatewayIpAddress { get; set; }

        /// <summary>
        /// Gets or sets local network gateway's BGP speaker settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bgpSettings")]
        public BgpSettings BgpSettings { get; set; }

        /// <summary>
        /// Gets or sets the resource GUID property of the LocalNetworkGateway
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets the provisioning state of the LocalNetworkGateway resource.
        /// Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
