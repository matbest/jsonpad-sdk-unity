using System;
using Newtonsoft.Json;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    public class PaginatedResponse<T>
    {
        [JsonProperty("page")]
        public int? Page { get; set; } = 1;

        [JsonProperty("limit")]
        public int? Limit { get; set; } = 10;

        [JsonProperty("total")]
        public int? Total { get; set; } = 0;

        [JsonProperty("data")]
        public T[] Data { get; set; } = Array.Empty<T>();
    }
}
