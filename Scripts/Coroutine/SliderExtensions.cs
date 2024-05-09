#if !UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine.UI;

    public static class SliderExtensions
    {
        public static IEnumerator SlideAsync(this Slider target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<float>(value => target.value = value);
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator SlideAsync(this Slider target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.SlideAsync(target.value, end, duration, function, ignoreTimeScale, callback);
        }
    }
}
#endif