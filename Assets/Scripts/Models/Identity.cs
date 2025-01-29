using System;
using Newtonsoft.Json;

namespace JSONPad.UnitySDK.Assets.Scripts.Models
{
    public class Identity
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; } = new User(); // Assuming User has a parameterless constructor

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("group")]
        public string Group { get; set; } = string.Empty;

        [JsonProperty("lastLoginAt")]
        public DateTime? LastLoginAt { get; set; } = null;

        [JsonProperty("activated")]
        public bool Activated { get; set; }

        // Constructor to set default values
        public Identity()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
