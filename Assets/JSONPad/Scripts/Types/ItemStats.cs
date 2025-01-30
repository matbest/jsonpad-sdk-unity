using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    public class ItemStats
    {
        public sealed class ItemMetric : IMetric
        {
            [JsonProperty("date")]
            public DateTime Date { get; set; }

            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("types")]
            public Dictionary<ItemEventType, int> Types { get; set; } = new();
        }

        [JsonProperty("events")]
        public Stats<ItemMetric> Events { get; set; } = new();
    }
}
