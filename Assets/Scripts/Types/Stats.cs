using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

public class Stats<T> where T : IMetric
{
    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("totalThisPeriod")]
    public int TotalThisPeriod { get; set; }

    [JsonPropertyName("metrics")]
    public T[] Metrics { get; set; } = Array.Empty<T>();
}
