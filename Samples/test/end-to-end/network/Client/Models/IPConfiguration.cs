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
    using System.Linq;

    /// <summary>
    /// IPConfiguration
    /// </summary>
    [JsonTransformation]
    public partial class IPConfiguration : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the IPConfiguration class.
        /// </summary>
        public IPConfiguration()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IPConfiguration class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="privateIPAddress">The private IP address of the IP
        /// configuration.</param>
        /// <param name="privateIPAllocationMethod">The private IP allocation
        /// method. Possible values are 'Static' and 'Dynamic'. Possible values
        /// include: 'Static', 'Dynamic'</param>
        /// <param name="subnet">The reference of the subnet resource.</param>
        /// <param name="publicIPAddress">The reference of the public IP
        /// resource.</param>
        /// <param name="provisioningState">Gets the provisioning state of the
        /// public IP resource. Possible values are: 'Updating', 'Deleting',
        /// and 'Failed'.</param>
        /// <param name="name">The name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public IPConfiguration(string id = default(string), string privateIPAddress = default(string), string privateIPAllocationMethod = default(string), Subnet subnet = default(Subnet), PublicIPAddress publicIPAddress = default(PublicIPAddress), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the private IP address of the IP configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAddress")]
        public string PrivateIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the private IP allocation method. Possible values are
        /// 'Static' and 'Dynamic'. Possible values include: 'Static',
        /// 'Dynamic'
        /// </summary>
        [JsonProperty(PropertyName = "properties.privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Gets or sets the reference of the subnet resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public Subnet Subnet { get; set; }

        /// <summary>
        /// Gets or sets the reference of the public IP resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddress")]
        public PublicIPAddress PublicIPAddress { get; set; }

        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible
        /// values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within a
        /// resource group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

    }
}
