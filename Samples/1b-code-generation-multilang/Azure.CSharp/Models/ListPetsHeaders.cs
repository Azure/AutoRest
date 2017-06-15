// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Petstore.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for listPets operation.
    /// </summary>
    public partial class ListPetsHeaders
    {
        /// <summary>
        /// Initializes a new instance of the ListPetsHeaders class.
        /// </summary>
        public ListPetsHeaders()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListPetsHeaders class.
        /// </summary>
        /// <param name="xNext">A link to the next page of responses</param>
        public ListPetsHeaders(string xNext = default(string))
        {
            XNext = xNext;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a link to the next page of responses
        /// </summary>
        [JsonProperty(PropertyName = "x-next")]
        public string XNext { get; set; }

    }
}
