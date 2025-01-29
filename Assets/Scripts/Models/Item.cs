using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Models;

public class Item
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("data")]
    public dynamic Data { get; set; } = default!;

    [JsonPropertyName("description")]
    public string Description { get; set; } = default!;

    [JsonPropertyName("version")]
    public string Version { get; set; } = default!;

    [JsonPropertyName("readonly")]
    public bool Readonly { get; set; } = default!;

    [JsonPropertyName("size")]
    public int Size { get; set; } = default!;

    [JsonPropertyName("activated")]
    public bool Activated { get; set; }
}
