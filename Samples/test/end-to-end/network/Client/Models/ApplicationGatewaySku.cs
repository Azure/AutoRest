// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ApplicationGateway.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SKU of an application gateway
    /// </summary>
    public partial class ApplicationGatewaySku
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewaySku class.
        /// </summary>
        public ApplicationGatewaySku()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewaySku class.
        /// </summary>
        /// <param name="name">Name of an application gateway SKU. Possible
        /// values are: 'Standard_Small', 'Standard_Medium', 'Standard_Large',
        /// 'WAF_Medium', and 'WAF_Large'. Possible values include:
        /// 'Standard_Small', 'Standard_Medium', 'Standard_Large',
        /// 'WAF_Medium', 'WAF_Large'</param>
        /// <param name="tier">Tier of an application gateway. Possible values
        /// are: 'Standard' and 'WAF'. Possible values include: 'Standard',
        /// 'WAF'</param>
        /// <param name="capacity">Capacity (instance count) of an application
        /// gateway.</param>
        public ApplicationGatewaySku(string name = default(string), string tier = default(string), int? capacity = default(int?))
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of an application gateway SKU. Possible values
        /// are: 'Standard_Small', 'Standard_Medium', 'Standard_Large',
        /// 'WAF_Medium', and 'WAF_Large'. Possible values include:
        /// 'Standard_Small', 'Standard_Medium', 'Standard_Large',
        /// 'WAF_Medium', 'WAF_Large'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets tier of an application gateway. Possible values are:
        /// 'Standard' and 'WAF'. Possible values include: 'Standard', 'WAF'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets capacity (instance count) of an application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

    }
}
