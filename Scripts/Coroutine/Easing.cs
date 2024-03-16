#if !UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;

    public static partial class Easing
    {
        #region Basic

        public static IEnumerator Apply(Action<float> action, Function.Delegate easingFunction, float duration, bool ignoreTimeScale = false, Action callback = null)
        {
            var time = 0f;
            while (time < duration)
            {
                action(easingFunction(time / duration));
                yield return null;
                time += ignoreTimeScale ? Time.unscaledDeltaTime : Time.deltaTime;
            }
            action(easingFunction(1));
            callback?.Invoke();
        }

        #region Extensions

        public static IEnumerator Apply(Action<float> action, Type type, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.FromType(type), duration, ignoreTimeScale, callback);

        public static IEnumerator Linear(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.Linear, duration, ignoreTimeScale, callback);

        public static IEnumerator InSince(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InSince, duration, ignoreTimeScale, callback);

        public static IEnumerator OutSince(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutSince, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutSince(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutSince, duration, ignoreTimeScale, callback);

        public static IEnumerator InQuad(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InQuad, duration, ignoreTimeScale, callback);

        public static IEnumerator OutQuad(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutQuad, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutQuad(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutQuad, duration, ignoreTimeScale, callback);

        public static IEnumerator InCubic(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InCubic, duration, ignoreTimeScale, callback);

        public static IEnumerator OutCubic(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutCubic, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutCubic(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutCubic, duration, ignoreTimeScale, callback);

        public static IEnumerator InQuart(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InQuart, duration, ignoreTimeScale, callback);

        public static IEnumerator OutQuart(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutQuart, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutQuart(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutQuart, duration, ignoreTimeScale, callback);

        public static IEnumerator InQuint(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InQuint, duration, ignoreTimeScale, callback);

        public static IEnumerator OutQuint(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutQuint, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutQuint(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutQuint, duration, ignoreTimeScale, callback);

        public static IEnumerator InExpo(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InExpo, duration, ignoreTimeScale, callback);

        public static IEnumerator OutExpo(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutExpo, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutExpo(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutExpo, duration, ignoreTimeScale, callback);

        public static IEnumerator InCirc(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InCirc, duration, ignoreTimeScale, callback);

        public static IEnumerator OutCirc(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutCirc, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutCirc(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutCirc, duration, ignoreTimeScale, callback);

        public static IEnumerator InBack(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InBack, duration, ignoreTimeScale, callback);

        public static IEnumerator OutBack(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutBack, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutBack(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutBack, duration, ignoreTimeScale, callback);

        public static IEnumerator InElastic(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InElastic, duration, ignoreTimeScale, callback);

        public static IEnumerator OutElastic(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutElastic, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutElastic(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutElastic, duration, ignoreTimeScale, callback);

        public static IEnumerator InBounce(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InBounce, duration, ignoreTimeScale, callback);

        public static IEnumerator OutBounce(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutBounce, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutBounce(Action<float> action, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutBounce, duration, ignoreTimeScale, callback);

        #endregion

        #endregion

        #region Range

        public static IEnumerator Apply(Action<float> action, Function.Delegate easingFunction, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<float>(value => action(begin + (end - begin) * value));
            return Apply(wrapper, easingFunction, duration, ignoreTimeScale, callback);
        }

        #region Extensions

        public static IEnumerator Apply(Action<float> action, Type type, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.FromType(type), begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator Linear(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.Linear, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InSince(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InSince, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutSince(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutSince, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutSince(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutSince, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InQuad(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InQuad, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutQuad(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutQuad, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutQuad(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutQuad, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InCubic(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InCubic, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutCubic(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutCubic, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutCubic(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutCubic, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InQuart(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InQuart, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutQuart(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutQuart, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutQuart(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutQuart, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InQuint(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InQuint, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutQuint(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutQuint, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutQuint(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutQuint, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InExpo(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InExpo, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutExpo(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutExpo, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutExpo(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutExpo, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InCirc(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InCirc, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutCirc(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutCirc, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutCirc(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutCirc, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InBack(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InBack, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutBack(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutBack, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutBack(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutBack, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InElastic(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InElastic, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutElastic(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutElastic, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutElastic(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutElastic, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InBounce(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InBounce, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutBounce(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutBounce, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutBounce(Action<float> action, float begin, float end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutBounce, begin, end, duration, ignoreTimeScale, callback);

        #endregion

        #endregion

        #region Integer

        public static IEnumerator Apply(Action<int> action, Function.Delegate easingFunction, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null)
        {
            var last = 0;
            var wrapper = new Action<float>(value =>
            {
                var curr = (int)value;
                if (curr == last) return;
                action(curr);
                last = curr;
            });
            return Apply(wrapper, easingFunction, begin, end, duration, ignoreTimeScale, callback);
        }

        #region Extensions

        public static IEnumerator Apply(Action<int> action, Type type, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.FromType(type), begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator Linear(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.Linear, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InSince(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InSince, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutSince(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutSince, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutSince(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutSince, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InQuad(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InQuad, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutQuad(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutQuad, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutQuad(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutQuad, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InCubic(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InCubic, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutCubic(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutCubic, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutCubic(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutCubic, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InQuart(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InQuart, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutQuart(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutQuart, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutQuart(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutQuart, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InQuint(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InQuint, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutQuint(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutQuint, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutQuint(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutQuint, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InExpo(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InExpo, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutExpo(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutExpo, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutExpo(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutExpo, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InCirc(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InCirc, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutCirc(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutCirc, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutCirc(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutCirc, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InBack(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InBack, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutBack(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutBack, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutBack(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutBack, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InElastic(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InElastic, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutElastic(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutElastic, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutElastic(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutElastic, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InBounce(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InBounce, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator OutBounce(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.OutBounce, begin, end, duration, ignoreTimeScale, callback);

        public static IEnumerator InOutBounce(Action<int> action, int begin, int end, float duration, bool ignoreTimeScale = false, Action callback = null) => Apply(action, Function.InOutBounce, begin, end, duration, ignoreTimeScale, callback);

        #endregion

        #endregion
    }
}
#endif