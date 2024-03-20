#if UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine.UI;

    public static class SliderExtensions
    {
        public static UniTask SlideAsync(this Slider slider, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => slider.value = value);
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask SlideAsync(this Slider slider, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return slider.SlideAsync(slider.value, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }
    }
}
#endif