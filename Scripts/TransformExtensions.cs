#nullable enable
namespace UniT.Easings
{
    using UnityEngine;

    public static partial class TransformExtensions
    {
        private static void SetScale(this Transform transform, Vector3 scale)
        {
            var lossyScale = transform.lossyScale;
            transform.localScale = new Vector3(scale.x / lossyScale.x, scale.y / lossyScale.y, scale.z / lossyScale.z);
        }

        private static Vector3 Normalize(Vector3 begin, Vector3 end)
        {
            begin.x = Normalize(begin.x, end.x);
            begin.y = Normalize(begin.y, end.y);
            begin.z = Normalize(begin.z, end.z);
            return begin;
        }

        private static float Normalize(float begin, float end)
        {
            return begin - 360 * Mathf.Round((begin - end) / 360);
        }
    }
}