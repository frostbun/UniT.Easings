#nullable enable
namespace UniT.Easings
{
    using System.Diagnostics.Contracts;
    using System.Runtime.CompilerServices;
    using UnityEngine;

    public static partial class TransformExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Vector3 Normalize(Vector3 begin, Vector3 end)
        {
            begin.x = Normalize(begin.x, end.x);
            begin.y = Normalize(begin.y, end.y);
            begin.z = Normalize(begin.z, end.z);
            return begin;
        }

        [Pure]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static float Normalize(float begin, float end)
        {
            return begin - 360 * Mathf.Round((begin - end) / 360);
        }
    }
}