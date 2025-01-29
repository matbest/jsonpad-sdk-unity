using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    public class ListStats
    {
        public sealed class ListContentsMetric : IMetric
        {
            [JsonProperty("date")]
            public DateTime Date { get; set; }

            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("lists")]
            public Dictionary<string, int> Lists { get; set; } = new();
        }

        public sealed class ListEventsMetric : IMetric
        {
            [JsonProperty("date")]
            public DateTime Date { get; set; }

            [JsonProperty("count")]
            public int Count { get; set; }

            [JsonProperty("types")]
            public Dictionary<ListEventType, int> Types { get; set; } = new();
        }

        [JsonProperty("maxItems")]
        public int? MaxItems { get; set; }

        [JsonProperty("maxIndexes")]
        public int? MaxIndexes { get; set; }

        [JsonProperty("items")]
        public Stats<ListContentsMetric> Items { get; set; } = new();

        [JsonProperty("indexes")]
        public Stats<ListContentsMetric> Indexes { get; set; } = new();

        [JsonProperty("events")]
        public Stats<ListEventsMetric> Events { get; set; } = new();
    }
}
