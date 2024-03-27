#if UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine;
    using UnityEngine.UI;

    public static class GraphicExtensions
    {
        public static UniTask ChangeColorAsync(this Graphic target, Color begin, Color end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Color>(value => target.color = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask ChangeRAsync(this Graphic target, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyR(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask ChangeGAsync(this Graphic target, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyG(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask ChangeBAsync(this Graphic target, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyB(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask FadeAsync(this Graphic target, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Color>(() => target.color);
            var setter = new Action<Color>(value => target.color = value);
            return ApplyA(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask ChangeColorAsync(this Graphic target, Color end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ChangeColorAsync(target.color, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask ChangeRAsync(this Graphic target, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ChangeRAsync(target.color.r, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask ChangeGAsync(this Graphic target, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ChangeGAsync(target.color.g, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask ChangeBAsync(this Graphic target, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ChangeBAsync(target.color.b, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask FadeAsync(this Graphic target, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.FadeAsync(target.color.a, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        #region Private

        private static UniTask Apply(Action<Color> action, Easing.Type type, Color begin, Color end, float duration, bool ignoreTimeScale, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var diff    = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Easing.Apply(wrapper, type, duration, ignoreTimeScale, timing, cancellationToken);
        }

        private static UniTask ApplyR(Func<Color> getter, Action<Color> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.r = value;
                setter(next);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        private static UniTask ApplyG(Func<Color> getter, Action<Color> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.g = value;
                setter(next);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        private static UniTask ApplyB(Func<Color> getter, Action<Color> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.b = value;
                setter(next);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        private static UniTask ApplyA(Func<Color> getter, Action<Color> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.a = value;
                setter(next);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        #endregion
    }
}
#endif