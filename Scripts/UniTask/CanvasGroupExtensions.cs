#if UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine;

    public static class CanvasGroupExtensions
    {
        public static UniTask FadeAsync(this CanvasGroup target, float begin, float end, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.alpha = value);
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask FadeAsync(this CanvasGroup target, float end, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(target.alpha, end, duration, function, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask FadeInAsync(this CanvasGroup target, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(0f, 1f, duration, function, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask FadeOutAsync(this CanvasGroup target, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(1f, 0f, duration, function, ignoreTimeScale, timing, cancellationToken);
        }
    }
}
#endif