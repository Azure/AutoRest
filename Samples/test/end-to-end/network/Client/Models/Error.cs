// Code generated by Microsoft (R) AutoRest Code Generator 1.2.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApplicationGateway.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Error
    {
        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        public Error()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        public Error(string code = default(string), string message = default(string), string target = default(string), IList<ErrorDetails> details = default(IList<ErrorDetails>), string innerError = default(string))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            InnerError = innerError;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ErrorDetails> Details { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "innerError")]
        public string InnerError { get; set; }

    }
}
