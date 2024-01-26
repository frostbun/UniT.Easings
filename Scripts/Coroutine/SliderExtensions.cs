#if !UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine.UI;

    public static class SliderExtensions
    {
        public static IEnumerator Slide(this Slider slider, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var wrapper = new Action<float>(value => slider.value = value);
            return Easing.Apply(wrapper, type, begin, end, duration, callback);
        }

        public static IEnumerator Slide(this Slider slider, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return slider.Slide(slider.value, end, duration, type, callback);
        }
    }
}
#endif