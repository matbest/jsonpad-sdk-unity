using Newtonsoft.Json;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    public class SearchResult
    {
        [JsonProperty("relevance")]
        public float Relevance { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        // Uncomment and modify this when needed
        // [JsonProperty("item")]
        // public Item[] Data { get; set; } = Array.Empty<Item>();

        // TODO: Implement additional fields if required
    }
}
