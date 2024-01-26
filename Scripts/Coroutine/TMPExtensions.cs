#if !UNIT_EASINGS_UNITASK && UNIT_EASINGS_TMP
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using TMPro;

    public static class TMPExtensions
    {
        public static IEnumerator Count(this TMP_Text tmp, float begin, float end, float duration, string format = "N2", Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var wrapper = new Action<float>(value => tmp.text = value.ToString(format));
            return Easing.Apply(wrapper, type, begin, end, duration, callback);
        }

        public static IEnumerator Count(this TMP_Text tmp, int begin, int end, float duration, string format = "N0", Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var wrapper = new Action<int>(value => tmp.text = value.ToString(format));
            return Easing.Apply(wrapper, type, begin, end, duration, callback);
        }
    }
}
#endif