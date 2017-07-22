// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApplicationGateway.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// All security rules associated with the network interface.
    /// </summary>
    public partial class SecurityRuleAssociations
    {
        /// <summary>
        /// Initializes a new instance of the SecurityRuleAssociations class.
        /// </summary>
        public SecurityRuleAssociations()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityRuleAssociations class.
        /// </summary>
        /// <param name="defaultSecurityRules">Collection of default security
        /// rules of the network security group.</param>
        /// <param name="effectiveSecurityRules">Collection of effective
        /// security rules.</param>
        public SecurityRuleAssociations(NetworkInterfaceAssociation networkInterfaceAssociation = default(NetworkInterfaceAssociation), SubnetAssociation subnetAssociation = default(SubnetAssociation), IList<SecurityRule> defaultSecurityRules = default(IList<SecurityRule>), IList<EffectiveNetworkSecurityRule> effectiveSecurityRules = default(IList<EffectiveNetworkSecurityRule>))
        {
            NetworkInterfaceAssociation = networkInterfaceAssociation;
            SubnetAssociation = subnetAssociation;
            DefaultSecurityRules = defaultSecurityRules;
            EffectiveSecurityRules = effectiveSecurityRules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "networkInterfaceAssociation")]
        public NetworkInterfaceAssociation NetworkInterfaceAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subnetAssociation")]
        public SubnetAssociation SubnetAssociation { get; set; }

        /// <summary>
        /// Gets or sets collection of default security rules of the network
        /// security group.
        /// </summary>
        [JsonProperty(PropertyName = "defaultSecurityRules")]
        public IList<SecurityRule> DefaultSecurityRules { get; set; }

        /// <summary>
        /// Gets or sets collection of effective security rules.
        /// </summary>
        [JsonProperty(PropertyName = "effectiveSecurityRules")]
        public IList<EffectiveNetworkSecurityRule> EffectiveSecurityRules { get; set; }

    }
}
