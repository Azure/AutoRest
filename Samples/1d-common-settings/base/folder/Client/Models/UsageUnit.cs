// This is my custom license header. I am a nice person so please don't steal
// my code.
//
// Cheers.

namespace AwesomeNamespace.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UsageUnit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UsageUnit
    {
        [EnumMember(Value = "Count")]
        Count,
        [EnumMember(Value = "Bytes")]
        Bytes,
        [EnumMember(Value = "Seconds")]
        Seconds,
        [EnumMember(Value = "Percent")]
        Percent,
        [EnumMember(Value = "CountsPerSecond")]
        CountsPerSecond,
        [EnumMember(Value = "BytesPerSecond")]
        BytesPerSecond
    }
    internal static class UsageUnitEnumExtension
    {
        internal static string ToSerializedValue(this UsageUnit? value)  =>
            value == null ? null : ((UsageUnit)value).ToSerializedValue();

        internal static string ToSerializedValue(this UsageUnit value)
        {
            switch( value )
            {
                case UsageUnit.Count:
                    return "Count";
                case UsageUnit.Bytes:
                    return "Bytes";
                case UsageUnit.Seconds:
                    return "Seconds";
                case UsageUnit.Percent:
                    return "Percent";
                case UsageUnit.CountsPerSecond:
                    return "CountsPerSecond";
                case UsageUnit.BytesPerSecond:
                    return "BytesPerSecond";
            }
            return null;
        }

        internal static UsageUnit? ParseUsageUnit(this string value)
        {
            switch( value )
            {
                case "Count":
                    return UsageUnit.Count;
                case "Bytes":
                    return UsageUnit.Bytes;
                case "Seconds":
                    return UsageUnit.Seconds;
                case "Percent":
                    return UsageUnit.Percent;
                case "CountsPerSecond":
                    return UsageUnit.CountsPerSecond;
                case "BytesPerSecond":
                    return UsageUnit.BytesPerSecond;
            }
            return null;
        }
    }
}
