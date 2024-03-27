#if !UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;
    using UnityEngine.UI;

    public static class GraphicExtensions
    {
        public static IEnumerator ChangeColorAsync(this Graphic target, Color begin, Color end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Color>(value => target.color = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeRAsync(this Graphic target, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyR(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeGAsync(this Graphic target, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyG(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeBAsync(this Graphic target, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyB(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator FadeAsync(this Graphic target, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyA(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeColorAsync(this Graphic target, Color end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.ChangeColorAsync(target.color, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeRAsync(this Graphic target, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.ChangeRAsync(target.color.r, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeGAsync(this Graphic target, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.ChangeGAsync(target.color.g, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator ChangeBAsync(this Graphic target, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.ChangeBAsync(target.color.b, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator FadeAsync(this Graphic target, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.FadeAsync(target.color.a, end, duration, type, ignoreTimeScale, callback);
        }

        #region Private

        private static IEnumerator Apply(Action<Color> action, Easing.Type type, Color begin, Color end, float duration, bool ignoreTimeScale, Action callback)
        {
            var diff    = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Easing.Apply(wrapper, type, duration, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyR(Func<Color> getter, Action<Color> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.r = value;
                setter(next);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyG(Func<Color> getter, Action<Color> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.g = value;
                setter(next);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyB(Func<Color> getter, Action<Color> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.b = value;
                setter(next);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyA(Func<Color> getter, Action<Color> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.a = value;
                setter(next);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        #endregion
    }
}
#endif