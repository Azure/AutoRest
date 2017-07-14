// Code generated by Microsoft (R) AutoRest Code Generator 1.2.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Swagger.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// &gt; Shorthand for `@.definitions.SearchServiceListResult` which equals
    /// `$.definitions.SearchServiceListResult` since no super headings change
    /// the current scope.
    ///
    /// Response containing a list of Azure Search services for a given
    /// resource group.
    /// </summary>
    public partial class SearchServiceListResult
    {
        /// <summary>
        /// Initializes a new instance of the SearchServiceListResult class.
        /// </summary>
        public SearchServiceListResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchServiceListResult class.
        /// </summary>
        /// <param name="value">The Search services in the resource
        /// group.</param>
        public SearchServiceListResult(IList<SearchServiceResource> value = default(IList<SearchServiceResource>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Search services in the resource group.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<SearchServiceResource> Value { get; private set; }

    }
}
