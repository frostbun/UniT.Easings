#nullable enable
namespace UniT.Easings
{
    using UnityEngine;

    public static partial class Easing
    {
        public delegate float Function(float x);

        public static readonly Function Linear = x => x;

        #region Since

        public static readonly Function InSince = x => 1 - Mathf.Cos(x * PI / 2);

        public static readonly Function OutSince = x => Mathf.Sin(x * PI / 2);

        public static readonly Function InOutSince = x => (1 - Mathf.Cos(x * PI)) / 2;

        #endregion

        #region Quad

        public static readonly Function InQuad = x => Mathf.Pow(x, 2);

        public static readonly Function OutQuad = x => 1 - Mathf.Pow(1 - x, 2);

        public static readonly Function InOutQuad = x => x switch
        {
            < .5f => Mathf.Pow(2 * x, 2) / 2,
            _     => 1 - Mathf.Pow(2 - 2 * x, 2) / 2,
        };

        #endregion

        #region Cubic

        public static readonly Function InCubic = x => Mathf.Pow(x, 3);

        public static readonly Function OutCubic = x => 1 - Mathf.Pow(1 - x, 3);

        public static readonly Function InOutCubic = x => x switch
        {
            < .5f => Mathf.Pow(2 * x, 3) / 2,
            _     => 1 - Mathf.Pow(2 - 2 * x, 3) / 2,
        };

        #endregion

        #region Quart

        public static readonly Function InQuart = x => Mathf.Pow(x, 4);

        public static readonly Function OutQuart = x => 1 - Mathf.Pow(1 - x, 4);

        public static readonly Function InOutQuart = x => x switch
        {
            < .5f => Mathf.Pow(2 * x, 4) / 2,
            _     => 1 - Mathf.Pow(2 - 2 * x, 4) / 2,
        };

        #endregion

        #region Quint

        public static readonly Function InQuint = x => Mathf.Pow(x, 5);

        public static readonly Function OutQuint = x => 1 - Mathf.Pow(1 - x, 5);

        public static readonly Function InOutQuint = x => x switch
        {
            < .5f => Mathf.Pow(2 * x, 5) / 2,
            _     => 1 - Mathf.Pow(2 - 2 * x, 5) / 2,
        };

        #endregion

        #region Expo

        public static readonly Function InExpo = x => x is 0 ? 0 : Mathf.Pow(2, 10 * x - 10);

        public static readonly Function OutExpo = x => x is 1 ? 1 : 1 - Mathf.Pow(2, -10 * x);

        public static readonly Function InOutExpo = x => x switch
        {
            0 or 1 => x,
            < .5f  => Mathf.Pow(2, 20 * x - 10) / 2,
            _      => (2 - Mathf.Pow(2, -20 * x + 10)) / 2,
        };

        #endregion

        #region Circ

        public static readonly Function InCirc = x => 1 - Mathf.Sqrt(1 - Mathf.Pow(x, 2));

        public static readonly Function OutCirc = x => Mathf.Sqrt(1 - Mathf.Pow(x - 1, 2));

        public static readonly Function InOutCirc = x => x switch
        {
            < .5f => (1 - Mathf.Sqrt(1 - Mathf.Pow(2 * x, 2))) / 2,
            _     => (Mathf.Sqrt(1 - Mathf.Pow(-2 * x + 2, 2)) + 1) / 2,
        };

        #endregion

        #region Back

        public static readonly Function InBack = x => Mathf.Pow(x, 2) * (C3 * x - C1);

        public static readonly Function OutBack = x => 1 + Mathf.Pow(x - 1, 2) * (C3 * (x - 1) + C1);

        public static readonly Function InOutBack = x => x switch
        {
            < .5f => Mathf.Pow(2 * x, 2) * ((C2 + 1) * 2 * x - C2) / 2,
            _     => (Mathf.Pow(2 * x - 2, 2) * ((C2 + 1) * (x * 2 - 2) + C2) + 2) / 2,
        };

        #endregion

        #region Elastic

        public static readonly Function InElastic = x => x is 0 or 1 ? x : -Mathf.Pow(2, 10 * x - 10) * Mathf.Sin((x * 10 - 10.75f) * C4);

        public static readonly Function OutElastic = x => x is 0 or 1 ? x : Mathf.Pow(2, -10 * x) * Mathf.Sin((x * 10 - 0.75f) * C4) + 1;

        public static readonly Function InOutElastic = x => x switch
        {
            0 or 1 => x,
            < .5f  => -(Mathf.Pow(2, 20 * x - 10) * Mathf.Sin((20 * x - 11.125f) * C5)) / 2,
            _      => Mathf.Pow(2, -20 * x + 10) * Mathf.Sin((20 * x - 11.125f) * C5) / 2 + 1,
        };

        #endregion

        #region Bounce

        public static readonly Function InBounce = x => 1 - OutBounce!(1 - x);

        public static readonly Function OutBounce = x => x switch
        {
            < 1 / D1    => N1 * x * x,
            < 2 / D1    => N1 * (x -= 1.5f / D1) * x + .75f,
            < 2.5f / D1 => N1 * (x -= 2.25f / D1) * x + .9375f,
            _           => N1 * (x -= 2.625f / D1) * x + .984375f,
        };

        public static readonly Function InOutBounce = x => x switch
        {
            < .5f => (1 - OutBounce(1 - 2 * x)) / 2,
            _     => (1 + OutBounce(2 * x - 1)) / 2,
        };

        #endregion

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

        public static Function Default = OutQuad;
    }
}