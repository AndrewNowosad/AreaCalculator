using System;
using Xunit;

namespace AreaCalculator.Tests
{
    public class TriangleAreaCalculatorTests
    {
        [Theory]
        [InlineData(-1, 1, 2)]
        [InlineData(2, -1, 2)]
        [InlineData(3, 2, -1)]
        [InlineData(1, 0, 1)]
        [InlineData(3, -2, 0)]
        public void CantCreateTriangleWithNonPositiveSide(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(
                () => new TriangleAreaCalculator(a, b, c));
        }

        [Fact]
        public void CalcAreaTest()
        {

        }
    }
}
