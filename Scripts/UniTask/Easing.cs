#if UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine;

    public static partial class Easing
    {
        #region Basic

        public static async UniTask Apply(Action<float> action, Function.Delegate easingFunction, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var time = 0f;
            while (time < duration)
            {
                action(easingFunction(time / duration));
                await UniTask.NextFrame(timing, cancellationToken);
                time += ignoreTimeScale ? Time.unscaledDeltaTime : Time.deltaTime;
            }
            action(easingFunction(1));
        }

        #region Extensions

        public static UniTask Apply(Action<float> action, Type type, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.FromType(type), duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask Linear(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.Linear, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InSince(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InSince, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutSince(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutSince, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutSince(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutSince, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InQuad(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuad, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutQuad(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuad, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutQuad(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuad, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InCubic(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InCubic, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutCubic(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutCubic, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutCubic(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutCubic, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InQuart(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuart, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutQuart(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuart, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutQuart(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuart, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InQuint(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuint, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutQuint(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuint, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutQuint(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuint, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InExpo(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InExpo, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutExpo(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutExpo, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutExpo(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutExpo, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InCirc(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InCirc, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutCirc(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutCirc, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutCirc(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutCirc, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InBack(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InBack, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutBack(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutBack, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutBack(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutBack, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InElastic(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InElastic, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutElastic(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutElastic, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutElastic(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutElastic, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InBounce(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InBounce, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutBounce(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutBounce, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutBounce(Action<float> action, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutBounce, duration, ignoreTimeScale, timing, cancellationToken);

        #endregion

        #endregion

        #region Range

        public static UniTask Apply(Action<float> action, Function.Delegate easingFunction, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => action(begin + (end - begin) * value));
            return Apply(wrapper, easingFunction, duration, ignoreTimeScale, timing, cancellationToken);
        }

        #region Extensions

        public static UniTask Apply(Action<float> action, Type type, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.FromType(type), begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask Linear(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.Linear, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InSince(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InSince, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutSince(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutSince, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutSince(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutSince, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InQuad(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuad, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutQuad(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuad, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutQuad(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuad, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InCubic(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InCubic, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutCubic(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutCubic, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutCubic(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutCubic, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InQuart(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuart, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutQuart(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuart, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutQuart(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuart, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InQuint(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuint, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutQuint(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuint, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutQuint(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuint, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InExpo(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InExpo, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutExpo(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutExpo, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutExpo(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutExpo, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InCirc(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InCirc, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutCirc(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutCirc, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutCirc(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutCirc, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InBack(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InBack, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutBack(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutBack, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutBack(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutBack, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InElastic(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InElastic, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutElastic(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutElastic, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutElastic(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutElastic, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InBounce(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InBounce, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutBounce(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutBounce, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutBounce(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutBounce, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        #endregion

        #endregion

        #region Integer

        public static UniTask Apply(Action<int> action, Function.Delegate easingFunction, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var last = 0;
            var wrapper = new Action<float>(value =>
            {
                var curr = (int)value;
                if (curr == last) return;
                action(curr);
                last = curr;
            });
            return Apply(wrapper, easingFunction, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        #region Extensions

        public static UniTask Apply(Action<int> action, Type type, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.FromType(type), begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask Linear(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.Linear, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InSince(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InSince, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutSince(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutSince, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutSince(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutSince, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InQuad(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuad, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutQuad(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuad, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutQuad(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuad, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InCubic(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InCubic, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutCubic(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutCubic, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutCubic(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutCubic, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InQuart(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuart, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutQuart(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuart, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutQuart(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuart, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InQuint(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuint, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutQuint(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuint, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutQuint(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuint, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InExpo(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InExpo, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutExpo(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutExpo, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutExpo(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutExpo, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InCirc(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InCirc, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutCirc(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutCirc, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutCirc(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutCirc, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InBack(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InBack, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutBack(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutBack, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutBack(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutBack, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InElastic(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InElastic, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutElastic(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutElastic, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutElastic(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutElastic, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InBounce(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InBounce, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask OutBounce(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutBounce, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        public static UniTask InOutBounce(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutBounce, begin, end, duration, ignoreTimeScale, timing, cancellationToken);

        #endregion

        #endregion
    }
}
#endif