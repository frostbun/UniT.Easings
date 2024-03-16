#if !UNIT_EASINGS_UNITASK && UNIT_EASINGS_TMP
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using TMPro;

    public static class TMPExtensions
    {
        public static IEnumerator Count(this TMP_Text tmp, float begin, float end, float duration, Func<float, string> formatter, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<float>(value => tmp.text = formatter(value));
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator Count(this TMP_Text tmp, int begin, int end, float duration, Func<int, string> formatter, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<int>(value => tmp.text = formatter(value));
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }
    }
}
#endif