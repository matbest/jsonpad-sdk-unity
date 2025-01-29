using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

public class SearchResult
{
    [JsonPropertyName("relevance")]
    public float Relevance { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; } = string.Empty;

    // [JsonPropertyName("item")]
    // public Item[] Data { get; set; } = Array.Empty<T>();

    // TODO
}
