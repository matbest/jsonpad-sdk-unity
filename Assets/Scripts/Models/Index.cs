using System.Text.Json.Serialization;
using JSONPad.UnitySDK.Assets.Scripts.Types;

namespace JSONPad.UnitySDK.Assets.Scripts.Models;

public class Index
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = default!;

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("description")]
    public string Description { get; set; } = default!;

    [JsonPropertyName("pathName")]
    public string PathName { get; set; } = default!;

    [JsonPropertyName("pointer")]
    public string Pointer { get; set; } = default!;

    [JsonPropertyName("valueType")]
    public IndexValueType ValueType { get; set; } = default!;

    [JsonPropertyName("alias")]
    public bool Alias { get; set; } = default!;

    [JsonPropertyName("sorting")]
    public bool Sorting { get; set; } = default!;

    [JsonPropertyName("filtering")]
    public bool Filtering { get; set; } = default!;

    [JsonPropertyName("searching")]
    public bool Searching { get; set; } = default!;

    [JsonPropertyName("defaultOrderDirection")]
    public OrderDirection DefaultOrderDirection { get; set; } = default!;

    [JsonPropertyName("activated")]
    public bool Activated { get; set; }
}
