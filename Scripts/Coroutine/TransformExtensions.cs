#if !UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;

    public static partial class TransformExtensions
    {
        #region Move

        public static IEnumerator Move(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.position = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.position);
            var setter = new Action<Vector3>(value => transform.position = value);
            return ApplyX(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.position);
            var setter = new Action<Vector3>(value => transform.position = value);
            return ApplyY(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.position);
            var setter = new Action<Vector3>(value => transform.position = value);
            return ApplyZ(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator Move(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.Move(transform.position, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.MoveX(transform.position.x, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.MoveY(transform.position.y, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator MoveZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.MoveZ(transform.position.z, end, duration, type, ignoreTimeScale, callback);
        }

        #endregion

        #region LocalMove

        public static IEnumerator LocalMove(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.localPosition = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localPosition);
            var setter = new Action<Vector3>(value => transform.localPosition = value);
            return ApplyX(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localPosition);
            var setter = new Action<Vector3>(value => transform.localPosition = value);
            return ApplyY(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localPosition);
            var setter = new Action<Vector3>(value => transform.localPosition = value);
            return ApplyZ(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMove(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalMove(transform.localPosition, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalMoveX(transform.localPosition.x, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalMoveY(transform.localPosition.y, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalMoveZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalMoveZ(transform.localPosition.z, end, duration, type, ignoreTimeScale, callback);
        }

        #endregion

        #region Rotate

        public static IEnumerator Rotate(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return Apply(wrapper, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return ApplyX(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return ApplyY(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.rotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return ApplyZ(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator Rotate(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.Rotate(transform.rotation.eulerAngles, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.RotateX(transform.rotation.eulerAngles.x, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.RotateY(transform.rotation.eulerAngles.y, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator RotateZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.RotateZ(transform.rotation.eulerAngles.z, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator Rotate(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.Rotate(begin.eulerAngles, end.eulerAngles, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator Rotate(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.Rotate(transform.rotation, end, duration, type, ignoreTimeScale, callback);
        }

        #endregion

        #region LocalRotate

        public static IEnumerator LocalRotate(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return Apply(wrapper, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return ApplyX(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return ApplyY(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localRotation.eulerAngles);
            var setter = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return ApplyZ(getter, setter, type, Wrap(begin, end), end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotate(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalRotate(transform.localRotation.eulerAngles, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalRotateX(transform.localRotation.eulerAngles.x, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalRotateY(transform.localRotation.eulerAngles.y, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotateZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalRotateZ(transform.localRotation.eulerAngles.z, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotate(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalRotate(begin.eulerAngles, end.eulerAngles, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalRotate(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalRotate(transform.localRotation, end, duration, type, ignoreTimeScale, callback);
        }

        #endregion

        #region LocalScale

        public static IEnumerator LocalScale(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.localScale = value);
            return Apply(wrapper, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localScale);
            var setter = new Action<Vector3>(value => transform.localScale = value);
            return ApplyX(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localScale);
            var setter = new Action<Vector3>(value => transform.localScale = value);
            return ApplyY(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            var getter = new Func<Vector3>(() => transform.localScale);
            var setter = new Action<Vector3>(value => transform.localScale = value);
            return ApplyZ(getter, setter, type, begin, end, duration, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScale(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalScale(transform.localScale, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalScaleX(transform.localScale.x, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalScaleY(transform.localScale.y, end, duration, type, ignoreTimeScale, callback);
        }

        public static IEnumerator LocalScaleZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, bool ignoreTimeScale = false, Action callback = null)
        {
            return transform.LocalScaleZ(transform.localScale.z, end, duration, type, ignoreTimeScale, callback);
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