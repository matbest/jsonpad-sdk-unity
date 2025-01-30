using System;
using Newtonsoft.Json;

namespace JSONPad.UnitySDK.Assets.Scripts.Models
{
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("lastActiveAt")]
        public DateTime? LastActiveAt { get; set; } = null;

        [JsonProperty("activated")]
        public bool Activated { get; set; }

        // Constructor to ensure safe defaults
        public User()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
