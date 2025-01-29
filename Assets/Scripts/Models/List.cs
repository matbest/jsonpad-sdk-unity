using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Models;

public class List
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("user")]
    public User User { get; set; } = default!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("description")]
    public string Description { get; set; } = default!;

    [JsonPropertyName("pathName")]
    public string PathName { get; set; } = default!;

    [JsonPropertyName("schema")]
    public dynamic Schema { get; set; } = default!;

    [JsonPropertyName("pinned")]
    public bool Pinned { get; set; } = default!;

    [JsonPropertyName("readonly")]
    public bool Readonly { get; set; } = default!;

    [JsonPropertyName("realtime")]
    public bool Realtime { get; set; } = default!;

    [JsonPropertyName("protected")]
    public bool Protected { get; set; } = default!;

    [JsonPropertyName("indexable")]
    public bool Indexable { get; set; } = default!;

    [JsonPropertyName("generative")]
    public bool Generative { get; set; } = default!;

    [JsonPropertyName("generativePrompt")]
    public string GenerativePrompt { get; set; } = default!;

    [JsonPropertyName("itemCount")]
    public int ItemCount { get; set; } = default!;

    [JsonPropertyName("activated")]
    public bool Activated { get; set; }
}
