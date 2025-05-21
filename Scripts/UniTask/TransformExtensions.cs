#if UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UniT.Extensions;
    using UnityEngine;

    public static partial class TransformExtensions
    {
        #region Move

        public static UniTask MoveAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetPosition, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask MoveXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetPositionX, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask MoveYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetPositionY, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask MoveZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetPositionZ, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask MoveAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.MoveAsync(target.position, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask MoveXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.MoveXAsync(target.position.x, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask MoveYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.MoveYAsync(target.position.y, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask MoveZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.MoveZAsync(target.position.z, end, duration, easing, timer, timing, cancellationToken);
        }

        #endregion

        #region LocalMove

        public static UniTask LocalMoveAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalPosition, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalMoveXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalPositionX, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalMoveYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalPositionY, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalMoveZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalPositionZ, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalMoveAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalMoveAsync(target.localPosition, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalMoveXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalMoveXAsync(target.localPosition.x, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalMoveYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalMoveYAsync(target.localPosition.y, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalMoveZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalMoveZAsync(target.localPosition.z, end, duration, easing, timer, timing, cancellationToken);
        }

        #endregion

        #region Rotate

        public static UniTask RotateAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetEulerAngle, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask RotateXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetEulerAngleX, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask RotateYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetEulerAngleY, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask RotateZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetEulerAngleZ, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask RotateAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateAsync(target.eulerAngles, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask RotateXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateXAsync(target.eulerAngles.x, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask RotateYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateYAsync(target.eulerAngles.y, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask RotateZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateZAsync(target.eulerAngles.z, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask RotateAsync(this Transform target, Quaternion begin, Quaternion end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateAsync(begin.eulerAngles, end.eulerAngles, duration, easing, false, timer, timing, cancellationToken);
        }

        public static UniTask RotateAsync(this Transform target, Quaternion end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateAsync(target.rotation, end, duration, easing, timer, timing, cancellationToken);
        }

        #endregion

        #region LocalRotate

        public static UniTask LocalRotateAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalEulerAngle, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalEulerAngleX, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalEulerAngleY, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalEulerAngleZ, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateAsync(target.localEulerAngles, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateXAsync(target.localEulerAngles.x, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateYAsync(target.localEulerAngles.y, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateZAsync(target.localEulerAngles.z, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateAsync(this Transform target, Quaternion begin, Quaternion end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateAsync(begin.eulerAngles, end.eulerAngles, duration, easing, false, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateAsync(this Transform target, Quaternion end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateAsync(target.localRotation, end, duration, easing, timer, timing, cancellationToken);
        }

        #endregion

        #region Scale

        public static UniTask ScaleAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetScale, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ScaleXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetScaleX, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ScaleYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetScaleY, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ScaleZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetScaleZ, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ScaleAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ScaleAsync(target.lossyScale, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ScaleXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ScaleXAsync(target.lossyScale.x, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ScaleYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ScaleYAsync(target.lossyScale.y, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ScaleZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ScaleZAsync(target.lossyScale.z, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ScaleAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ScaleAsync(new Vector3(begin, begin, begin), new Vector3(end, end, end), duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ScaleAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.ScaleAsync(new Vector3(end, end, end), duration, easing, timer, timing, cancellationToken);
        }

        #endregion

        #region LocalScale

        public static UniTask LocalScaleAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalScale, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalScaleXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalScaleX, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalScaleYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalScaleY, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalScaleZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return Easing.Apply(target.SetLocalScaleZ, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalScaleAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleAsync(target.localScale, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalScaleXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleXAsync(target.localScale.x, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalScaleYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleYAsync(target.localScale.y, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalScaleZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleZAsync(target.localScale.z, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalScaleAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleAsync(new Vector3(begin, begin, begin), new Vector3(end, end, end), duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalScaleAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalScaleAsync(new Vector3(end, end, end), duration, easing, timer, timing, cancellationToken);
        }

        #endregion
    }
}
#endif