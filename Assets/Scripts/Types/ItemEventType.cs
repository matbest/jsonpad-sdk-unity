using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
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
}
