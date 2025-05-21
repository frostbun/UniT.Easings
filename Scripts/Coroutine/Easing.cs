#if !UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;

    public static partial class Easing
    {
        public static IEnumerator Apply(Action<float> action, float duration, Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            easing ??= Default;
            timer  ??= Timer.Default;
            var time = 0f;
            while (time < duration)
            {
                action(easing(time / duration));
                yield return null;
                time += timer();
            }
            action(easing(1));
            callback?.Invoke();
        }

        public static IEnumerator Apply(Action<float> action, float begin, float end, float duration, Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var wrapper = new Action<float>(value => action(begin + (end - begin) * value));
            return Apply(wrapper, duration, easing, timer, callback);
        }

        public static IEnumerator Apply(Action<int> action, int begin, int end, float duration, Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var last = 0;
            var wrapper = new Action<float>(value =>
            {
                var curr = (int)value;
                if (curr == last) return;
                action(curr);
                last = curr;
            });
            return Apply(wrapper, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator Apply(Action<Vector3> action, Vector3 begin, Vector3 end, float duration, Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var diff    = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Apply(wrapper, duration, easing, timer, callback);
        }
    }
}
#endif