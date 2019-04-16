using System;

namespace AreaCalculator
{
    public class TriangleAreaCalculator : IAreaCalculator
    {
        #region public properties
        public double A { get; }
        public double B { get; }
        public double C { get; }
        #endregion public properties

        #region public ctor
        public TriangleAreaCalculator(double a, double b, double c)
        {
            Regularize(ref a, ref b, ref c);

            if (a <= 0)
                throw new ArgumentException(
                    "The sides of the triangle must be positive!");

            if (a + b <= c)
                throw new ArgumentException(
                    "A triangle with specified sides does not exist!");

            (A, B, C) = (a, b, c);
        }
        #endregion public ctor

        #region public methods
        public double CalcArea() => HeronsFormulaImpl();
        #endregion public methods

        #region private methods
        private void Regularize(ref double a, ref double b, ref double c)
        {
            Regularize(ref a, ref b);
            Regularize(ref b, ref c);
            Regularize(ref a, ref b);
        }

        private void Regularize(ref double a, ref double b)
        {
            if (a > b) (a, b) = (b, a);
        }

        private double HeronsFormulaImpl()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        #endregion private methods
    }
}
