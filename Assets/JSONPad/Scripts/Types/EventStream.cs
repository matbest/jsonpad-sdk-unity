using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    [JsonConverter(typeof(StringEnumConverter))] // Using Newtonsoft.Json
    public enum EventStream
    {
        [EnumMember(Value = "list")]
        ListStream, // Renamed from "List" to avoid conflicts

        [EnumMember(Value = "item")]
        ItemStream, // Renamed from "Item" to avoid conflicts

        [EnumMember(Value = "index")]
        IndexStream, // Renamed from "Index" to avoid conflicts

        [EnumMember(Value = "unknown")]
        Unknown // Handles unexpected values gracefully
    }
}
