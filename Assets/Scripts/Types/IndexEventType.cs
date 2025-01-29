using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IndexEventType
    {
        [EnumMember(Value = "index-created")]
        Created,

        [EnumMember(Value = "index-updated")]
        Updated,

        [EnumMember(Value = "index-deleted")]
        Deleted,

        [EnumMember(Value = "unknown")]
        Unknown
    }
}
