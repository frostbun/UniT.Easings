#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine.UI;

    public static class SliderExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask SlideAsync(this Slider target, float begin, float end, float duration, Easing.Function? easing = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.value = value);
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask SlideAsync(this Slider target, float end, float duration, Easing.Function? easing = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.SlideAsync(target.value, end, duration, easing, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask SlideInAsync(this Slider target, float duration, Easing.Function? easing = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.SlideAsync(0, 1, duration, easing, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask SlideOutAsync(this Slider target, float duration, Easing.Function? easing = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.SlideAsync(1, 0, duration, easing, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FillAsync(this Image target, float begin, float end, float duration, Easing.Function? easing = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.fillAmount = value);
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FillAsync(this Image target, float end, float duration, Easing.Function? easing = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FillAsync(target.fillAmount, end, duration, easing, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FillInAsync(this Image target, float duration, Easing.Function? easing = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FillAsync(0, 1, duration, easing, timer, timing, cancellationToken);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask FillOutAsync(this Image target, float duration, Easing.Function? easing = null, Easing.Timer? timer = null, Easing.Timing timing = Easing.Timing.Update, CancellationToken cancellationToken = default)
        {
            return target.FillAsync(1, 0, duration, easing, timer, timing, cancellationToken);
        }
    }
}