using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

public class IndexStats
{
    public sealed class IndexMetric : IMetric
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("types")]
        public Dictionary<IndexEventType, int> Types { get; set; } = new();
    }

    [JsonPropertyName("events")]
    public Stats<IndexMetric> Events { get; set; } = new();
}
