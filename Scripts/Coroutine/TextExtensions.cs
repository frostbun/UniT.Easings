#if !UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine.UI;
    using TMPro;

    public static class TextExtensions
    {
        public static IEnumerator CountAsync(this Text target, float begin, float end, float duration, Func<float, string> formatter, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var wrapper = new Action<float>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator CountAsync(this Text target, int begin, int end, float duration, Func<int, string> formatter, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var wrapper = new Action<int>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator CountAsync(this TMP_Text target, float begin, float end, float duration, Func<float, string> formatter, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var wrapper = new Action<float>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator CountAsync(this TMP_Text target, int begin, int end, float duration, Func<int, string> formatter, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var wrapper = new Action<int>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, callback);
        }
    }
}
#endif