using System.Text.Json.Serialization;

namespace JSONPad.UnitySDK.Assets.Scripts.Types;

public class PaginatedResponse<T>
{
    [JsonPropertyName("page")]
    public int? Page { get; set; } = 1;

    [JsonPropertyName("limit")]
    public int? Limit { get; set; } = 10;

    [JsonPropertyName("total")]
    public int? Total { get; set; } = 0;

    [JsonPropertyName("data")]
    public T[] Data { get; set; } = Array.Empty<T>();
}
