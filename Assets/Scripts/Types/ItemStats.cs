using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

public class ItemStats
{
    public sealed class ItemMetric : IMetric
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("types")]
        public Dictionary<ItemEventType, int> Types { get; set; } = new();
    }

    [JsonPropertyName("events")]
    public Stats<ItemMetric> Events { get; set; } = new();
}
