#if !UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UniT.Extensions;
    using UnityEngine;
    using UnityEngine.UI;

    public static class ColorExtensions
    {
        public static IEnumerator ChangeColorAsync(this SpriteRenderer target, Color begin, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetColor, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeAsync(this SpriteRenderer target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetAlpha, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator ChangeColorAsync(this SpriteRenderer target, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.ChangeColorAsync(target.color, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeAsync(this SpriteRenderer target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(target.color.a, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeInAsync(this SpriteRenderer target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(0, 1, duration, easing, timer, callback);
        }

        public static IEnumerator FadeOutAsync(this SpriteRenderer target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(1, 0, duration, easing, timer, callback);
        }

        public static IEnumerator FadeAsync(this CanvasGroup target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var wrapper = new Action<float>(value => target.alpha = value);
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeAsync(this CanvasGroup target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(target.alpha, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeInAsync(this CanvasGroup target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(0, 1, duration, easing, timer, callback);
        }

        public static IEnumerator FadeOutAsync(this CanvasGroup target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(1, 0, duration, easing, timer, callback);
        }

        public static IEnumerator ChangeColorAsync(this Material target, Color begin, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetColor, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeAsync(this Material target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetAlpha, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator ChangeColorAsync(this Material target, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.ChangeColorAsync(target.color, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeAsync(this Material target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(target.color.a, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeInAsync(this Material target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(0, 1, duration, easing, timer, callback);
        }

        public static IEnumerator FadeOutAsync(this Material target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(1, 0, duration, easing, timer, callback);
        }

        public static IEnumerator ChangeColorAsync(this Graphic target, Color begin, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetColor, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeAsync(this Graphic target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetAlpha, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator ChangeColorAsync(this Graphic target, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.ChangeColorAsync(target.color, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeAsync(this Graphic target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(target.color.a, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeInAsync(this Graphic target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(0, 1, duration, easing, timer, callback);
        }

        public static IEnumerator FadeOutAsync(this Graphic target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(1, 0, duration, easing, timer, callback);
        }
    }
}
#endif