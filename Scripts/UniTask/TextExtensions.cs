#if UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine.UI;
    #if UNIT_EASINGS_TMP
    using TMPro;
    #endif

    public static class TMPExtensions
    {
        public static UniTask CountAsync(this Text target, float begin, float end, float duration, Func<float, string> formatter, Easing.Function function = default, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask CountAsync(this Text target, int begin, int end, float duration, Func<int, string> formatter, Easing.Function function = default, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<int>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, timing, cancellationToken);
        }

        #if UNIT_EASINGS_TMP
        public static UniTask CountAsync(this TMP_Text target, float begin, float end, float duration, Func<float, string> formatter, Easing.Function function = default, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<float>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask CountAsync(this TMP_Text target, int begin, int end, float duration, Func<int, string> formatter, Easing.Function function = default, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<int>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, timing, cancellationToken);
        }
        #endif
    }
}
#endif