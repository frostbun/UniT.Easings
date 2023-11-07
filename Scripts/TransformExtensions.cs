namespace UniT.Easings
{
    using System;
    using System.Threading;
    using Cysharp.Threading.Tasks;
    using UnityEngine;

    public static class TransformExtensions
    {
        #region Move

        public static UniTask Move(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.position = value);
            return Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask MoveX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginPosition = transform.position;
            var endPosition   = beginPosition;
            beginPosition.x = begin;
            endPosition.x   = end;
            return transform.Move(beginPosition, endPosition, duration, type, timing, cancellationToken);
        }

        public static UniTask MoveY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginPosition = transform.position;
            var endPosition   = beginPosition;
            beginPosition.y = begin;
            endPosition.y   = end;
            return transform.Move(beginPosition, endPosition, duration, type, timing, cancellationToken);
        }

        public static UniTask MoveZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginPosition = transform.position;
            var endPosition   = beginPosition;
            beginPosition.z = begin;
            endPosition.z   = end;
            return transform.Move(beginPosition, endPosition, duration, type, timing, cancellationToken);
        }

        public static UniTask Move(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.Move(transform.position, end, duration, type, timing, cancellationToken);
        }

        public static UniTask MoveX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.MoveX(transform.position.x, end, duration, type, timing, cancellationToken);
        }

        public static UniTask MoveY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.MoveY(transform.position.y, end, duration, type, timing, cancellationToken);
        }

        public static UniTask MoveZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.MoveZ(transform.position.z, end, duration, type, timing, cancellationToken);
        }

        #endregion

        #region LocalMove

        public static UniTask LocalMove(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.localPosition = value);
            return Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask LocalMoveX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginPosition = transform.localPosition;
            var endPosition   = beginPosition;
            beginPosition.x = begin;
            endPosition.x   = end;
            return transform.LocalMove(beginPosition, endPosition, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalMoveY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginPosition = transform.localPosition;
            var endPosition   = beginPosition;
            beginPosition.y = begin;
            endPosition.y   = end;
            return transform.LocalMove(beginPosition, endPosition, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalMoveZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginPosition = transform.localPosition;
            var endPosition   = beginPosition;
            beginPosition.z = begin;
            endPosition.z   = end;
            return transform.LocalMove(beginPosition, endPosition, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalMove(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalMove(transform.localPosition, end, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalMoveX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalMoveX(transform.localPosition.x, end, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalMoveY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalMoveY(transform.localPosition.y, end, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalMoveZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalMoveZ(transform.localPosition.z, end, duration, type, timing, cancellationToken);
        }

        #endregion

        #region Rotate

        public static UniTask Rotate(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.rotation = Quaternion.Euler(value));
            return Apply(wrapper, type, Wrap(begin, end), end, duration, timing, cancellationToken);
        }

        public static UniTask Rotate(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.Rotate(begin.eulerAngles, end.eulerAngles, duration, type, timing, cancellationToken);
        }

        public static UniTask RotateX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginRotation = transform.rotation.eulerAngles;
            var endRotation   = beginRotation;
            beginRotation.x = begin;
            endRotation.x   = end;
            return transform.Rotate(beginRotation, endRotation, duration, type, timing, cancellationToken);
        }

        public static UniTask RotateY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginRotation = transform.rotation.eulerAngles;
            var endRotation   = beginRotation;
            beginRotation.y = begin;
            endRotation.y   = end;
            return transform.Rotate(beginRotation, endRotation, duration, type, timing, cancellationToken);
        }

        public static UniTask RotateZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginRotation = transform.rotation.eulerAngles;
            var endRotation   = beginRotation;
            beginRotation.z = begin;
            endRotation.z   = end;
            return transform.Rotate(beginRotation, endRotation, duration, type, timing, cancellationToken);
        }

        public static UniTask Rotate(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.Rotate(transform.rotation.eulerAngles, end, duration, type, timing, cancellationToken);
        }

        public static UniTask Rotate(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.Rotate(transform.rotation, end, duration, type, timing, cancellationToken);
        }

        public static UniTask RotateX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateX(transform.rotation.eulerAngles.x, end, duration, type, timing, cancellationToken);
        }

        public static UniTask RotateY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateY(transform.rotation.eulerAngles.y, end, duration, type, timing, cancellationToken);
        }

        public static UniTask RotateZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateZ(transform.rotation.eulerAngles.z, end, duration, type, timing, cancellationToken);
        }

        #endregion

        #region LocalRotate

        public static UniTask LocalRotate(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.localRotation = Quaternion.Euler(value));
            return Apply(wrapper, type, Wrap(begin, end), end, duration, timing, cancellationToken);
        }

        public static UniTask LocalRotate(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotate(begin.eulerAngles, end.eulerAngles, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalRotateX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginRotation = transform.localRotation.eulerAngles;
            var endRotation   = beginRotation;
            beginRotation.x = begin;
            endRotation.x   = end;
            return transform.LocalRotate(beginRotation, endRotation, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalRotateY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginRotation = transform.localRotation.eulerAngles;
            var endRotation   = beginRotation;
            beginRotation.y = begin;
            endRotation.y   = end;
            return transform.LocalRotate(beginRotation, endRotation, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalRotateZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginRotation = transform.localRotation.eulerAngles;
            var endRotation   = beginRotation;
            beginRotation.z = begin;
            endRotation.z   = end;
            return transform.LocalRotate(beginRotation, endRotation, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalRotate(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotate(transform.localRotation, end, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalRotate(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotate(transform.localRotation.eulerAngles, end, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalRotateX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateX(transform.localRotation.eulerAngles.x, end, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalRotateY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateY(transform.localRotation.eulerAngles.y, end, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalRotateZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateZ(transform.localRotation.eulerAngles.z, end, duration, type, timing, cancellationToken);
        }

        #endregion

        #region Scale

        public static UniTask Scale(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var wrapper = new Action<Vector3>(value => transform.localScale = value);
            return Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask ScaleX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginScale = transform.localScale;
            var endScale   = beginScale;
            beginScale.x = begin;
            endScale.x   = end;
            return transform.Scale(beginScale, endScale, duration, type, timing, cancellationToken);
        }

        public static UniTask ScaleY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginScale = transform.localScale;
            var endScale   = beginScale;
            beginScale.y = begin;
            endScale.y   = end;
            return transform.Scale(beginScale, endScale, duration, type, timing, cancellationToken);
        }

        public static UniTask ScaleZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var beginScale = transform.localScale;
            var endScale   = beginScale;
            beginScale.z = begin;
            endScale.z   = end;
            return transform.Scale(beginScale, endScale, duration, type, timing, cancellationToken);
        }

        public static UniTask Scale(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.Scale(transform.localScale, end, duration, type, timing, cancellationToken);
        }

        public static UniTask ScaleX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.ScaleX(transform.localScale.x, end, duration, type, timing, cancellationToken);
        }

        public static UniTask ScaleY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.ScaleY(transform.localScale.y, end, duration, type, timing, cancellationToken);
        }

        public static UniTask ScaleZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.ScaleZ(transform.localScale.z, end, duration, type, timing, cancellationToken);
        }

        #endregion

        private static UniTask Apply(Action<Vector3> action, Easing.Type type, Vector3 begin, Vector3 end, float duration, PlayerLoopTiming timing, CancellationToken cancellationToken)
        {
            var diff    = end - begin;
            var wrapper = new Action<float>(value => action(begin + diff * value));
            return Easing.Apply(wrapper, type, duration, timing, cancellationToken);
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