#if !UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Collections;
    #if UNIT_EASINGS_TMP
    using TMPro;
    #else
    using UnityEngine.UI;
    #endif

    public static class TextExtensions
    {
        #if UNIT_EASINGS_TMP
        public static IEnumerator CountAsync(this TMP_Text txt, float begin, float end, float duration, Func<float, string> formatter, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        #else
        public static IEnumerator CountAsync(this Text txt, float begin, float end, float duration, Func<float, string> formatter, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        #endif
        {
            var wrapper = new Action<float>(value => txt.text = formatter(value));
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        #if UNIT_EASINGS_TMP
        public static IEnumerator CountAsync(this TMP_Text txt, int begin, int end, float duration, Func<int, string> formatter, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        #else
        public static IEnumerator CountAsync(this Text txt, int begin, int end, float duration, Func<int, string> formatter, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        #endif
        {
            var wrapper = new Action<int>(value => txt.text = formatter(value));
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }
    }
}
#endif