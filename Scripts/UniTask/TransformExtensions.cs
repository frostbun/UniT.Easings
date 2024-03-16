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

        public static UniTask Move(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.position = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.position);
            var setter = new Action<Vector3>(value => transform.position = value);
            return ApplyX(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.position);
            var setter = new Action<Vector3>(value => transform.position = value);
            return ApplyY(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.position);
            var setter = new Action<Vector3>(value => transform.position = value);
            return ApplyZ(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask Move(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.Move(transform.position, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.MoveX(transform.position.x, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.MoveY(transform.position.y, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask MoveZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.MoveZ(transform.position.z, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        #endregion

        #region LocalMove

        public static UniTask LocalMove(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.localPosition = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localPosition);
            var setter = new Action<Vector3>(value => transform.localPosition = value);
            return ApplyX(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localPosition);
            var setter = new Action<Vector3>(value => transform.localPosition = value);
            return ApplyY(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localPosition);
            var setter = new Action<Vector3>(value => transform.localPosition = value);
            return ApplyZ(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMove(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalMove(transform.localPosition, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalMoveX(transform.localPosition.x, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalMoveY(transform.localPosition.y, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalMoveZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalMoveZ(transform.localPosition.z, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        #endregion

        #region Rotate

        public static UniTask Rotate(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return Apply(wrapper, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return ApplyX(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return ApplyY(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return ApplyZ(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask Rotate(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.Rotate(transform.rotation.eulerAngles, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateX(transform.rotation.eulerAngles.x, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateY(transform.rotation.eulerAngles.y, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask RotateZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateZ(transform.rotation.eulerAngles.z, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask Rotate(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.Rotate(begin.eulerAngles, end.eulerAngles, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask Rotate(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.Rotate(transform.rotation, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        #endregion

        #region LocalRotate

        public static UniTask LocalRotate(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return Apply(wrapper, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return ApplyX(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return ApplyY(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return ApplyZ(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotate(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotate(transform.localRotation.eulerAngles, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateX(transform.localRotation.eulerAngles.x, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateY(transform.localRotation.eulerAngles.y, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotateZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateZ(transform.localRotation.eulerAngles.z, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotate(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotate(begin.eulerAngles, end.eulerAngles, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalRotate(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotate(transform.localRotation, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        #endregion

        #region LocalScale

        public static UniTask LocalScale(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.localScale = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localScale);
            var setter = new Action<Vector3>(value => transform.localScale = value);
            return ApplyX(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localScale);
            var setter = new Action<Vector3>(value => transform.localScale = value);
            return ApplyY(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var getter = new Func<Vector3>(() => transform.localScale);
            var setter = new Action<Vector3>(value => transform.localScale = value);
            return ApplyZ(getter, setter, type, begin, end, duration, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScale(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalScale(transform.localScale, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalScaleX(transform.localScale.x, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalScaleY(transform.localScale.y, end, duration, type, ignoreTimeScale, timing, cancellationToken);
        }

        public static UniTask LocalScaleZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalScaleZ(transform.localScale.z, end, duration, type, ignoreTimeScale, timing, cancellationToken);
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