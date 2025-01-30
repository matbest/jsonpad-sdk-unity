using System;
using Newtonsoft.Json;

namespace JSONPad.UnitySDK.Assets.Scripts.Types
{
    public class Stats<T> where T : IMetric
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("totalThisPeriod")]
        public int TotalThisPeriod { get; set; }

        [JsonProperty("metrics")]
        public T[] Metrics { get; set; } = Array.Empty<T>();
    }
}
