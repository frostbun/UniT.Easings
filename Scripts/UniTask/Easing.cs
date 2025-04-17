#if UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;

    public static partial class Easing
    {
        public static async UniTask Apply(Action<float> action, float duration, Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            easing ??= Default;
            timer  ??= Timer.Default;
            var time = 0f;
            while (time < duration)
            {
                action(easing(time / duration));
                await UniTask.NextFrame(timing, cancellationToken);
                time += timer();
            }
            action(easing(1));
        }

        public static UniTask Apply(Action<float> action, float begin, float end, float duration, Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => action(begin + (end - begin) * value));
            return Apply(wrapper, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask Apply(Action<int> action, int begin, int end, float duration, Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var last = 0;
            var wrapper = new Action<float>(value =>
            {
                var curr = (int)value;
                if (curr == last) return;
                action(curr);
                last = curr;
            });
            return Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }
    }
}
#endif