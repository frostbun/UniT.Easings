namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine;

    public delegate float EasingFunction(float x);

    public static class Easing
    {
        #region Basic

        public static async UniTask Apply(Action<float> action, EasingFunction easingFunction, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
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

        public static UniTask Apply(Action<float> action, EasingFunction easingFunction, float begin, float end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
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

        public static UniTask Apply(Action<int> action, EasingFunction easingFunction, int begin, int end, float duration, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
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

        public enum Type
        {
            Linear,
            InSince,
            OutSince,
            InOutSince,
            InQuad,
            OutQuad,
            InOutQuad,
            InCubic,
            OutCubic,
            InOutCubic,
            InQuart,
            OutQuart,
            InOutQuart,
            InQuint,
            OutQuint,
            InOutQuint,
            InExpo,
            OutExpo,
            InOutExpo,
            InCirc,
            OutCirc,
            InOutCirc,
            InBack,
            OutBack,
            InOutBack,
            InElastic,
            OutElastic,
            InOutElastic,
            InBounce,
            OutBounce,
            InOutBounce,
        }

        public static class Function
        {
            #region Constants

            private const float PI = Mathf.PI;
            private const float C1 = 1.70158f;
            private const float C2 = C1 * 1.525f;
            private const float C3 = C1 + 1;
            private const float C4 = 2 * PI / 3;
            private const float C5 = 2 * PI / 4.5f;
            private const float N1 = 7.5625f;
            private const float D1 = 2.75f;

            #endregion

            public static float Linear(float x) => x;

            public static float InSince(float x) => 1 - Mathf.Cos(x * PI / 2);

            public static float OutSince(float x) => Mathf.Sin(x * PI / 2);

            public static float InOutSince(float x) => (1 - Mathf.Cos(x * PI)) / 2;

            public static float InQuad(float x) => Mathf.Pow(x, 2);

            public static float OutQuad(float x) => 1 - Mathf.Pow(1 - x, 2);

            public static float InOutQuad(float x) => x < .5f
                ? Mathf.Pow(2 * x, 2) / 2
                : 1 - Mathf.Pow(2 - 2 * x, 2) / 2;

            public static float InCubic(float x) => Mathf.Pow(x, 3);

            public static float OutCubic(float x) => 1 - Mathf.Pow(1 - x, 3);

            public static float InOutCubic(float x) => x < .5f
                ? Mathf.Pow(2 * x, 3) / 2
                : 1 - Mathf.Pow(2 - 2 * x, 3) / 2;

            public static float InQuart(float x) => Mathf.Pow(x, 4);

            public static float OutQuart(float x) => 1 - Mathf.Pow(1 - x, 4);

            public static float InOutQuart(float x) => x < .5f
                ? Mathf.Pow(2 * x, 4) / 2
                : 1 - Mathf.Pow(2 - 2 * x, 4) / 2;

            public static float InQuint(float x) => Mathf.Pow(x, 5);

            public static float OutQuint(float x) => 1 - Mathf.Pow(1 - x, 5);

            public static float InOutQuint(float x) => x < .5f
                ? Mathf.Pow(2 * x, 5) / 2
                : 1 - Mathf.Pow(2 - 2 * x, 5) / 2;

            public static float InExpo(float x) => x is 0 ? 0 : Mathf.Pow(2, 10 * x - 10);

            public static float OutExpo(float x) => x is 1 ? 1 : 1 - Mathf.Pow(2, -10 * x);

            public static float InOutExpo(float x) => x switch
            {
                0 or 1 => x,
                < .5f  => Mathf.Pow(2, 20 * x - 10) / 2,
                _      => (2 - Mathf.Pow(2, -20 * x + 10)) / 2,
            };

            public static float InCirc(float x) => 1 - Mathf.Sqrt(1 - Mathf.Pow(x, 2));

            public static float OutCirc(float x) => Mathf.Sqrt(1 - Mathf.Pow(x - 1, 2));

            public static float InOutCirc(float x) => x < .5f
                ? (1 - Mathf.Sqrt(1 - Mathf.Pow(2 * x, 2))) / 2
                : (Mathf.Sqrt(1 - Mathf.Pow(-2 * x + 2, 2)) + 1) / 2;

            public static float InBack(float x) => Mathf.Pow(x, 2) * (C3 * x - C1);

            public static float OutBack(float x) => 1 + Mathf.Pow(x - 1, 2) * (C3 * (x - 1) - C1);

            public static float InOutBack(float x) => x < .5f
                ? Mathf.Pow(2 * x, 2) * ((C2 + 1) * 2 * x - C2) / 2
                : (Mathf.Pow(2 * x - 2, 2) * ((C2 + 1) * (x * 2 - 2) + C2) + 2) / 2;

            public static float InElastic(float x) => x is 0 or 1 ? x : -Mathf.Pow(2, 10 * x - 10) * Mathf.Sin((x * 10 - 10.75f) * C4);

            public static float OutElastic(float x) => x is 0 or 1 ? x : Mathf.Pow(2, -10 * x) * Mathf.Sin((x * 10 - 0.75f) * C4) + 1;

            public static float InOutElastic(float x) => x switch
            {
                0 or 1 => x,
                < .5f  => -(Mathf.Pow(2, 20 * x - 10) * Mathf.Sin((20 * x - 11.125f) * C5)) / 2,
                _      => Mathf.Pow(2, -20 * x + 10) * Mathf.Sin((20 * x - 11.125f) * C5) / 2 + 1,
            };

            public static float InBounce(float x) => 1 - OutBounce(1 - x);

            public static float OutBounce(float x) => x switch
            {
                < 1 / D1    => N1 * x * x,
                < 2 / D1    => N1 * (x -= 1.5f / D1) * x + .75f,
                < 2.5f / D1 => N1 * (x -= 2.25f / D1) * x + .9375f,
                _           => N1 * (x -= 2.625f / D1) * x + .984375f,
            };

            public static float InOutBounce(float x) => x < .5f
                ? (1 - OutBounce(1 - 2 * x)) / 2
                : (1 + OutBounce(2 * x - 1)) / 2;

            public static EasingFunction FromType(Type type) => type switch
            {
                Type.Linear       => Linear,
                Type.InSince      => InSince,
                Type.OutSince     => OutSince,
                Type.InOutSince   => InOutSince,
                Type.InQuad       => InQuad,
                Type.OutQuad      => OutQuad,
                Type.InOutQuad    => InOutQuad,
                Type.InCubic      => InCubic,
                Type.OutCubic     => OutCubic,
                Type.InOutCubic   => InOutCubic,
                Type.InQuart      => InQuart,
                Type.OutQuart     => OutQuart,
                Type.InOutQuart   => InOutQuart,
                Type.InQuint      => InQuint,
                Type.OutQuint     => OutQuint,
                Type.InOutQuint   => InOutQuint,
                Type.InExpo       => InExpo,
                Type.OutExpo      => OutExpo,
                Type.InOutExpo    => InOutExpo,
                Type.InCirc       => InCirc,
                Type.OutCirc      => OutCirc,
                Type.InOutCirc    => InOutCirc,
                Type.InBack       => InBack,
                Type.OutBack      => OutBack,
                Type.InOutBack    => InOutBack,
                Type.InElastic    => InElastic,
                Type.OutElastic   => OutElastic,
                Type.InOutElastic => InOutElastic,
                Type.InBounce     => InBounce,
                Type.OutBounce    => OutBounce,
                Type.InOutBounce  => InOutBounce,
                _                 => throw new ArgumentOutOfRangeException(nameof(type), type, null),
            };
        }
    }
}