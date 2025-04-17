#nullable enable
namespace UniT.Easings
{
    using UnityEngine;

    public static class Timer
    {
        public delegate float Function();

        public static readonly Function DeltaTime = () => Time.deltaTime;

        public static readonly Function UnscaledDeltaTime = () => Time.unscaledDeltaTime;

        public static readonly Function FixedDeltaTime = () => Time.fixedDeltaTime;

        public static readonly Function FixedUnscaledDeltaTime = () => Time.fixedUnscaledDeltaTime;

        public static Function Default { get; set; } = DeltaTime;
    }
}