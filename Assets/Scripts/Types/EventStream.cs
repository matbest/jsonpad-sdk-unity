using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum EventStream
{
    [EnumMember(Value = "list")]
    List,

    [EnumMember(Value = "item")]
    Item,

    [EnumMember(Value = "index")]
    Index,
}
