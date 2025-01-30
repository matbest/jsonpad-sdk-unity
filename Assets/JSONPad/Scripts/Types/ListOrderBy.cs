using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ListOrderBy
    {
        [EnumMember(Value = "createdAt")]
        CreatedAt,

        [EnumMember(Value = "updatedAt")]
        UpdatedAt,

        [EnumMember(Value = "name")]
        Name,

        [EnumMember(Value = "pathName")]
        PathName,

        [EnumMember(Value = "pinned")]
        Pinned,

        [EnumMember(Value = "readonly")]
        Readonly,

        [EnumMember(Value = "realtime")]
        Realtime,

        [EnumMember(Value = "indexable")]
        Indexable,

        [EnumMember(Value = "generative")]
        Generative,

        [EnumMember(Value = "protected")]
        Protected,

        [EnumMember(Value = "activate")]
        Activated
    }
}
