using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum OrderDirection
{
    [EnumMember(Value = "asc")]
    Ascending,

    [EnumMember(Value = "desc")]
    Descending,
}
