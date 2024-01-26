#if !UNIT_EASINGS_UNITASK
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UnityEngine;

    public static class TransformExtensions
    {
        #region Move

        public static IEnumerator Move(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.position = value);
            return Apply(wrapper, type, begin, end, duration, callback);
        }

        public static IEnumerator MoveX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginPosition = transform.position;
            var endPosition   = beginPosition;
            beginPosition.x = begin;
            endPosition.x   = end;
            return transform.Move(beginPosition, endPosition, duration, type, callback);
        }

        public static IEnumerator MoveY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginPosition = transform.position;
            var endPosition   = beginPosition;
            beginPosition.y = begin;
            endPosition.y   = end;
            return transform.Move(beginPosition, endPosition, duration, type, callback);
        }

        public static IEnumerator MoveZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginPosition = transform.position;
            var endPosition   = beginPosition;
            beginPosition.z = begin;
            endPosition.z   = end;
            return transform.Move(beginPosition, endPosition, duration, type, callback);
        }

        public static IEnumerator Move(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.Move(transform.position, end, duration, type, callback);
        }

        public static IEnumerator MoveX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.MoveX(transform.position.x, end, duration, type, callback);
        }

        public static IEnumerator MoveY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.MoveY(transform.position.y, end, duration, type, callback);
        }

        public static IEnumerator MoveZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.MoveZ(transform.position.z, end, duration, type, callback);
        }

        #endregion

        #region LocalMove

        public static IEnumerator LocalMove(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.localPosition = value);
            return Apply(wrapper, type, begin, end, duration, callback);
        }

        public static IEnumerator LocalMoveX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginPosition = transform.localPosition;
            var endPosition   = beginPosition;
            beginPosition.x = begin;
            endPosition.x   = end;
            return transform.LocalMove(beginPosition, endPosition, duration, type, callback);
        }

        public static IEnumerator LocalMoveY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginPosition = transform.localPosition;
            var endPosition   = beginPosition;
            beginPosition.y = begin;
            endPosition.y   = end;
            return transform.LocalMove(beginPosition, endPosition, duration, type, callback);
        }

        public static IEnumerator LocalMoveZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginPosition = transform.localPosition;
            var endPosition   = beginPosition;
            beginPosition.z = begin;
            endPosition.z   = end;
            return transform.LocalMove(beginPosition, endPosition, duration, type, callback);
        }

        public static IEnumerator LocalMove(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalMove(transform.localPosition, end, duration, type, callback);
        }

        public static IEnumerator LocalMoveX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalMoveX(transform.localPosition.x, end, duration, type, callback);
        }

        public static IEnumerator LocalMoveY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalMoveY(transform.localPosition.y, end, duration, type, callback);
        }

        public static IEnumerator LocalMoveZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalMoveZ(transform.localPosition.z, end, duration, type, callback);
        }

        #endregion

        #region Rotate

        public static IEnumerator Rotate(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return Apply(wrapper, type, Wrap(begin, end), end, duration, callback);
        }

        public static IEnumerator Rotate(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.Rotate(begin.eulerAngles, end.eulerAngles, duration, type, callback);
        }

        public static IEnumerator RotateX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginRotation = transform.rotation.eulerAngles;
            var endRotation   = beginRotation;
            beginRotation.x = begin;
            endRotation.x   = end;
            return transform.Rotate(beginRotation, endRotation, duration, type, callback);
        }

        public static IEnumerator RotateY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginRotation = transform.rotation.eulerAngles;
            var endRotation   = beginRotation;
            beginRotation.y = begin;
            endRotation.y   = end;
            return transform.Rotate(beginRotation, endRotation, duration, type, callback);
        }

        public static IEnumerator RotateZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginRotation = transform.rotation.eulerAngles;
            var endRotation   = beginRotation;
            beginRotation.z = begin;
            endRotation.z   = end;
            return transform.Rotate(beginRotation, endRotation, duration, type, callback);
        }

        public static IEnumerator Rotate(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.Rotate(transform.rotation.eulerAngles, end, duration, type, callback);
        }

        public static IEnumerator Rotate(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.Rotate(transform.rotation, end, duration, type, callback);
        }

        public static IEnumerator RotateX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.RotateX(transform.rotation.eulerAngles.x, end, duration, type, callback);
        }

        public static IEnumerator RotateY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.RotateY(transform.rotation.eulerAngles.y, end, duration, type, callback);
        }

        public static IEnumerator RotateZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.RotateZ(transform.rotation.eulerAngles.z, end, duration, type, callback);
        }

        #endregion

        #region LocalRotate

        public static IEnumerator LocalRotate(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return Apply(wrapper, type, Wrap(begin, end), end, duration, callback);
        }

        public static IEnumerator LocalRotate(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalRotate(begin.eulerAngles, end.eulerAngles, duration, type, callback);
        }

        public static IEnumerator LocalRotateX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginRotation = transform.localRotation.eulerAngles;
            var endRotation   = beginRotation;
            beginRotation.x = begin;
            endRotation.x   = end;
            return transform.LocalRotate(beginRotation, endRotation, duration, type, callback);
        }

        public static IEnumerator LocalRotateY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginRotation = transform.localRotation.eulerAngles;
            var endRotation   = beginRotation;
            beginRotation.y = begin;
            endRotation.y   = end;
            return transform.LocalRotate(beginRotation, endRotation, duration, type, callback);
        }

        public static IEnumerator LocalRotateZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginRotation = transform.localRotation.eulerAngles;
            var endRotation   = beginRotation;
            beginRotation.z = begin;
            endRotation.z   = end;
            return transform.LocalRotate(beginRotation, endRotation, duration, type, callback);
        }

        public static IEnumerator LocalRotate(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalRotate(transform.localRotation, end, duration, type, callback);
        }

        public static IEnumerator LocalRotate(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalRotate(transform.localRotation.eulerAngles, end, duration, type, callback);
        }

        public static IEnumerator LocalRotateX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalRotateX(transform.localRotation.eulerAngles.x, end, duration, type, callback);
        }

        public static IEnumerator LocalRotateY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalRotateY(transform.localRotation.eulerAngles.y, end, duration, type, callback);
        }

        public static IEnumerator LocalRotateZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalRotateZ(transform.localRotation.eulerAngles.z, end, duration, type, callback);
        }

        #endregion

        #region Scale

        public static IEnumerator LocalScale(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var wrapper = new Action<Vector3>(value => transform.localScale = value);
            return Apply(wrapper, type, begin, end, duration, callback);
        }

        public static IEnumerator LocalScaleX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginScale = transform.localScale;
            var endScale   = beginScale;
            beginScale.x = begin;
            endScale.x   = end;
            return transform.LocalScale(beginScale, endScale, duration, type, callback);
        }

        public static IEnumerator LocalScaleY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginScale = transform.localScale;
            var endScale   = beginScale;
            beginScale.y = begin;
            endScale.y   = end;
            return transform.LocalScale(beginScale, endScale, duration, type, callback);
        }

        public static IEnumerator LocalScaleZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            var beginScale = transform.localScale;
            var endScale   = beginScale;
            beginScale.z = begin;
            endScale.z   = end;
            return transform.LocalScale(beginScale, endScale, duration, type, callback);
        }

        public static IEnumerator LocalScale(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalScale(transform.localScale, end, duration, type, callback);
        }

        public static IEnumerator LocalScaleX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalScaleX(transform.localScale.x, end, duration, type, callback);
        }

        public static IEnumerator LocalScaleY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalScaleY(transform.localScale.y, end, duration, type, callback);
        }

        public static IEnumerator LocalScaleZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, Action callback = null)
        {
            return transform.LocalScaleZ(transform.localScale.z, end, duration, type, callback);
        }

        #endregion

        private static IEnumerator Apply(Action<Vector3> action, Easing.Type type, Vector3 begin, Vector3 end, float duration, Action callback)
        {
            var diff    = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Easing.Apply(wrapper, type, duration, callback);
        }

        private static Vector3 Wrap(Vector3 begin, Vector3 end)
        {
            begin.x = Wrap(begin.x, end.x);
            begin.y = Wrap(begin.y, end.y);
            begin.z = Wrap(begin.z, end.z);
            return begin;

            static float Wrap(float begin, float end) => begin - 360 * Mathf.Round((begin - end) / 360);
        }
    }
}
#endif