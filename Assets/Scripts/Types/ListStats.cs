using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

public class ListStats
{
    public sealed class ListContentsMetric : IMetric
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("lists")]
        public Dictionary<string, int> Lists { get; set; } = new();
    }

    public sealed class ListEventsMetric : IMetric
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("types")]
        public Dictionary<ListEventType, int> Types { get; set; } = new();
    }

    [JsonPropertyName("maxItems")]
    public int? MaxItems { get; set; }

    [JsonPropertyName("maxIndexes")]
    public int? MaxIndexes { get; set; }

    [JsonPropertyName("items")]
    public Stats<ListContentsMetric> Items { get; set; } = new();

    [JsonPropertyName("indexes")]
    public Stats<ListContentsMetric> Indexes { get; set; } = new();

    [JsonPropertyName("events")]
    public Stats<ListEventsMetric> Events { get; set; } = new();
}
