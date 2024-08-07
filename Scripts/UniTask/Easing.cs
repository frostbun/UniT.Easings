#if UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine;

    public static partial class Easing
    {
        public static async UniTask Apply(Action<float> action, float duration, Function? function = null, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            function ??= Default;
            var time = 0f;
            while (time < duration)
            {
                action(function(time / duration));
                await UniTask.NextFrame(timing, cancellationToken);
                time += timing is PlayerLoopTiming.FixedUpdate or PlayerLoopTiming.LastFixedUpdate
                    ? ignoreTimeScale ? Time.fixedUnscaledDeltaTime : Time.fixedDeltaTime
                    : ignoreTimeScale ? Time.unscaledDeltaTime : Time.deltaTime;
            }
            action(function(1));
        }

        public static UniTask Apply(Action<float> action, float begin, float end, float duration, Function? function = null, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => action(begin + (end - begin) * value));
            return Apply(wrapper, duration, function, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask Apply(Action<int> action, int begin, int end, float duration, Function? function = null, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
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