namespace UniT.Easings
{
    using System;
    using UnityEngine;

    public static partial class Easing
    {
        public enum Type
        {
            Linear,
            InSince,
            OutSince,
            InOutSince,
            InQuad,
            OutQuad,
            InOutQuad,
            InCubic,
            OutCubic,
            InOutCubic,
            InQuart,
            OutQuart,
            InOutQuart,
            InQuint,
            OutQuint,
            InOutQuint,
            InExpo,
            OutExpo,
            InOutExpo,
            InCirc,
            OutCirc,
            InOutCirc,
            InBack,
            OutBack,
            InOutBack,
            InElastic,
            OutElastic,
            InOutElastic,
            InBounce,
            OutBounce,
            InOutBounce,
        }

        public static class Function
        {
            #region Constants

            private const float PI = Mathf.PI;
            private const float C1 = 1.70158f;
            private const float C2 = C1 * 1.525f;
            private const float C3 = C1 + 1;
            private const float C4 = 2 * PI / 3;
            private const float C5 = 2 * PI / 4.5f;
            private const float N1 = 7.5625f;
            private const float D1 = 2.75f;

            #endregion

            public delegate float Delegate(float x);

            public static float Linear(float x) => x;

            #region Since

            public static float InSince(float x) => 1 - Mathf.Cos(x * PI / 2);

            public static float OutSince(float x) => Mathf.Sin(x * PI / 2);

            public static float InOutSince(float x) => (1 - Mathf.Cos(x * PI)) / 2;

            #endregion

            #region Quad

            public static float InQuad(float x) => Mathf.Pow(x, 2);

            public static float OutQuad(float x) => 1 - Mathf.Pow(1 - x, 2);

            public static float InOutQuad(float x) => x < .5f
                ? Mathf.Pow(2 * x, 2) / 2
                : 1 - Mathf.Pow(2 - 2 * x, 2) / 2;

            #endregion

            #region Cubic

            public static float InCubic(float x) => Mathf.Pow(x, 3);

            public static float OutCubic(float x) => 1 - Mathf.Pow(1 - x, 3);

            public static float InOutCubic(float x) => x < .5f
                ? Mathf.Pow(2 * x, 3) / 2
                : 1 - Mathf.Pow(2 - 2 * x, 3) / 2;

            #endregion

            #region Quart

            public static float InQuart(float x) => Mathf.Pow(x, 4);

            public static float OutQuart(float x) => 1 - Mathf.Pow(1 - x, 4);

            public static float InOutQuart(float x) => x < .5f
                ? Mathf.Pow(2 * x, 4) / 2
                : 1 - Mathf.Pow(2 - 2 * x, 4) / 2;

            #endregion

            #region Quint

            public static float InQuint(float x) => Mathf.Pow(x, 5);

            public static float OutQuint(float x) => 1 - Mathf.Pow(1 - x, 5);

            public static float InOutQuint(float x) => x < .5f
                ? Mathf.Pow(2 * x, 5) / 2
                : 1 - Mathf.Pow(2 - 2 * x, 5) / 2;

            #endregion

            #region Expo

            public static float InExpo(float x) => x is 0 ? 0 : Mathf.Pow(2, 10 * x - 10);

            public static float OutExpo(float x) => x is 1 ? 1 : 1 - Mathf.Pow(2, -10 * x);

            public static float InOutExpo(float x) => x switch
            {
                0 or 1 => x,
                < .5f  => Mathf.Pow(2, 20 * x - 10) / 2,
                _      => (2 - Mathf.Pow(2, -20 * x + 10)) / 2,
            };

            #endregion

            #region Circ

            public static float InCirc(float x) => 1 - Mathf.Sqrt(1 - Mathf.Pow(x, 2));

            public static float OutCirc(float x) => Mathf.Sqrt(1 - Mathf.Pow(x - 1, 2));

            public static float InOutCirc(float x) => x < .5f
                ? (1 - Mathf.Sqrt(1 - Mathf.Pow(2 * x, 2))) / 2
                : (Mathf.Sqrt(1 - Mathf.Pow(-2 * x + 2, 2)) + 1) / 2;

            #endregion

            #region Back

            public static float InBack(float x) => Mathf.Pow(x, 2) * (C3 * x - C1);

            public static float OutBack(float x) => 1 + Mathf.Pow(x - 1, 2) * (C3 * (x - 1) + C1);

            public static float InOutBack(float x) => x < .5f
                ? Mathf.Pow(2 * x, 2) * ((C2 + 1) * 2 * x - C2) / 2
                : (Mathf.Pow(2 * x - 2, 2) * ((C2 + 1) * (x * 2 - 2) + C2) + 2) / 2;

            #endregion

            #region Elastic

            public static float InElastic(float x) => x is 0 or 1 ? x : -Mathf.Pow(2, 10 * x - 10) * Mathf.Sin((x * 10 - 10.75f) * C4);

            public static float OutElastic(float x) => x is 0 or 1 ? x : Mathf.Pow(2, -10 * x) * Mathf.Sin((x * 10 - 0.75f) * C4) + 1;

            public static float InOutElastic(float x) => x switch
            {
                0 or 1 => x,
                < .5f  => -(Mathf.Pow(2, 20 * x - 10) * Mathf.Sin((20 * x - 11.125f) * C5)) / 2,
                _      => Mathf.Pow(2, -20 * x + 10) * Mathf.Sin((20 * x - 11.125f) * C5) / 2 + 1,
            };

            #endregion

            #region Bounce

            public static float InBounce(float x) => 1 - OutBounce(1 - x);

            public static float OutBounce(float x) => x switch
            {
                < 1 / D1    => N1 * x * x,
                < 2 / D1    => N1 * (x -= 1.5f / D1) * x + .75f,
                < 2.5f / D1 => N1 * (x -= 2.25f / D1) * x + .9375f,
                _           => N1 * (x -= 2.625f / D1) * x + .984375f,
            };

            public static float InOutBounce(float x) => x < .5f
                ? (1 - OutBounce(1 - 2 * x)) / 2
                : (1 + OutBounce(2 * x - 1)) / 2;

            #endregion

            public static Delegate FromType(Type type) => type switch
            {
                Type.Linear       => Linear,
                Type.InSince      => InSince,
                Type.OutSince     => OutSince,
                Type.InOutSince   => InOutSince,
                Type.InQuad       => InQuad,
                Type.OutQuad      => OutQuad,
                Type.InOutQuad    => InOutQuad,
                Type.InCubic      => InCubic,
                Type.OutCubic     => OutCubic,
                Type.InOutCubic   => InOutCubic,
                Type.InQuart      => InQuart,
                Type.OutQuart     => OutQuart,
                Type.InOutQuart   => InOutQuart,
                Type.InQuint      => InQuint,
                Type.OutQuint     => OutQuint,
                Type.InOutQuint   => InOutQuint,
                Type.InExpo       => InExpo,
                Type.OutExpo      => OutExpo,
                Type.InOutExpo    => InOutExpo,
                Type.InCirc       => InCirc,
                Type.OutCirc      => OutCirc,
                Type.InOutCirc    => InOutCirc,
                Type.InBack       => InBack,
                Type.OutBack      => OutBack,
                Type.InOutBack    => InOutBack,
                Type.InElastic    => InElastic,
                Type.OutElastic   => OutElastic,
                Type.InOutElastic => InOutElastic,
                Type.InBounce     => InBounce,
                Type.OutBounce    => OutBounce,
                Type.InOutBounce  => InOutBounce,
                _                 => throw new ArgumentOutOfRangeException(nameof(type), type, null),
            };
        }
    }
}