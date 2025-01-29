using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum IndexEventType
{
    [EnumMember(Value = "index-created")]
    Created,

    [EnumMember(Value = "index-updated")]
    Updated,

    [EnumMember(Value = "index-deleted")]
    Deleted,
}
