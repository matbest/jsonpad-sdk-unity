using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum ListEventType
{
    [EnumMember(Value = "list-created")]
    Created,

    [EnumMember(Value = "list-updated")]
    Updated,

    [EnumMember(Value = "list-deleted")]
    Deleted,
}
