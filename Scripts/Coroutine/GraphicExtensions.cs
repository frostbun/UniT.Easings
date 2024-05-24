#if !UNIT_EASINGS_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;
    using UnityEngine.UI;

    public static class GraphicExtensions
    {
        public static IEnumerator ChangeColorAsync(this Graphic target, Color begin, Color end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Color>(value => target.color = value);
            return Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeRAsync(this Graphic target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyR(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeGAsync(this Graphic target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyG(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeBAsync(this Graphic target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyB(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator FadeAsync(this Graphic target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyA(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeColorAsync(this Graphic target, Color end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.ChangeColorAsync(target.color, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeRAsync(this Graphic target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.ChangeRAsync(target.color.r, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeGAsync(this Graphic target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.ChangeGAsync(target.color.g, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeBAsync(this Graphic target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.ChangeBAsync(target.color.b, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator FadeAsync(this Graphic target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.FadeAsync(target.color.a, end, duration, function, ignoreTimeScale, callback);
        }

        #region Private

        private static IEnumerator Apply(Action<Color> action, Color begin, Color end, float duration, Easing.Function function, bool ignoreTimeScale, Action callback)
        {
            var diff    = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Easing.Apply(wrapper, duration, function, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyR(Func<Color> getter, Action<Color> setter, float begin, float end, float duration, Easing.Function function, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.r = value;
                setter(next);
            });
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyG(Func<Color> getter, Action<Color> setter, float begin, float end, float duration, Easing.Function function, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.g = value;
                setter(next);
            });
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyB(Func<Color> getter, Action<Color> setter, float begin, float end, float duration, Easing.Function function, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.b = value;
                setter(next);
            });
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyA(Func<Color> getter, Action<Color> setter, float begin, float end, float duration, Easing.Function function, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.a = value;
                setter(next);
            });
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        #endregion
    }
}
#endif