using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    [JsonConverter(typeof(StringEnumConverter))] // Ensures proper JSON serialization
    public enum ItemEventType
    {
        [EnumMember(Value = "item-created")]
        Created,

        [EnumMember(Value = "item-updated")]
        Updated,

        [EnumMember(Value = "item-restored")]
        Restored,

        [EnumMember(Value = "item-deleted")]
        Deleted,

        [EnumMember(Value = "unknown")]
        Unknown
    }
}
