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
            var t = new CircleAreaCalculator(r);
        }
    }
}
