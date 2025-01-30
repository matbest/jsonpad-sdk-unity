using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    [JsonConverter(typeof(StringEnumConverter))] // Updated for Newtonsoft.Json
    public enum IdentityEventType
    {
        [EnumMember(Value = "identity-created")]
        IdentityCreated,

        [EnumMember(Value = "identity-updated")]
        IdentityUpdated,

        [EnumMember(Value = "identity-deleted")]
        IdentityDeleted,

        [EnumMember(Value = "identity-registered")]
        IdentityRegistered,

        [EnumMember(Value = "identity-logged-in")]
        IdentityLoggedIn,

        [EnumMember(Value = "identity-logged-out")]
        IdentityLoggedOut,

        [EnumMember(Value = "identity-updated-self")]
        IdentityUpdatedSelf,

        [EnumMember(Value = "identity-deleted-self")]
        IdentityDeletedSelf,

        [EnumMember(Value = "unknown")]
        Unknown // Fallback for unexpected values
    }
}
