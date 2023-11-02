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
            var diff    = end - begin;
            var wrapper = new Action<float>(value => transform.position = begin + diff * value);
            return Easing.Apply(wrapper, type, duration, timing, cancellationToken);
        }

        public static UniTask MoveX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var position = transform.position;
            var wrapper = new Action<float>(value =>
            {
                position.x         = value;
                transform.position = position;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask MoveY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var position = transform.position;
            var wrapper = new Action<float>(value =>
            {
                position.y         = value;
                transform.position = position;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask MoveZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var position = transform.position;
            var wrapper = new Action<float>(value =>
            {
                position.z         = value;
                transform.position = position;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
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
            var diff    = end - begin;
            var wrapper = new Action<float>(value => transform.localPosition = begin + diff * value);
            return Easing.Apply(wrapper, type, duration, timing, cancellationToken);
        }

        public static UniTask LocalMoveX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var position = transform.localPosition;
            var wrapper = new Action<float>(value =>
            {
                position.x              = value;
                transform.localPosition = position;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask LocalMoveY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var position = transform.localPosition;
            var wrapper = new Action<float>(value =>
            {
                position.y              = value;
                transform.localPosition = position;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask LocalMoveZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var position = transform.localPosition;
            var wrapper = new Action<float>(value =>
            {
                position.z              = value;
                transform.localPosition = position;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
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

        public static UniTask Rotate(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var diff    = end * Quaternion.Inverse(begin);
            var wrapper = new Action<float>(value => transform.rotation = begin * Quaternion.SlerpUnclamped(Quaternion.identity, diff, value));
            return Easing.Apply(wrapper, type, duration, timing, cancellationToken);
        }

        public static UniTask Rotate(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.Rotate(Quaternion.Euler(begin), Quaternion.Euler(end), duration, type, timing, cancellationToken);
        }

        public static UniTask RotateX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var euler = transform.rotation.eulerAngles;
            var wrapper = new Action<float>(value =>
            {
                euler.x = value;
                var rotation = transform.rotation;
                rotation.eulerAngles = euler;
                transform.rotation   = rotation;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask RotateY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var euler = transform.rotation.eulerAngles;
            var wrapper = new Action<float>(value =>
            {
                euler.y = value;
                var rotation = transform.rotation;
                rotation.eulerAngles = euler;
                transform.rotation   = rotation;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask RotateZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var euler = transform.rotation.eulerAngles;
            var wrapper = new Action<float>(value =>
            {
                euler.z = value;
                var rotation = transform.rotation;
                rotation.eulerAngles = euler;
                transform.rotation   = rotation;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask Rotate(this Transform transform, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.Rotate(transform.rotation, end, duration, type, timing, cancellationToken);
        }

        public static UniTask Rotate(this Transform transform, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.Rotate(transform.rotation.eulerAngles, end, duration, type, timing, cancellationToken);
        }

        public static UniTask RotateX(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateX(transform.rotation.x, end, duration, type, timing, cancellationToken);
        }

        public static UniTask RotateY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateY(transform.rotation.y, end, duration, type, timing, cancellationToken);
        }

        public static UniTask RotateZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.RotateZ(transform.rotation.z, end, duration, type, timing, cancellationToken);
        }

        #endregion

        #region LocalRotate

        public static UniTask LocalRotate(this Transform transform, Quaternion begin, Quaternion end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var diff    = end * Quaternion.Inverse(begin);
            var wrapper = new Action<float>(value => transform.localRotation = begin * Quaternion.SlerpUnclamped(Quaternion.identity, diff, value));
            return Easing.Apply(wrapper, type, duration, timing, cancellationToken);
        }

        public static UniTask LocalRotate(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotate(Quaternion.Euler(begin), Quaternion.Euler(end), duration, type, timing, cancellationToken);
        }

        public static UniTask LocalRotateX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var euler = transform.localRotation.eulerAngles;
            var wrapper = new Action<float>(value =>
            {
                euler.x = value;
                var rotation = transform.localRotation;
                rotation.eulerAngles    = euler;
                transform.localRotation = rotation;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask LocalRotateY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var euler = transform.localRotation.eulerAngles;
            var wrapper = new Action<float>(value =>
            {
                euler.y = value;
                var rotation = transform.localRotation;
                rotation.eulerAngles    = euler;
                transform.localRotation = rotation;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask LocalRotateZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var euler = transform.localRotation.eulerAngles;
            var wrapper = new Action<float>(value =>
            {
                euler.z = value;
                var rotation = transform.localRotation;
                rotation.eulerAngles    = euler;
                transform.localRotation = rotation;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
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
            return transform.LocalRotateX(transform.localRotation.x, end, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalRotateY(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateY(transform.localRotation.y, end, duration, type, timing, cancellationToken);
        }

        public static UniTask LocalRotateZ(this Transform transform, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            return transform.LocalRotateZ(transform.localRotation.z, end, duration, type, timing, cancellationToken);
        }

        #endregion

        #region Scale

        public static UniTask Scale(this Transform transform, Vector3 begin, Vector3 end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var diff    = end - begin;
            var wrapper = new Action<float>(value => transform.localScale = begin + diff * value);
            return Easing.Apply(wrapper, type, duration, timing, cancellationToken);
        }

        public static UniTask ScaleX(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var scale = transform.localScale;
            var wrapper = new Action<float>(value =>
            {
                scale.x              = value;
                transform.localScale = scale;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask ScaleY(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var scale = transform.localScale;
            var wrapper = new Action<float>(value =>
            {
                scale.y              = value;
                transform.localScale = scale;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
        }

        public static UniTask ScaleZ(this Transform transform, float begin, float end, float duration, Easing.Type type = Easing.Type.Linear, PlayerLoopTiming timing = PlayerLoopTiming.Update, CancellationToken cancellationToken = default)
        {
            var scale = transform.localScale;
            var wrapper = new Action<float>(value =>
            {
                scale.z              = value;
                transform.localScale = scale;
            });
            return Easing.Apply(wrapper, type, begin, end, duration, timing, cancellationToken);
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
    }
}