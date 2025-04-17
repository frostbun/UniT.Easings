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
        public static UniTask SlideAsync(this Slider target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.value = value);
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask SlideAsync(this Slider target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.SlideAsync(target.value, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask SlideInAsync(this Slider target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.SlideAsync(0f, 1f, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask SlideOutAsync(this Slider target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.SlideAsync(1f, 0f, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FillAsync(this Image target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.fillAmount = value);
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FillAsync(this Image target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FillAsync(target.fillAmount, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FillInAsync(this Image target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FillAsync(0f, 1f, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FillOutAsync(this Image target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FillAsync(1f, 0f, duration, easing, timer, timing, cancellationToken);
        }
    }
}
#endif