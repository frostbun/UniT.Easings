#if !UNIT_EASINGS_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;

    public static partial class TransformExtensions
    {
        #region Move

        public static IEnumerator MoveAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => target.position = value);
            return Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveXAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.position);
            var setter = new Action<Vector3>(value => target.position = value);
            return ApplyX(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveYAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.position);
            var setter = new Action<Vector3>(value => target.position = value);
            return ApplyY(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveZAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.position);
            var setter = new Action<Vector3>(value => target.position = value);
            return ApplyZ(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveAsync(this Transform target, Vector3 end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.MoveAsync(target.position, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveXAsync(this Transform target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.MoveXAsync(target.position.x, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveYAsync(this Transform target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.MoveYAsync(target.position.y, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveZAsync(this Transform target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.MoveZAsync(target.position.z, end, duration, function, ignoreTimeScale, callback);
        }

        #endregion

        #region LocalMove

        public static IEnumerator LocalMoveAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => target.localPosition = value);
            return Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveXAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.localPosition);
            var setter = new Action<Vector3>(value => target.localPosition = value);
            return ApplyX(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveYAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.localPosition);
            var setter = new Action<Vector3>(value => target.localPosition = value);
            return ApplyY(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveZAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.localPosition);
            var setter = new Action<Vector3>(value => target.localPosition = value);
            return ApplyZ(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveAsync(this Transform target, Vector3 end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalMoveAsync(target.localPosition, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveXAsync(this Transform target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalMoveXAsync(target.localPosition.x, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveYAsync(this Transform target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalMoveYAsync(target.localPosition.y, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveZAsync(this Transform target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalMoveZAsync(target.localPosition.z, end, duration, function, ignoreTimeScale, callback);
        }

        #endregion

        #region Rotate

        public static IEnumerator RotateAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => target.rotation = Quaternion.Euler(value));
            return Apply(wrapper, normalize ? Normalize(begin, end) : begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateXAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => target.rotation = Quaternion.Euler(value));
            return ApplyX(getter, setter, normalize ? Normalize(begin, end) : begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateYAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => target.rotation = Quaternion.Euler(value));
            return ApplyY(getter, setter, normalize ? Normalize(begin, end) : begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateZAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => target.rotation = Quaternion.Euler(value));
            return ApplyZ(getter, setter, normalize ? Normalize(begin, end) : begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateAsync(this Transform target, Vector3 end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.RotateAsync(target.rotation.eulerAngles, end, duration, function, normalize, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateXAsync(this Transform target, float end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.RotateXAsync(target.rotation.eulerAngles.x, end, duration, function, normalize, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateYAsync(this Transform target, float end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.RotateYAsync(target.rotation.eulerAngles.y, end, duration, function, normalize, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateZAsync(this Transform target, float end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.RotateZAsync(target.rotation.eulerAngles.z, end, duration, function, normalize, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateAsync(this Transform target, Quaternion begin, Quaternion end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.RotateAsync(begin.eulerAngles, end.eulerAngles, duration, function, normalize, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateAsync(this Transform target, Quaternion end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.RotateAsync(target.rotation, end, duration, function, normalize, ignoreTimeScale, callback);
        }

        #endregion

        #region LocalRotate

        public static IEnumerator LocalRotateAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => target.localRotation = Quaternion.Euler(value));
            return Apply(wrapper, normalize ? Normalize(begin, end) : begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateXAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => target.localRotation = Quaternion.Euler(value));
            return ApplyX(getter, setter, normalize ? Normalize(begin, end) : begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateYAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => target.localRotation = Quaternion.Euler(value));
            return ApplyY(getter, setter, normalize ? Normalize(begin, end) : begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateZAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => target.localRotation = Quaternion.Euler(value));
            return ApplyZ(getter, setter, normalize ? Normalize(begin, end) : begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateAsync(this Transform target, Vector3 end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalRotateAsync(target.localRotation.eulerAngles, end, duration, function, normalize, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateXAsync(this Transform target, float end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalRotateXAsync(target.localRotation.eulerAngles.x, end, duration, function, normalize, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateYAsync(this Transform target, float end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalRotateYAsync(target.localRotation.eulerAngles.y, end, duration, function, normalize, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateZAsync(this Transform target, float end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalRotateZAsync(target.localRotation.eulerAngles.z, end, duration, function, normalize, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateAsync(this Transform target, Quaternion begin, Quaternion end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalRotateAsync(begin.eulerAngles, end.eulerAngles, duration, function, normalize, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateAsync(this Transform target, Quaternion end, float duration, Easing.Function function = default, bool normalize = true, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalRotateAsync(target.localRotation, end, duration, function, normalize, ignoreTimeScale, callback);
        }

        #endregion

        #region LocalScale

        public static IEnumerator LocalScaleAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => target.localScale = value);
            return Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleXAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.localScale);
            var setter = new Action<Vector3>(value => target.localScale = value);
            return ApplyX(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleYAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.localScale);
            var setter = new Action<Vector3>(value => target.localScale = value);
            return ApplyY(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleZAsync(this Transform target, float begin, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => target.localScale);
            var setter = new Action<Vector3>(value => target.localScale = value);
            return ApplyZ(getter, setter, begin, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleAsync(this Transform target, Vector3 end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalScaleAsync(target.localScale, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleXAsync(this Transform target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalScaleXAsync(target.localScale.x, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleYAsync(this Transform target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalScaleYAsync(target.localScale.y, end, duration, function, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleZAsync(this Transform target, float end, float duration, Easing.Function function = default, bool ignoreTimeScale = false, Action callback = null)
        {
            return target.LocalScaleZAsync(target.localScale.z, end, duration, function, ignoreTimeScale, callback);
        }

        #endregion

        #region Private

        private static IEnumerator Apply(Action<Vector3> action, Vector3 begin, Vector3 end, float duration, Easing.Function function, bool ignoreTimeScale, Action callback)
        {
            var diff    = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Easing.Apply(wrapper, duration, function, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyX(Func<Vector3> getter, Action<Vector3> setter, float begin, float end, float duration, Easing.Function function, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.x = value;
                setter(next);
            });
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyY(Func<Vector3> getter, Action<Vector3> setter, float begin, float end, float duration, Easing.Function function, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.y = value;
                setter(next);
            });
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        private static IEnumerator ApplyZ(Func<Vector3> getter, Action<Vector3> setter, float begin, float end, float duration, Easing.Function function, bool ignoreTimeScale, Action callback)
        {
            var wrapper = new Action<float>(value =>
            {
                var next = getter();
                next.z = value;
                setter(next);
            });
            return Easing.Apply(wrapper, begin, end, duration, function, ignoreTimeScale, callback);
        }

        #endregion
    }
}
#endif