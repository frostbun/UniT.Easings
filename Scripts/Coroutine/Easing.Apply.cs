#if !UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;

    public static partial class Easing
    {
        public static IEnumerator Apply(Action<float> action, float duration, Function? easing = null, Timer? timer = null, Timing timing = Timing.Update, Action? callback = null)
        {
            easing ??= DefaultFunction;
            timer  ??= DefaultTimer;
            var yieldInstruction = timing switch
            {
                Timing.Update      => default(YieldInstruction),
                Timing.LateUpdate  => new WaitForEndOfFrame(),
                Timing.FixedUpdate => new WaitForFixedUpdate(),
                _                  => throw new ArgumentOutOfRangeException(nameof(timing), timing, null),
            };
            var time = 0f;
            while (time < duration)
            {
                action(easing(time / duration));
                yield return yieldInstruction;
                time += timer();
            }
            action(easing(1));
            callback?.Invoke();
        }

        public static IEnumerator Apply(Action<float> action, float begin, float end, float duration, Function? easing = null, Timer? timer = null, Timing timing = Timing.Update, Action? callback = null)
        {
            var wrapper = new Action<float>(value => action(begin + (end - begin) * value));
            return Apply(wrapper, duration, easing, timer, timing, callback);
        }

        public static IEnumerator Apply(Action<int> action, int begin, int end, float duration, Function? easing = null, Timer? timer = null, Timing timing = Timing.Update, Action? callback = null)
        {
            var last = 0;
            var wrapper = new Action<float>(value =>
            {
                var curr = (int)value;
                if (curr == last) return;
                action(curr);
                last = curr;
            });
            return Apply(wrapper, begin, end, duration, easing, timer, timing, callback);
        }

        public static IEnumerator Apply(Action<Vector3> action, Vector3 begin, Vector3 end, float duration, Function? easing = null, Timer? timer = null, Timing timing = Timing.Update, Action? callback = null)
        {
            var wrapper = new Action<float>(value => action(Vector3.Lerp(begin, end, value)));
            return Apply(wrapper, duration, easing, timer, timing, callback);
        }

        public static IEnumerator Apply(Action<Color> action, Color begin, Color end, float duration, Function? easing = null, Timer? timer = null, Timing timing = Timing.Update, Action? callback = null)
        {
            var wrapper = new Action<float>(value => action(Color.Lerp(begin, end, value)));
            return Apply(wrapper, duration, easing, timer, timing, callback);
        }
    }
}
#endif