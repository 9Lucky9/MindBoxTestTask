using MindBoxFigures.Implementatons;

namespace MindBoxFigures.Tests.UnitTests
{
    public class CircleTests
    {
        /// <summary>
        /// Pass a valid data.
        /// Should return the right result.
        /// </summary>
        [Theory]
        [InlineData(10, 314.159)]
        [InlineData(1, 3.142)]
        [InlineData(0, 0)]
        public void ComputeSquareShouldReturnRightResult(double radius, double expectedResult)
        {
            var precision = 3;
            var circle = new Circle(radius);
            var result = circle.ComputeSquare();
            Assert.Equal(expectedResult, result, precision);
        }

        /// <summary>
        /// Pass an invalid circle.
        /// Should return ArgumentOutOfRangeException.
        /// </summary>
        [Theory]
        [InlineData(-10)]
        [InlineData(-1)]
        [InlineData(-999)]
        public void CircleInitializationShouldThrowException(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var circle = new Circle(radius);
            });
        }
    }
}
