using Newtonsoft.Json;
using System;


namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    public struct PaginatedRequest<T> where T : Enum
    {
        [JsonProperty("page")]
        public int? Page { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("order")]
        public T? Order { get; set; }
    }
}
