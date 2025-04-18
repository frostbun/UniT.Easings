#if UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine;

    public static partial class TransformExtensions
    {
        #region Move

        public static UniTask MoveAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => target.position = value);
            return Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask MoveXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.position);
            var setter = new Action<Vector3>(value => target.position = value);
            return ApplyX(getter, setter, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask MoveYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.position);
            var setter = new Action<Vector3>(value => target.position = value);
            return ApplyY(getter, setter, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask MoveZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.position);
            var setter = new Action<Vector3>(value => target.position = value);
            return ApplyZ(getter, setter, begin, end, duration, easing, timer, timing, cancellationToken);
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
            var wrapper = new Action<Vector3>(value => target.localPosition = value);
            return Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalMoveXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.localPosition);
            var setter = new Action<Vector3>(value => target.localPosition = value);
            return ApplyX(getter, setter, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalMoveYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.localPosition);
            var setter = new Action<Vector3>(value => target.localPosition = value);
            return ApplyY(getter, setter, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalMoveZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.localPosition);
            var setter = new Action<Vector3>(value => target.localPosition = value);
            return ApplyZ(getter, setter, begin, end, duration, easing, timer, timing, cancellationToken);
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
            var wrapper = new Action<Vector3>(value => target.rotation = Quaternion.Euler(value));
            return Apply(wrapper, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask RotateXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => target.rotation = Quaternion.Euler(value));
            return ApplyX(getter, setter, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask RotateYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => target.rotation = Quaternion.Euler(value));
            return ApplyY(getter, setter, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask RotateZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => target.rotation = Quaternion.Euler(value));
            return ApplyZ(getter, setter, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask RotateAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateAsync(target.rotation.eulerAngles, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask RotateXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateXAsync(target.rotation.eulerAngles.x, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask RotateYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateYAsync(target.rotation.eulerAngles.y, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask RotateZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateZAsync(target.rotation.eulerAngles.z, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask RotateAsync(this Transform target, Quaternion begin, Quaternion end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateAsync(begin.eulerAngles, end.eulerAngles, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask RotateAsync(this Transform target, Quaternion end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.RotateAsync(target.rotation, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        #endregion

        #region LocalRotate

        public static UniTask LocalRotateAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => target.localRotation = Quaternion.Euler(value));
            return Apply(wrapper, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => target.localRotation = Quaternion.Euler(value));
            return ApplyX(getter, setter, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => target.localRotation = Quaternion.Euler(value));
            return ApplyY(getter, setter, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => target.localRotation = Quaternion.Euler(value));
            return ApplyZ(getter, setter, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateAsync(target.localRotation.eulerAngles, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateXAsync(target.localRotation.eulerAngles.x, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateYAsync(target.localRotation.eulerAngles.y, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateZAsync(target.localRotation.eulerAngles.z, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateAsync(this Transform target, Quaternion begin, Quaternion end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateAsync(begin.eulerAngles, end.eulerAngles, duration, easing, normalize, timer, timing, cancellationToken);
        }

        public static UniTask LocalRotateAsync(this Transform target, Quaternion end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return target.LocalRotateAsync(target.localRotation, end, duration, easing, normalize, timer, timing, cancellationToken);
        }

        #endregion

        #region Scale

        public static UniTask ScaleAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(target.SetScale);
            return Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ScaleXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.lossyScale);
            var setter = new Action<Vector3>(target.SetScale);
            return ApplyX(getter, setter, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ScaleYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.lossyScale);
            var setter = new Action<Vector3>(target.SetScale);
            return ApplyY(getter, setter, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask ScaleZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.lossyScale);
            var setter = new Action<Vector3>(target.SetScale);
            return ApplyZ(getter, setter, begin, end, duration, easing, timer, timing, cancellationToken);
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
            var wrapper = new Action<Vector3>(value => target.localScale = value);
            return Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalScaleXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.localScale);
            var setter = new Action<Vector3>(value => target.localScale = value);
            return ApplyX(getter, setter, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalScaleYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.localScale);
            var setter = new Action<Vector3>(value => target.localScale = value);
            return ApplyY(getter, setter, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        public static UniTask LocalScaleZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => target.localScale);
            var setter = new Action<Vector3>(value => target.localScale = value);
            return ApplyZ(getter, setter, begin, end, duration, easing, timer, timing, cancellationToken);
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

        #region Private

        private static UniTask Apply(Action<Vector3> action, Vector3 begin, Vector3 end, float duration, Easing.Function? easing, Timer.Function? timer, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var diff    = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Easing.Apply(wrapper, duration, easing, timer, timing, cancellationToken);
        }

        private static UniTask ApplyX(Func<Vector3> getter, Action<Vector3> setter, float begin, float end, float duration, Easing.Function? easing, Timer.Function? timer, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.x = value;
                setter(next);
            });
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        private static UniTask ApplyY(Func<Vector3> getter, Action<Vector3> setter, float begin, float end, float duration, Easing.Function? easing, Timer.Function? timer, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.y = value;
                setter(next);
            });
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        private static UniTask ApplyZ(Func<Vector3> getter, Action<Vector3> setter, float begin, float end, float duration, Easing.Function? easing, Timer.Function? timer, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.z = value;
                setter(next);
            });
            return Easing.Apply(wrapper, begin, end, duration, easing, timer, timing, cancellationToken);
        }

        #endregion
    }
}
#endif