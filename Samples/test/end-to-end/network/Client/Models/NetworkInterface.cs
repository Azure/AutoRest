// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ApplicationGateway.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A network interface in a resource group.
    /// </summary>
    [JsonTransformation]
    public partial class NetworkInterface : Resource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkInterface class.
        /// </summary>
        public NetworkInterface()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkInterface class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="virtualMachine">The reference of a virtual
        /// machine.</param>
        /// <param name="networkSecurityGroup">The reference of the
        /// NetworkSecurityGroup resource.</param>
        /// <param name="ipConfigurations">A list of IPConfigurations of the
        /// network interface.</param>
        /// <param name="dnsSettings">The DNS settings in network
        /// interface.</param>
        /// <param name="macAddress">The MAC address of the network
        /// interface.</param>
        /// <param name="primary">Gets whether this is a primary network
        /// interface on a virtual machine.</param>
        /// <param name="enableAcceleratedNetworking">If the network interface
        /// is accelerated networking enabled.</param>
        /// <param name="enableIPForwarding">Indicates whether IP forwarding is
        /// enabled on this network interface.</param>
        /// <param name="resourceGuid">The resource GUID property of the
        /// network interface resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// public IP resource. Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public NetworkInterface(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SubResource virtualMachine = default(SubResource), NetworkSecurityGroup networkSecurityGroup = default(NetworkSecurityGroup), IList<NetworkInterfaceIPConfiguration> ipConfigurations = default(IList<NetworkInterfaceIPConfiguration>), NetworkInterfaceDnsSettings dnsSettings = default(NetworkInterfaceDnsSettings), string macAddress = default(string), bool? primary = default(bool?), bool? enableAcceleratedNetworking = default(bool?), bool? enableIPForwarding = default(bool?), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            VirtualMachine = virtualMachine;
            NetworkSecurityGroup = networkSecurityGroup;
            IpConfigurations = ipConfigurations;
            DnsSettings = dnsSettings;
            MacAddress = macAddress;
            Primary = primary;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            EnableIPForwarding = enableIPForwarding;
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
        /// Gets or sets the reference of a virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachine")]
        public SubResource VirtualMachine { get; set; }

        /// <summary>
        /// Gets or sets the reference of the NetworkSecurityGroup resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkSecurityGroup")]
        public NetworkSecurityGroup NetworkSecurityGroup { get; set; }

        /// <summary>
        /// Gets or sets a list of IPConfigurations of the network interface.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfigurations")]
        public IList<NetworkInterfaceIPConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// Gets or sets the DNS settings in network interface.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSettings")]
        public NetworkInterfaceDnsSettings DnsSettings { get; set; }

        /// <summary>
        /// Gets or sets the MAC address of the network interface.
        /// </summary>
        [JsonProperty(PropertyName = "properties.macAddress")]
        public string MacAddress { get; set; }

        /// <summary>
        /// Gets whether this is a primary network interface on a virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primary")]
        public bool? Primary { get; set; }

        /// <summary>
        /// Gets or sets if the network interface is accelerated networking
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableAcceleratedNetworking")]
        public bool? EnableAcceleratedNetworking { get; set; }

        /// <summary>
        /// Gets or sets indicates whether IP forwarding is enabled on this
        /// network interface.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableIPForwarding")]
        public bool? EnableIPForwarding { get; set; }

        /// <summary>
        /// Gets or sets the resource GUID property of the network interface
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the public IP resource.
        /// Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
