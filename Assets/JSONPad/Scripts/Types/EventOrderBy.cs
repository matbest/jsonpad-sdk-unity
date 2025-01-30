using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    [JsonConverter(typeof(StringEnumConverter))] // Using Newtonsoft.Json
    public enum EventOrderBy
    {
        [EnumMember(Value = "createdAt")]
        CreatedAt,

        [EnumMember(Value = "type")]
        EventType, // Renamed from "Type" to avoid conflicts

        [EnumMember(Value = "unknown")]
        Unknown // Handles unexpected values gracefully
    }
}
