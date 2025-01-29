using System;
using Newtonsoft.Json;
using JSONPad.UnitySDK.Assets.Scripts.Types;

namespace JSONPad.UnitySDK.Assets.Scripts.Models
{
    public class Event<T> where T : Enum
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; } = new User(); // Assuming User has a parameterless constructor

        [JsonProperty("modelId")]
        public string ModelId { get; set; } = string.Empty;

        [JsonProperty("eventStream")]
        public EventStream EventStream { get; set; } // Removed `new EventStream()` since `EventStream` is an enum

        [JsonProperty("type")]
        public T Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; } = string.Empty;

        [JsonProperty("snapshot")]
        public object Snapshot { get; set; } = new object();

        [JsonProperty("attachments")]
        public object Attachments { get; set; } = new object();
        
        // Constructor to ensure proper initialization
        public Event()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
