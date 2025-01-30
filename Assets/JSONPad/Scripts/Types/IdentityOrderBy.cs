using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    [JsonConverter(typeof(StringEnumConverter))] // Use Newtonsoft.Json
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

        [EnumMember(Value = "unknown")]
        Unknown // Handles unexpected values gracefully
    }
}
