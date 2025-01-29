using System;
using Newtonsoft.Json;

namespace JSONPad.UnitySDK.Assets.Scripts.Models
{
    public class DataList // Renamed from "List" to avoid conflicts
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

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("pathName")]
        public string PathName { get; set; } = string.Empty;

        [JsonProperty("schema")]
        public object Schema { get; set; } = new object(); // Avoids IL2CPP issues

        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("readonly")]
        public bool Readonly { get; set; }

        [JsonProperty("realtime")]
        public bool Realtime { get; set; }

        [JsonProperty("protected")]
        public bool Protected { get; set; }

        [JsonProperty("indexable")]
        public bool Indexable { get; set; }

        [JsonProperty("generative")]
        public bool Generative { get; set; }

        [JsonProperty("generativePrompt")]
        public string GenerativePrompt { get; set; } = string.Empty;

        [JsonProperty("itemCount")]
        public int ItemCount { get; set; }

        [JsonProperty("activated")]
        public bool Activated { get; set; }

        // Constructor to ensure safe defaults
        public DataList()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
