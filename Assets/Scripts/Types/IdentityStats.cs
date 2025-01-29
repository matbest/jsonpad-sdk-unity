using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    public class IdentityStats
    {
        public sealed class IdentityMetric : IMetric
        {
            [JsonProperty("date")]
            public DateTime Date { get; set; } = DateTime.UtcNow;

            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("types")]
            public Dictionary<IdentityEventType, int> Types { get; set; } = new Dictionary<IdentityEventType, int>();
        }

        [JsonProperty("events")]
        public Stats<IdentityMetric>? Events { get; set; } = new();
    }
}
