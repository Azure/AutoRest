// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ApplicationGateway.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// DhcpOptions contains an array of DNS servers available to VMs deployed
    /// in the virtual network. Standard DHCP option for a subnet overrides
    /// VNET DHCP options.
    /// </summary>
    public partial class DhcpOptions
    {
        /// <summary>
        /// Initializes a new instance of the DhcpOptions class.
        /// </summary>
        public DhcpOptions()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DhcpOptions class.
        /// </summary>
        /// <param name="dnsServers">The list of DNS servers IP
        /// addresses.</param>
        public DhcpOptions(IList<string> dnsServers = default(IList<string>))
        {
            DnsServers = dnsServers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of DNS servers IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "dnsServers")]
        public IList<string> DnsServers { get; set; }

    }
}
