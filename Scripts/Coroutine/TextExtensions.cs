#if !UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine.UI;
    #if UNIT_EASINGS_TMP
    using TMPro;
    #endif

    public static class TextExtensions
    {
        public static IEnumerator CountAsync(this Text target, float begin, float end, float duration, Func<float, string> formatter, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<float>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator CountAsync(this Text target, int begin, int end, float duration, Func<int, string> formatter, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<int>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        #if UNIT_EASINGS_TMP
        public static IEnumerator CountAsync(this TMP_Text target, float begin, float end, float duration, Func<float, string> formatter, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<float>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator CountAsync(this TMP_Text target, int begin, int end, float duration, Func<int, string> formatter, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<int>(value => target.text = formatter(value));
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }
        #endif
    }
}
#endif