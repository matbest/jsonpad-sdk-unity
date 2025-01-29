using System.Text.Json.Serialization;
using JSONPad.UnitySDK.Assets.Scripts.Types;

namespace JSONPad.UnitySDK.Assets.Scripts.Models;

public class Event<T> where T : Enum
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("user")]
    public User User { get; set; } = default!;

    [JsonPropertyName("modelId")]
    public string ModelId { get; set; } = default!;

    [JsonPropertyName("eventStream")]
    public EventStream EventStream { get; set; } = default!;

    [JsonPropertyName("type")]
    public T Type { get; set; } = default!;

    [JsonPropertyName("version")]
    public string Version { get; set; } = default!;

    [JsonPropertyName("snapshot")]
    public dynamic Snapshot { get; set; } = default!;

    [JsonPropertyName("attachments")]
    public dynamic Attachments { get; set; } = default!;
}
