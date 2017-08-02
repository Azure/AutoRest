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
    /// Backend address pool settings of an application gateway.
    /// </summary>
    [JsonTransformation]
    public partial class ApplicationGatewayBackendHttpSettings : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHttpSettings class.
        /// </summary>
        public ApplicationGatewayBackendHttpSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationGatewayBackendHttpSettings class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="port">Port</param>
        /// <param name="protocol">Protocol. Possible values are: 'Http' and
        /// 'Https'. Possible values include: 'Http', 'Https'</param>
        /// <param name="cookieBasedAffinity">Cookie based affinity. Possible
        /// values are: 'Enabled' and 'Disabled'. Possible values include:
        /// 'Enabled', 'Disabled'</param>
        /// <param name="requestTimeout">Request timeout in seconds.
        /// Application Gateway will fail the request if response is not
        /// received within RequestTimeout. Acceptable values are from 1 second
        /// to 86400 seconds.</param>
        /// <param name="probe">Probe resource of an application
        /// gateway.</param>
        /// <param name="authenticationCertificates">Array of references to
        /// application gateway authentication certificates.</param>
        /// <param name="provisioningState">Provisioning state of the backend
        /// http settings resource. Possible values are: 'Updating',
        /// 'Deleting', and 'Failed'.</param>
        /// <param name="connectionDraining">Connection draining of the backend
        /// http settings resource.</param>
        /// <param name="name">Name of the resource that is unique within a
        /// resource group. This name can be used to access the
        /// resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ApplicationGatewayBackendHttpSettings(string id = default(string), int? port = default(int?), string protocol = default(string), string cookieBasedAffinity = default(string), int? requestTimeout = default(int?), SubResource probe = default(SubResource), IList<SubResource> authenticationCertificates = default(IList<SubResource>), string provisioningState = default(string), ApplicationGatewayConnectionDraining connectionDraining = default(ApplicationGatewayConnectionDraining), string name = default(string), string etag = default(string))
            : base(id)
        {
            Port = port;
            Protocol = protocol;
            CookieBasedAffinity = cookieBasedAffinity;
            RequestTimeout = requestTimeout;
            Probe = probe;
            AuthenticationCertificates = authenticationCertificates;
            ProvisioningState = provisioningState;
            ConnectionDraining = connectionDraining;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets port
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets protocol. Possible values are: 'Http' and 'Https'.
        /// Possible values include: 'Http', 'Https'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets cookie based affinity. Possible values are: 'Enabled'
        /// and 'Disabled'. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.cookieBasedAffinity")]
        public string CookieBasedAffinity { get; set; }

        /// <summary>
        /// Gets or sets request timeout in seconds. Application Gateway will
        /// fail the request if response is not received within RequestTimeout.
        /// Acceptable values are from 1 second to 86400 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestTimeout")]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// Gets or sets probe resource of an application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.probe")]
        public SubResource Probe { get; set; }

        /// <summary>
        /// Gets or sets array of references to application gateway
        /// authentication certificates.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authenticationCertificates")]
        public IList<SubResource> AuthenticationCertificates { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the backend http settings
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets connection draining of the backend http settings
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionDraining")]
        public ApplicationGatewayConnectionDraining ConnectionDraining { get; set; }

        /// <summary>
        /// Gets or sets name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConnectionDraining != null)
            {
                ConnectionDraining.Validate();
            }
        }
    }
}
