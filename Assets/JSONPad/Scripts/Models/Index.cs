using System;
using Newtonsoft.Json;
using JSONPad.UnitySDK.Assets.Scripts.Types;

namespace JSONPad.UnitySDK.Assets.Scripts.Models
{
    public class Index
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("pathName")]
        public string PathName { get; set; } = string.Empty;

        [JsonProperty("pointer")]
        public string Pointer { get; set; } = string.Empty;

        [JsonProperty("valueType")]
        public IndexValueType ValueType { get; set; } = IndexValueType.Unknown; // Using "Unknown" instead of "Default"

        [JsonProperty("alias")]
        public bool Alias { get; set; }

        [JsonProperty("sorting")]
        public bool Sorting { get; set; }

        [JsonProperty("filtering")]
        public bool Filtering { get; set; }

        [JsonProperty("searching")]
        public bool Searching { get; set; }

        [JsonProperty("defaultOrderDirection")]
        public OrderDirection DefaultOrderDirection { get; set; } = OrderDirection.Ascending;

        [JsonProperty("activated")]
        public bool Activated { get; set; }

        // Constructor to initialize default values
        public Index()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
