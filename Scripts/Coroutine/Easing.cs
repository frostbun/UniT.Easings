#if !UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;

    public static partial class Easing
    {
        public static IEnumerator Apply(Action<float> action, float duration, Function function = default, bool ignoreTimeScale = false, Action? callback = null)
        {
            var time = 0f;
            while (time < duration)
            {
                action(function.Calculate(time / duration));
                yield return null;
                time += ignoreTimeScale ? Time.unscaledDeltaTime : Time.deltaTime;
            }
            action(function.Calculate(1));
            callback?.Invoke();
        }

        public static IEnumerator Apply(Action<float> action, float begin, float end, float duration, Function function = default, bool ignoreTimeScale = false, Action? callback = null)
        {
            var wrapper = new Action<float>(value => action(begin + (end - begin) * value));
            return Apply(wrapper, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator Apply(Action<int> action, int begin, int end, float duration, Function function = default, bool ignoreTimeScale = false, Action? callback = null)
        {
            var last = 0;
            var wrapper = new Action<float>(value =>
            {
                var curr = (int)value;
                if (curr == last) return;
                action(curr);
                last = curr;
            });
            return Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }
    }
}
#endif