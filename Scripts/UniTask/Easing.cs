#if UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine;

    public static partial class Easing
    {
        public static async UniTask Apply(Action<float> action, float duration, Function function = default, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var time = 0f;
            while (time < duration)
            {
                action(function.Calculate(time / duration));
                await UniTask.NextFrame(timing, cancellationToken);
                time += ignoreTimeScale ? Time.unscaledDeltaTime : Time.deltaTime;
            }
            action(function.Calculate(1));
        }

        public static UniTask Apply(Action<float> action, float begin, float end, float duration, Function function = default, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => action(begin + (end - begin) * value));
            return Apply(wrapper, duration, function, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask Apply(Action<int> action, int begin, int end, float duration, Function function = default, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var last = 0;
            var wrapper = new Action<float>(value =>
            {
                var curr = (int)value;
                if (curr == last) return;
                action(curr);
                last = curr;
            });
            return Apply(wrapper, begin, end, duration, function, ignoreTimeScale, timing, cancellationToken);
        }
    }
}
#endif