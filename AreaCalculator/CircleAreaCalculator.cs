using System;

namespace AreaCalculator
{
    public class CircleAreaCalculator : IAreaCalculator
    {
        #region public properties
        public double R { get; }
        #endregion public properties

        #region public ctor
        public CircleAreaCalculator(double r)
        {
            if (r <= 0)
                throw new ArgumentException(
                    "The radius of the circle must be positive!");

            R = r;
        }
        #endregion public ctor

        public double CalcArea()
        {
            throw new NotImplementedException();
        }
    }
}
