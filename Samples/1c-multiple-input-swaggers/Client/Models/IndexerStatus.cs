// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace .Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IndexerStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IndexerStatus
    {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "running")]
        Running
    }
}
