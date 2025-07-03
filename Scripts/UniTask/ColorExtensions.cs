#if UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UniT.Extensions;
    using UnityEngine;
    using UnityEngine.UI;

    public static class ColorExtensions
    {
        public static UniTask ChangeColorAsync(this SpriteRenderer target, Color begin, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetColor, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeAsync(this SpriteRenderer target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetAlpha, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ChangeColorAsync(this SpriteRenderer target, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ChangeColorAsync(target.color, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeAsync(this SpriteRenderer target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(target.color.a, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeInAsync(this SpriteRenderer target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(0, 1, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeOutAsync(this SpriteRenderer target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(1, 0, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeAsync(this CanvasGroup target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.alpha = value);
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeAsync(this CanvasGroup target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(target.alpha, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeInAsync(this CanvasGroup target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(0, 1, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeOutAsync(this CanvasGroup target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(1, 0, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ChangeColorAsync(this Material target, Color begin, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetColor, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeAsync(this Material target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetAlpha, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ChangeColorAsync(this Material target, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ChangeColorAsync(target.color, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeAsync(this Material target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(target.color.a, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeInAsync(this Material target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(0, 1, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeOutAsync(this Material target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(1, 0, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ChangeColorAsync(this Graphic target, Color begin, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetColor, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeAsync(this Graphic target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetAlpha, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ChangeColorAsync(this Graphic target, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ChangeColorAsync(target.color, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeAsync(this Graphic target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(target.color.a, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeInAsync(this Graphic target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(0, 1, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask FadeOutAsync(this Graphic target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(1, 0, duration, easing, timer, timing, cancellationToken);
        }
    }
}
#endif