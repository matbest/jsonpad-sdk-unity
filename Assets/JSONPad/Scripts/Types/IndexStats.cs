using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    public class IndexStats
    {
        public sealed class IndexMetric : IMetric
        {
            [JsonProperty("date")]
            public DateTime Date { get; set; } = DateTime.UtcNow;

            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("types")]
            public Dictionary<IndexEventType, int> Types { get; set; } = new Dictionary<IndexEventType, int>();
        }

        [JsonProperty("events")]
        public Stats<IndexMetric>? Events { get; set; } = new();
    }
}
