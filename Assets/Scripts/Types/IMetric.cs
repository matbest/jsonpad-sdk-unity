using System;

namespace JSONPad.UnitySDK.Assets.Scripts
{
    public interface IMetric
    {
        DateTime Date { get; set; }
        int Count { get; set; }
    }
}
