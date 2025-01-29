using System;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    public struct IdentityParameter
    {
        public bool? Ignore { get; set; }
        public string Group { get; set; }
        public string Token { get; set; }

        public IdentityParameter(bool? ignore, string group, string token)
        {
            Ignore = ignore;
            Group = group ?? string.Empty;
            Token = token ?? string.Empty;
        }
    }
}
