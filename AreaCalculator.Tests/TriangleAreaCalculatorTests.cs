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

        [Theory]
        [InlineData(1, 2, 4)]
        [InlineData(1, 2, 3)]
        [InlineData(4, 1, 1)]
        [InlineData(2, 8, 2)]
        [InlineData(10, 10, 35)]
        public void CantCreateTriangleWithVeryLargeSide(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(
                () => new TriangleAreaCalculator(a, b, c));
        }

        [Theory]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]
        [InlineData(3, 4, 6)]
        [InlineData(7, 3, 5)]
        [InlineData(9, 15, 7)]
        public void CanCreateTriangleWithCorrectSides(double a, double b, double c)
        {
            var t = new TriangleAreaCalculator(a, b, c);
        }

        [Fact]
        public void CalcAreaTest()
        {

        }
    }
}
