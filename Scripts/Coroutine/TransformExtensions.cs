#if !UNIT_UNITASK
#nullable enable
namespace UniT.Easings
{
    using System;
    using System.Collections;
    using UniT.Extensions;
    using UnityEngine;

    public static partial class TransformExtensions
    {
        #region Move

        public static IEnumerator MoveAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetPosition, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator MoveXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetPositionX, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator MoveYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetPositionY, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator MoveZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetPositionZ, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator MoveAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.MoveAsync(target.position, end, duration, easing, timer, callback);
        }

        public static IEnumerator MoveXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.MoveXAsync(target.position.x, end, duration, easing, timer, callback);
        }

        public static IEnumerator MoveYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.MoveYAsync(target.position.y, end, duration, easing, timer, callback);
        }

        public static IEnumerator MoveZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.MoveZAsync(target.position.z, end, duration, easing, timer, callback);
        }

        public static IEnumerator ResetPositionAsync(this Transform target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.MoveAsync(Vector3.zero, duration, easing, timer, callback);
        }

        #endregion

        #region LocalMove

        public static IEnumerator LocalMoveAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetLocalPosition, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalMoveXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetLocalPositionX, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalMoveYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetLocalPositionY, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalMoveZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetLocalPositionZ, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalMoveAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalMoveAsync(target.localPosition, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalMoveXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalMoveXAsync(target.localPosition.x, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalMoveYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalMoveYAsync(target.localPosition.y, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalMoveZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalMoveZAsync(target.localPosition.z, end, duration, easing, timer, callback);
        }

        public static IEnumerator ResetLocalPositionAsync(this Transform target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalMoveAsync(Vector3.zero, duration, easing, timer, callback);
        }

        #endregion

        #region Rotate

        public static IEnumerator RotateAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetEulerAngle, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator RotateXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetEulerAngleX, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator RotateYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetEulerAngleY, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator RotateZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetEulerAngleZ, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator RotateAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return target.RotateAsync(target.eulerAngles, end, duration, easing, normalize, timer, callback);
        }

        public static IEnumerator RotateXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return target.RotateXAsync(target.eulerAngles.x, end, duration, easing, normalize, timer, callback);
        }

        public static IEnumerator RotateYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return target.RotateYAsync(target.eulerAngles.y, end, duration, easing, normalize, timer, callback);
        }

        public static IEnumerator RotateZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return target.RotateZAsync(target.eulerAngles.z, end, duration, easing, normalize, timer, callback);
        }

        public static IEnumerator RotateAsync(this Transform target, Quaternion begin, Quaternion end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.RotateAsync(begin.eulerAngles, end.eulerAngles, duration, easing, false, timer, callback);
        }

        public static IEnumerator RotateAsync(this Transform target, Quaternion end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.RotateAsync(target.rotation, end, duration, easing, timer, callback);
        }

        public static IEnumerator ResetRotationAsync(this Transform target, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return target.RotateAsync(Vector3.zero, duration, easing, normalize, timer, callback);
        }

        #endregion

        #region LocalRotate

        public static IEnumerator LocalRotateAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetLocalEulerAngle, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalRotateXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetLocalEulerAngleX, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalRotateYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetLocalEulerAngleY, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalRotateZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetLocalEulerAngleZ, normalize ? Normalize(begin, end) : begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalRotateAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalRotateAsync(target.localEulerAngles, end, duration, easing, normalize, timer, callback);
        }

        public static IEnumerator LocalRotateXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalRotateXAsync(target.localEulerAngles.x, end, duration, easing, normalize, timer, callback);
        }

        public static IEnumerator LocalRotateYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalRotateYAsync(target.localEulerAngles.y, end, duration, easing, normalize, timer, callback);
        }

        public static IEnumerator LocalRotateZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalRotateZAsync(target.localEulerAngles.z, end, duration, easing, normalize, timer, callback);
        }

        public static IEnumerator LocalRotateAsync(this Transform target, Quaternion begin, Quaternion end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalRotateAsync(begin.eulerAngles, end.eulerAngles, duration, easing, false, timer, callback);
        }

        public static IEnumerator LocalRotateAsync(this Transform target, Quaternion end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalRotateAsync(target.localRotation, end, duration, easing, timer, callback);
        }

        public static IEnumerator ResetLocalRotationAsync(this Transform target, float duration, Easing.Function? easing = null, bool normalize = true, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalRotateAsync(Vector3.zero, duration, easing, normalize, timer, callback);
        }

        #endregion

        #region Scale

        public static IEnumerator ScaleAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetScale, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator ScaleXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetScaleX, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator ScaleYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetScaleY, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator ScaleZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetScaleZ, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator ScaleAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.ScaleAsync(target.lossyScale, end, duration, easing, timer, callback);
        }

        public static IEnumerator ScaleXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.ScaleXAsync(target.lossyScale.x, end, duration, easing, timer, callback);
        }

        public static IEnumerator ScaleYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.ScaleYAsync(target.lossyScale.y, end, duration, easing, timer, callback);
        }

        public static IEnumerator ScaleZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.ScaleZAsync(target.lossyScale.z, end, duration, easing, timer, callback);
        }

        public static IEnumerator ScaleAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.ScaleAsync(new Vector3(begin, begin, begin), new Vector3(end, end, end), duration, easing, timer, callback);
        }

        public static IEnumerator ScaleAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.ScaleAsync(new Vector3(end, end, end), duration, easing, timer, callback);
        }

        public static IEnumerator ScaleInAsync(this Transform target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.ScaleAsync(0, 1, duration, easing, timer, callback);
        }

        public static IEnumerator ScaleOutAsync(this Transform target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.ScaleAsync(1, 0, duration, easing, timer, callback);
        }

        #endregion

        #region LocalScale

        public static IEnumerator LocalScaleAsync(this Transform target, Vector3 begin, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetLocalScale, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalScaleXAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetLocalScaleX, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalScaleYAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetLocalScaleY, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalScaleZAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return Easing.Apply(target.SetLocalScaleZ, begin, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalScaleAsync(this Transform target, Vector3 end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalScaleAsync(target.localScale, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalScaleXAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalScaleXAsync(target.localScale.x, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalScaleYAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalScaleYAsync(target.localScale.y, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalScaleZAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalScaleZAsync(target.localScale.z, end, duration, easing, timer, callback);
        }

        public static IEnumerator LocalScaleAsync(this Transform target, float begin, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalScaleAsync(new Vector3(begin, begin, begin), new Vector3(end, end, end), duration, easing, timer, callback);
        }

        public static IEnumerator LocalScaleAsync(this Transform target, float end, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalScaleAsync(new Vector3(end, end, end), duration, easing, timer, callback);
        }

        public static IEnumerator LocalScaleInAsync(this Transform target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalScaleAsync(0, 1, duration, easing, timer, callback);
        }

        public static IEnumerator LocalScaleOutAsync(this Transform target, float duration, Easing.Function? easing = null, Timer.Function? timer = null, Action? callback = null)
        {
            return target.LocalScaleAsync(1, 0, duration, easing, timer, callback);
        }

        #endregion
    }
}
#endif