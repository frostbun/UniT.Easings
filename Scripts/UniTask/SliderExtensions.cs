#if UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine.UI;

    public static class SliderExtensions
    {
        public static UniTask SlideAsync(this Slider target, float begin, float end, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.value = value);
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask SlideAsync(this Slider target, float end, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.SlideAsync(target.value, end, duration, function, ignoreTimeScale, timing, cancellationToken);
        }
    }
}
#endif