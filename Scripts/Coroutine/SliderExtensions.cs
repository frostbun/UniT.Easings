#if !UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine.UI;

    public static class SliderExtensions
    {
        public static IEnumerator SlideAsync(this Slider target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var wrapper = new Action<float>(value => target.value = value);
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator SlideAsync(this Slider target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.SlideAsync(target.value, end, duration, easing, timer, callback);
        }

        public static IEnumerator SlideInAsync(this Slider target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.SlideAsync(0, 1, duration, easing, timer, callback);
        }

        public static IEnumerator SlideOutAsync(this Slider target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.SlideAsync(1, 0, duration, easing, timer, callback);
        }

        public static IEnumerator FillAsync(this Image target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            var wrapper = new Action<float>(value => target.fillAmount = value);
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator FillAsync(this Image target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FillAsync(target.fillAmount, end, duration, easing, timer, callback);
        }

        public static IEnumerator FillInAsync(this Image target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FillAsync(0, 1, duration, easing, timer, callback);
        }

        public static IEnumerator FillOutAsync(this Image target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.FillAsync(1, 0, duration, easing, timer, callback);
        }
    }
}
#endif