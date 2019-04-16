using System;
using Xunit;

namespace AreaCalculator.Tests
{
    public class CircleAreaCalculatorTests
    {
        [Theory]
        [InlineData(-2)]
        [InlineData(-0.002)]
        [InlineData(0)]
        public void CantCreateCircleWithNonPositiveRadius(double r)
        {
            Assert.Throws<ArgumentException>(
                () => new CircleAreaCalculator(r));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5.3)]
        [InlineData(17.001)]
        public void CanCreateCircleWithCorrectRadius(double r)
        {
            var c = new CircleAreaCalculator(r);
        }

        [Theory]
        [InlineData(1, 3.142)]
        [InlineData(2, 12.566)]
        [InlineData(1.234, 4.784)]
        [InlineData(13, 530.929)]
        public void CalcAreaTest(double r, double s)
        {
            var c = new CircleAreaCalculator(r);

            Assert.Equal(
                expected: s,
                actual: c.CalcArea(),
                precision: 3);
        }
    }
}
