#if UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine;

    public static class RendererExtensions
    {
        public static UniTask BlendAsync(this SkinnedMeshRenderer target, int index, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(value => target.SetBlendShapeWeight(index, value), begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask BlendAsync(this SkinnedMeshRenderer target, int index, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.BlendAsync(index, target.GetBlendShapeWeight(index), end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask BlendInAsync(this SkinnedMeshRenderer target, int index, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.BlendAsync(index, 0, 100, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask BlendOutAsync(this SkinnedMeshRenderer target, int index, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.BlendAsync(index, 100, 0, duration, easing, timer, timing, cancellationToken);
        }
    }
}
#endif