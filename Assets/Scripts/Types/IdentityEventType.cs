using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

[JsonConverter(typeof(JsonStringEnumMemberConverter))]
public enum IdentityEventType
{
    [EnumMember(Value = "identity-created")]
    Created,

    [EnumMember(Value = "identity-updated")]
    Updated,

    [EnumMember(Value = "identity-deleted")]
    Deleted,

    [EnumMember(Value = "identity-registered")]
    Registered,

    [EnumMember(Value = "identity-logged-in")]
    LoggedIn,

    [EnumMember(Value = "identity-logged-out")]
    LoggedOut,

    [EnumMember(Value = "identity-updated-self")]
    UpdatedSelf,

    [EnumMember(Value = "identity-deleted-self")]
    DeletedSelf,
}
