#nullable enable
namespace UniT.Easings
{
    using UnityEngine;

    public static partial class Easing
    {
        public delegate float Timer();

        public static readonly Timer DeltaTime = () => Time.deltaTime;

        public static readonly Timer UnscaledDeltaTime = () => Time.unscaledDeltaTime;

        public static Timer DefaultTimer { get; set; } = DeltaTime;
    }
}