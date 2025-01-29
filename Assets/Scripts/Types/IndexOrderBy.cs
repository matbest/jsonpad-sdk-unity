using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum IndexOrderBy
{
    [EnumMember(Value = "createdAt")]
    CreatedAt,

    [EnumMember(Value = "updatedAt")]
    UpdatedAt,

    [EnumMember(Value = "name")]
    Name,

    [EnumMember(Value = "pathName")]
    PathName,

    [EnumMember(Value = "valueType")]
    ValueType,

    [EnumMember(Value = "alias")]
    Alias,

    [EnumMember(Value = "sorting")]
    Sorting,

    [EnumMember(Value = "filtering")]
    Filtering,

    [EnumMember(Value = "searching")]
    Searching,

    [EnumMember(Value = "defaultOrderDirection")]
    DefaultOrderDirection,

    [EnumMember(Value = "activated")]
    Activated,
}
