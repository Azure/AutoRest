
namespace Petstore
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// The Storage Management Client.
    /// </summary>
    public partial class StorageManagementClient : ServiceClient<StorageManagementClient>, IStorageManagementClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri { get; set; }

        /// <summary>
        /// Gets JSON serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets JSON deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Gets Azure subscription credentials.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every service
        /// call.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Client Api Version.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running Operations.
        /// Default value is 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IStorageAccountsOperations.
        /// </summary>
        public virtual IStorageAccountsOperations StorageAccounts { get; private set; }

        /// <summary>
        /// Gets the IUsageOperations.
        /// </summary>
        public virtual IUsageOperations Usage { get; private set; }

        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP pipeline.
        /// </param>
        protected StorageManagementClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The HTTP client handler used to handle HTTP transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP pipeline.
        /// </param>
        protected StorageManagementClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP pipeline.
        /// </param>
        protected StorageManagementClient(Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The HTTP client handler used to handle HTTP transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP pipeline.
        /// </param>
        protected StorageManagementClient(Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this.BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets Azure subscription credentials.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP pipeline.
        /// </param>
        public StorageManagementClient(ServiceClientCredentials credentials, string subscriptionId, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException("subscriptionId");
            }
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets Azure subscription credentials.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The HTTP client handler used to handle HTTP transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP pipeline.
        /// </param>
        public StorageManagementClient(ServiceClientCredentials credentials, string subscriptionId, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException("subscriptionId");
            }
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets Azure subscription credentials.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP pipeline.
        /// </param>
        public StorageManagementClient(Uri baseUri, ServiceClientCredentials credentials, string subscriptionId, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException("subscriptionId");
            }
            this.BaseUri = baseUri;
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Initializes a new instance of the StorageManagementClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets Azure subscription credentials.
        /// </param>
        /// <param name='subscriptionId'>
        /// Required. Gets subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The HTTP client handler used to handle HTTP transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the HTTP pipeline.
        /// </param>
        public StorageManagementClient(Uri baseUri, ServiceClientCredentials credentials, string subscriptionId, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException("subscriptionId");
            }
            this.BaseUri = baseUri;
            this.Credentials = credentials;
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            this.StorageAccounts = new StorageAccountsOperations(this);
            this.Usage = new UsageOperations(this);
            this.BaseUri = new Uri("https://management.azure.com");
            this.ApiVersion = "2015-06-15";
            this.AcceptLanguage = "en-US";
            this.LongRunningOperationRetryTimeout = 30;
            this.GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter()); 
        }    
    }
}
