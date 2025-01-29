using System;
using Newtonsoft.Json;

namespace JSONPad.UnitySDK.Assets.Scripts.Models
{
    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; } = new object(); // Avoids IL2CPP issues

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("version")]
        public string Version { get; set; } = string.Empty;

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("activated")]
        public bool Activated { get; set; }

        // Constructor to ensure safe defaults
        public Item()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
