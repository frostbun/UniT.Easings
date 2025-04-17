#if !UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;
    using UnityEngine.UI;

    public static class ColorExtensions
    {
        public static IEnumerator ChangeColorAsync(this SpriteRenderer target, Color begin, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var wrapper = new Action<Color>(value => target.color = value);
            return Apply(wrapper, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeAsync(this SpriteRenderer target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyAlpha(getter, setter, begin, end, duration, easing, timer, callback);
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
            return target.FadeAsync(0f, 1f, duration, easing, timer, callback);
        }

        public static IEnumerator FadeOutAsync(this SpriteRenderer target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(1f, 0f, duration, easing, timer, callback);
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
            return target.FadeAsync(0f, 1f, duration, easing, timer, callback);
        }

        public static IEnumerator FadeOutAsync(this CanvasGroup target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(1f, 0f, duration, easing, timer, callback);
        }

        public static IEnumerator ChangeColorAsync(this Material target, Color begin, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var wrapper = new Action<Color>(value => target.color = value);
            return Apply(wrapper, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeAsync(this Material target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyAlpha(getter, setter, begin, end, duration, easing, timer, callback);
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
            return target.FadeAsync(0f, 1f, duration, easing, timer, callback);
        }

        public static IEnumerator FadeOutAsync(this Material target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(1f, 0f, duration, easing, timer, callback);
        }

        public static IEnumerator ChangeColorAsync(this Graphic target, Color begin, Color end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var wrapper = new Action<Color>(value => target.color = value);
            return Apply(wrapper, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator FadeAsync(this Graphic target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyAlpha(getter, setter, begin, end, duration, easing, timer, callback);
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
            return target.FadeAsync(0f, 1f, duration, easing, timer, callback);
        }

        public static IEnumerator FadeOutAsync(this Graphic target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FadeAsync(1f, 0f, duration, easing, timer, callback);
        }

        #region Private

        private static IEnumerator Apply(Action<Color> action, Color begin, Color end, float duration, Easing.Function? easing, Timer.Function? timer, Action? callback)
        {
            var diff    = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Easing.Apply(wrapper, duration, easing, timer, callback);
        }

        private static IEnumerator ApplyAlpha(Func<Color> getter, Action<Color> setter, float begin, float end, float duration, Easing.Function? easing, Timer.Function? timer, Action? callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.a = value;
                setter(next);
            });
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, callback);
        }

        #endregion
    }
}
#endif