#if !UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;

    public static class CanvasGroupExtensions
    {
        public static IEnumerator FadeAsync(this CanvasGroup target, float begin, float end, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, Action? callback = null)
        {
            var wrapper = new Action<float>(value => target.alpha = value);
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator FadeAsync(this CanvasGroup target, float end, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, Action? callback = null)
        {
            return target.FadeAsync(target.alpha, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator FadeInAsync(this CanvasGroup target, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, Action? callback = null)
        {
            return target.FadeAsync(0f, 1f, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator FadeOutAsync(this CanvasGroup target, float duration, Easing.Function? function = null, bool ignoreTimeScale = false, Action? callback = null)
        {
            return target.FadeAsync(1f, 0f, duration, function, ignoreTimeScale, callback);
        }
    }
}
#endif