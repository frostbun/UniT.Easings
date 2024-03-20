#if !UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;

    public static partial class TransformExtensions
    {
        #region Move

        public static IEnumerator MoveAsync(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.position = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveXAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.position);
            var setter = new Action<Vector3>(value => transform.position = value);
            return ApplyX(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveYAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.position);
            var setter = new Action<Vector3>(value => transform.position = value);
            return ApplyY(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveZAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.position);
            var setter = new Action<Vector3>(value => transform.position = value);
            return ApplyZ(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveAsync(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.MoveAsync(transform.position, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveXAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.MoveXAsync(transform.position.x, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveYAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.MoveYAsync(transform.position.y, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveZAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.MoveZAsync(transform.position.z, end, duration, type, ignoreTimeScale, callback);
        }

        #endregion

        #region LocalMove

        public static IEnumerator LocalMoveAsync(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.localPosition = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveXAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localPosition);
            var setter = new Action<Vector3>(value => transform.localPosition = value);
            return ApplyX(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveYAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localPosition);
            var setter = new Action<Vector3>(value => transform.localPosition = value);
            return ApplyY(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveZAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localPosition);
            var setter = new Action<Vector3>(value => transform.localPosition = value);
            return ApplyZ(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveAsync(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalMoveAsync(transform.localPosition, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveXAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalMoveXAsync(transform.localPosition.x, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveYAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalMoveYAsync(transform.localPosition.y, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveZAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalMoveZAsync(transform.localPosition.z, end, duration, type, ignoreTimeScale, callback);
        }

        #endregion

        #region Rotate

        public static IEnumerator RotateAsync(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return Apply(wrapper, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateXAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return ApplyX(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateYAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return ApplyY(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateZAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return ApplyZ(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateAsync(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.RotateAsync(transform.rotation.eulerAngles, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateXAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.RotateXAsync(transform.rotation.eulerAngles.x, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateYAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.RotateYAsync(transform.rotation.eulerAngles.y, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateZAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.RotateZAsync(transform.rotation.eulerAngles.z, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateAsync(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.RotateAsync(begin.eulerAngles, end.eulerAngles, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateAsync(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.RotateAsync(transform.rotation, end, duration, type, ignoreTimeScale, callback);
        }

        #endregion

        #region LocalRotate

        public static IEnumerator LocalRotateAsync(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return Apply(wrapper, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateXAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return ApplyX(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateYAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return ApplyY(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateZAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return ApplyZ(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateAsync(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalRotateAsync(transform.localRotation.eulerAngles, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateXAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalRotateXAsync(transform.localRotation.eulerAngles.x, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateYAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalRotateYAsync(transform.localRotation.eulerAngles.y, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateZAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalRotateZAsync(transform.localRotation.eulerAngles.z, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateAsync(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalRotateAsync(begin.eulerAngles, end.eulerAngles, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateAsync(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalRotateAsync(transform.localRotation, end, duration, type, ignoreTimeScale, callback);
        }

        #endregion

        #region LocalScale

        public static IEnumerator LocalScaleAsync(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.localScale = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleXAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localScale);
            var setter = new Action<Vector3>(value => transform.localScale = value);
            return ApplyX(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleYAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localScale);
            var setter = new Action<Vector3>(value => transform.localScale = value);
            return ApplyY(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleZAsync(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localScale);
            var setter = new Action<Vector3>(value => transform.localScale = value);
            return ApplyZ(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleAsync(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalScaleAsync(transform.localScale, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleXAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalScaleXAsync(transform.localScale.x, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleYAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalScaleYAsync(transform.localScale.y, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleZAsync(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalScaleZAsync(transform.localScale.z, end, duration, type, ignoreTimeScale, callback);
        }

        #endregion

        #region Private

        private static IEnumerator Apply(Action<Vector3> action, Easing.Type type, Vector3 begin, Vector3 end, float duration, bool ignoreTimeScale, Action callback)
        {
            var diff    = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Easing.Apply(wrapper, type, duration, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyX(Func<Vector3> getter, Action<Vector3> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var vector = getter();
                vector.x = value;
                setter(vector);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyY(Func<Vector3> getter, Action<Vector3> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var vector = getter();
                vector.y = value;
                setter(vector);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyZ(Func<Vector3> getter, Action<Vector3> setter, Easing.Type type, float begin, float end, float duration, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var vector = getter();
                vector.z = value;
                setter(vector);
            });
            return Easing.Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        #endregion
    }
}
#endif