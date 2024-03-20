#if UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine;

    public static partial class TransformExtensions
    {
        #region Move

        public static UniTask MoveAsync(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.position = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveXAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.position);
            var setter = new Action<Vector3>(value => transform.position = value);
            return ApplyX(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveYAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.position);
            var setter = new Action<Vector3>(value => transform.position = value);
            return ApplyY(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveZAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.position);
            var setter = new Action<Vector3>(value => transform.position = value);
            return ApplyZ(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveAsync(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.MoveAsync(transform.position, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveXAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.MoveXAsync(transform.position.x, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveYAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.MoveYAsync(transform.position.y, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveZAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.MoveZAsync(transform.position.z, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        #endregion

        #region LocalMove

        public static UniTask LocalMoveAsync(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.localPosition = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveXAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localPosition);
            var setter = new Action<Vector3>(value => transform.localPosition = value);
            return ApplyX(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveYAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localPosition);
            var setter = new Action<Vector3>(value => transform.localPosition = value);
            return ApplyY(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveZAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localPosition);
            var setter = new Action<Vector3>(value => transform.localPosition = value);
            return ApplyZ(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveAsync(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalMoveAsync(transform.localPosition, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveXAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalMoveXAsync(transform.localPosition.x, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveYAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalMoveYAsync(transform.localPosition.y, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveZAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalMoveZAsync(transform.localPosition.z, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        #endregion

        #region Rotate

        public static UniTask RotateAsync(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return Apply(wrapper, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateXAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return ApplyX(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateYAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return ApplyY(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateZAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return ApplyZ(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateAsync(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateAsync(transform.rotation.eulerAngles, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateXAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateXAsync(transform.rotation.eulerAngles.x, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateYAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateYAsync(transform.rotation.eulerAngles.y, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateZAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateZAsync(transform.rotation.eulerAngles.z, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateAsync(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateAsync(begin.eulerAngles, end.eulerAngles, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateAsync(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateAsync(transform.rotation, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        #endregion

        #region LocalRotate

        public static UniTask LocalRotateAsync(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return Apply(wrapper, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateXAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return ApplyX(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateYAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return ApplyY(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateZAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return ApplyZ(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateAsync(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateAsync(transform.localRotation.eulerAngles, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateXAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateXAsync(transform.localRotation.eulerAngles.x, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateYAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateYAsync(transform.localRotation.eulerAngles.y, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateZAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateZAsync(transform.localRotation.eulerAngles.z, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateAsync(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateAsync(begin.eulerAngles, end.eulerAngles, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateAsync(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateAsync(transform.localRotation, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        #endregion

        #region LocalScale

        public static UniTask LocalScaleAsync(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.localScale = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleXAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localScale);
            var setter = new Action<Vector3>(value => transform.localScale = value);
            return ApplyX(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleYAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localScale);
            var setter = new Action<Vector3>(value => transform.localScale = value);
            return ApplyY(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleZAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localScale);
            var setter = new Action<Vector3>(value => transform.localScale = value);
            return ApplyZ(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleAsync(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalScaleAsync(transform.localScale, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleXAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalScaleXAsync(transform.localScale.x, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleYAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalScaleYAsync(transform.localScale.y, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleZAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalScaleZAsync(transform.localScale.z, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        #endregion

        #region Private

        private static UniTask Apply(Action<Vector3> action, Easing.Type type, Vector3 begin, Vector3 end, float duration, bool ignoreTimeScale, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var diff    = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Easing.Apply(wrapper, type, duration, ignoreTimeScale, timing, cancellationToken);
        }

        private static UniTask ApplyX(Func<Vector3> getter, Action<Vector3> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var wrapper = new Action<float>(value =>
            {
                var vector = getter();
                vector.x = value;
                setter(vector);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        private static UniTask ApplyY(Func<Vector3> getter, Action<Vector3> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var wrapper = new Action<float>(value =>
            {
                var vector = getter();
                vector.y = value;
                setter(vector);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        private static UniTask ApplyZ(Func<Vector3> getter, Action<Vector3> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var wrapper = new Action<float>(value =>
            {
                var vector = getter();
                vector.z = value;
                setter(vector);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        #endregion
    }
}
#endif