using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IndexValueType
    {
        [EnumMember(Value = "string")]
        StringValue, // Renamed from "String" to avoid conflicts

        [EnumMember(Value = "number")]
        Number,

        [EnumMember(Value = "date")]
        Date,

        [EnumMember(Value = "unknown")]
        Unknown // Default value
    }
}
