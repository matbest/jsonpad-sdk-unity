using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Models;

public class User
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = default!;

    [JsonPropertyName("description")]
    public string Description { get; set; } = default!;

    [JsonPropertyName("lastActiveAt")]
    public DateTime? LastActiveAt { get; set; }

    [JsonPropertyName("activated")]
    public bool Activated { get; set; }
}
