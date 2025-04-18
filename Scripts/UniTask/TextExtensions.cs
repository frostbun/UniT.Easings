#if UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine.UI;
    using TMPro;

    public static class TMPExtensions
    {
        public static UniTask CountAsync(this Text target, float begin, float end, float duration, Func<float, string> formatter, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask CountAsync(this Text target, int begin, int end, float duration, Func<int, string> formatter, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<int>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask CountAsync(this TMP_Text target, float begin, float end, float duration, Func<float, string> formatter, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask CountAsync(this TMP_Text target, int begin, int end, float duration, Func<int, string> formatter, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<int>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }
    }
}
#endif