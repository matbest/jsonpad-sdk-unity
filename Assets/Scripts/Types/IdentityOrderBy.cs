using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum IdentityOrderBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "updatedAt")]
    UpdatedAt,

    [EnumMember(Value = "name")]
    Name,

    [EnumMember(Value = "group")]
    Group,

    [EnumMember(Value = "activated")]
    Activated,
}
