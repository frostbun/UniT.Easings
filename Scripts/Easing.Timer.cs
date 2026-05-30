#nullable enable
namespace UniT.Easings
{
    using UnityEngine;

    public static partial class Easing
    {
        public delegate float Timer();

        public static readonly Timer DeltaTime = () => Time.deltaTime;

        public static readonly Timer UnscaledDeltaTime = () => Time.unscaledDeltaTime;

        public static readonly Timer FixedDeltaTime = () => Time.fixedDeltaTime;

        public static readonly Timer FixedUnscaledDeltaTime = () => Time.fixedUnscaledDeltaTime;

        public static Timer DefaultTimer { get; set; } = DeltaTime;
    }
}