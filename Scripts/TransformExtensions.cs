namespace UniT.Easings
{
    using UnityEngine;

    public static partial class TransformExtensions
    {
        private static Vector3 Wrap(Vector3 begin, Vector3 end)
        {
            begin.x = Wrap(begin.x, end.x);
            begin.y = Wrap(begin.y, end.y);
            begin.z = Wrap(begin.z, end.z);
            return begin;
        }

        private static float Wrap(float begin, float end)
        {
            return begin - 360 * Mathf.Round((begin - end) / 360);
        }
    }
}