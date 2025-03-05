#if !UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine.UI;

    public static class SliderExtensions
    {
        public static IEnumerator SlideAsync(this Slider target, float begin, float end, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, Action? callback = null)
        {
            var wrapper = new Action<float>(value => target.value = value);
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator SlideAsync(this Slider target, float end, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, Action? callback = null)
        {
            return target.SlideAsync(target.value, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator SlideInAsync(this Slider target, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, Action? callback = null)
        {
            return target.SlideAsync(0f, 1f, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator SlideOutAsync(this Slider target, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, Action? callback = null)
        {
            return target.SlideAsync(1f, 0f, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator FillAsync(this Image target, float begin, float end, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, Action? callback = null)
        {
            var wrapper = new Action<float>(value => target.fillAmount = value);
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator FillAsync(this Image target, float end, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, Action? callback = null)
        {
            return target.FillAsync(target.fillAmount, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator FillInAsync(this Image target, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, Action? callback = null)
        {
            return target.FillAsync(0f, 1f, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator FillOutAsync(this Image target, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, Action? callback = null)
        {
            return target.FillAsync(1f, 0f, duration, function, ignoreTimeScale, callback);
        }
    }
}
#endif