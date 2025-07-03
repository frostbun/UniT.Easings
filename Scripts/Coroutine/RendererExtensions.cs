#if !UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;

    public static class RendererExtensions
    {
        public static IEnumerator BlendAsync(this SkinnedMeshRenderer target, int index, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(value => target.SetBlendShapeWeight(index, value), begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator BlendAsync(this SkinnedMeshRenderer target, int index, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.BlendAsync(index, target.GetBlendShapeWeight(index), end, duration, easing, timer, callback);
        }

        public static IEnumerator BlendInAsync(this SkinnedMeshRenderer target, int index, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.BlendAsync(index, 0, 100, duration, easing, timer, callback);
        }

        public static IEnumerator BlendOutAsync(this SkinnedMeshRenderer target, int index, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.BlendAsync(index, 100, 0, duration, easing, timer, callback);
        }
    }
}
#endif