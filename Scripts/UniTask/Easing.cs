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

        public static async UniTask Apply(Action<float> action, Function.Delegate easingFunction, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var start = Time.time;
            while (Time.time - start < duration)
            {
                var x = (Time.time - start) / duration;
                action(easingFunction(x));
                await UniTask.Yield(timing, cancellationToken);
            }
            action(easingFunction(1));
        }

        #region Extensions

        public static UniTask Apply(Action<float> action, Type type, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.FromType(type), duration, timing, cancellationToken);

        public static UniTask Linear(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.Linear, duration, timing, cancellationToken);

        public static UniTask InSince(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InSince, duration, timing, cancellationToken);

        public static UniTask OutSince(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutSince, duration, timing, cancellationToken);

        public static UniTask InOutSince(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutSince, duration, timing, cancellationToken);

        public static UniTask InQuad(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuad, duration, timing, cancellationToken);

        public static UniTask OutQuad(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuad, duration, timing, cancellationToken);

        public static UniTask InOutQuad(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuad, duration, timing, cancellationToken);

        public static UniTask InCubic(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InCubic, duration, timing, cancellationToken);

        public static UniTask OutCubic(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutCubic, duration, timing, cancellationToken);

        public static UniTask InOutCubic(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutCubic, duration, timing, cancellationToken);

        public static UniTask InQuart(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuart, duration, timing, cancellationToken);

        public static UniTask OutQuart(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuart, duration, timing, cancellationToken);

        public static UniTask InOutQuart(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuart, duration, timing, cancellationToken);

        public static UniTask InQuint(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuint, duration, timing, cancellationToken);

        public static UniTask OutQuint(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuint, duration, timing, cancellationToken);

        public static UniTask InOutQuint(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuint, duration, timing, cancellationToken);

        public static UniTask InExpo(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InExpo, duration, timing, cancellationToken);

        public static UniTask OutExpo(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutExpo, duration, timing, cancellationToken);

        public static UniTask InOutExpo(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutExpo, duration, timing, cancellationToken);

        public static UniTask InCirc(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InCirc, duration, timing, cancellationToken);

        public static UniTask OutCirc(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutCirc, duration, timing, cancellationToken);

        public static UniTask InOutCirc(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutCirc, duration, timing, cancellationToken);

        public static UniTask InBack(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InBack, duration, timing, cancellationToken);

        public static UniTask OutBack(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutBack, duration, timing, cancellationToken);

        public static UniTask InOutBack(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutBack, duration, timing, cancellationToken);

        public static UniTask InElastic(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InElastic, duration, timing, cancellationToken);

        public static UniTask OutElastic(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutElastic, duration, timing, cancellationToken);

        public static UniTask InOutElastic(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutElastic, duration, timing, cancellationToken);

        public static UniTask InBounce(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InBounce, duration, timing, cancellationToken);

        public static UniTask OutBounce(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutBounce, duration, timing, cancellationToken);

        public static UniTask InOutBounce(Action<float> action, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutBounce, duration, timing, cancellationToken);

        #endregion

        #endregion

        #region Range

        public static UniTask Apply(Action<float> action, Function.Delegate easingFunction, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => action(begin + (end - begin) * value));
            return Apply(wrapper, easingFunction, duration, timing, cancellationToken);
        }

        #region Extensions

        public static UniTask Apply(Action<float> action, Type type, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.FromType(type), begin, end, duration, timing, cancellationToken);

        public static UniTask Linear(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.Linear, begin, end, duration, timing, cancellationToken);

        public static UniTask InSince(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InSince, begin, end, duration, timing, cancellationToken);

        public static UniTask OutSince(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutSince, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutSince(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutSince, begin, end, duration, timing, cancellationToken);

        public static UniTask InQuad(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuad, begin, end, duration, timing, cancellationToken);

        public static UniTask OutQuad(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuad, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutQuad(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuad, begin, end, duration, timing, cancellationToken);

        public static UniTask InCubic(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InCubic, begin, end, duration, timing, cancellationToken);

        public static UniTask OutCubic(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutCubic, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutCubic(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutCubic, begin, end, duration, timing, cancellationToken);

        public static UniTask InQuart(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuart, begin, end, duration, timing, cancellationToken);

        public static UniTask OutQuart(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuart, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutQuart(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuart, begin, end, duration, timing, cancellationToken);

        public static UniTask InQuint(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuint, begin, end, duration, timing, cancellationToken);

        public static UniTask OutQuint(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuint, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutQuint(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuint, begin, end, duration, timing, cancellationToken);

        public static UniTask InExpo(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InExpo, begin, end, duration, timing, cancellationToken);

        public static UniTask OutExpo(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutExpo, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutExpo(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutExpo, begin, end, duration, timing, cancellationToken);

        public static UniTask InCirc(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InCirc, begin, end, duration, timing, cancellationToken);

        public static UniTask OutCirc(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutCirc, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutCirc(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutCirc, begin, end, duration, timing, cancellationToken);

        public static UniTask InBack(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InBack, begin, end, duration, timing, cancellationToken);

        public static UniTask OutBack(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutBack, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutBack(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutBack, begin, end, duration, timing, cancellationToken);

        public static UniTask InElastic(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InElastic, begin, end, duration, timing, cancellationToken);

        public static UniTask OutElastic(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutElastic, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutElastic(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutElastic, begin, end, duration, timing, cancellationToken);

        public static UniTask InBounce(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InBounce, begin, end, duration, timing, cancellationToken);

        public static UniTask OutBounce(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutBounce, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutBounce(Action<float> action, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutBounce, begin, end, duration, timing, cancellationToken);

        #endregion

        #endregion

        #region Integer

        public static UniTask Apply(Action<int> action, Function.Delegate easingFunction, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var last = 0;
            var wrapper = new Action<float>(value =>
            {
                var now = (int)(begin + (end - begin) * value);
                if (now == last) return;
                action(now);
                last = now;
            });
            return Apply(wrapper, easingFunction, duration, timing, cancellationToken);
        }

        #region Extensions

        public static UniTask Apply(Action<int> action, Type type, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.FromType(type), begin, end, duration, timing, cancellationToken);

        public static UniTask Linear(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.Linear, begin, end, duration, timing, cancellationToken);

        public static UniTask InSince(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InSince, begin, end, duration, timing, cancellationToken);

        public static UniTask OutSince(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutSince, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutSince(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutSince, begin, end, duration, timing, cancellationToken);

        public static UniTask InQuad(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuad, begin, end, duration, timing, cancellationToken);

        public static UniTask OutQuad(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuad, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutQuad(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuad, begin, end, duration, timing, cancellationToken);

        public static UniTask InCubic(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InCubic, begin, end, duration, timing, cancellationToken);

        public static UniTask OutCubic(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutCubic, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutCubic(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutCubic, begin, end, duration, timing, cancellationToken);

        public static UniTask InQuart(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuart, begin, end, duration, timing, cancellationToken);

        public static UniTask OutQuart(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuart, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutQuart(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuart, begin, end, duration, timing, cancellationToken);

        public static UniTask InQuint(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InQuint, begin, end, duration, timing, cancellationToken);

        public static UniTask OutQuint(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutQuint, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutQuint(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutQuint, begin, end, duration, timing, cancellationToken);

        public static UniTask InExpo(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InExpo, begin, end, duration, timing, cancellationToken);

        public static UniTask OutExpo(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutExpo, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutExpo(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutExpo, begin, end, duration, timing, cancellationToken);

        public static UniTask InCirc(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InCirc, begin, end, duration, timing, cancellationToken);

        public static UniTask OutCirc(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutCirc, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutCirc(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutCirc, begin, end, duration, timing, cancellationToken);

        public static UniTask InBack(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InBack, begin, end, duration, timing, cancellationToken);

        public static UniTask OutBack(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutBack, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutBack(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutBack, begin, end, duration, timing, cancellationToken);

        public static UniTask InElastic(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InElastic, begin, end, duration, timing, cancellationToken);

        public static UniTask OutElastic(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutElastic, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutElastic(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutElastic, begin, end, duration, timing, cancellationToken);

        public static UniTask InBounce(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InBounce, begin, end, duration, timing, cancellationToken);

        public static UniTask OutBounce(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.OutBounce, begin, end, duration, timing, cancellationToken);

        public static UniTask InOutBounce(Action<int> action, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default) => Apply(action, Function.InOutBounce, begin, end, duration, timing, cancellationToken);

        #endregion

        #endregion
    }
}
#endif