using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ListEventType
    {
        [EnumMember(Value = "list-created")]
        Created,

        [EnumMember(Value = "list-updated")]
        Updated,

        [EnumMember(Value = "list-deleted")]
        Deleted,

        [EnumMember(Value = "unknown")]
        Unknown // Fallback for unexpected values
    }
}
