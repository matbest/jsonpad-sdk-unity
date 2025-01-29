using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

public class IdentityStats
{
    public sealed class IdentityMetric : IMetric
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("types")]
        public Dictionary<IdentityEventType, int> Types { get; set; } = new();
    }

    [JsonPropertyName("events")]
    public Stats<IdentityMetric> Events { get; set; } = new();
}
