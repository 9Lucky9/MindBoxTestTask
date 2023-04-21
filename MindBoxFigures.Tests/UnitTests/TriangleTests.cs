using MindBoxFigures.Implementatons;

namespace MindBoxFigures.Tests.UnitTests
{
    public class TriangleTests
    {
        /// <summary>
        /// Pass a one or more negative side's of the triangle.
        /// Should return an exception.
        /// </summary>
        [Theory]
        [InlineData(-5, 3, 4)]
        [InlineData(5, -3, 4)]
        [InlineData(5, 3, -4)]
        [InlineData(-5, -3, -4)]
        public void TriangleInitializationShouldThrowArgumentOutOfRangeException(
            int firstSide,
            int secondSide,
            int thirdSide)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var triangle = new Triangle(firstSide, secondSide, thirdSide);
            });
        }

        /// <summary>
        /// Pass a non existing triangles.
        /// Should return exception.
        /// </summary>
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(10, 2, 3)]
        [InlineData(0, 3, 4)]
        [InlineData(5, 0, 4)]
        [InlineData(5, 3, 0)]
        public void TriangleInitializationShouldThrowArgumentException(
            int firstSide,
            int secondSide,
            int thirdSide)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var triangle = new Triangle(firstSide, secondSide, thirdSide);
            });
        }

        /// <summary>
        /// Pass a valid triangle sides.
        /// Should return a right square.
        /// </summary>
        [Theory]
        [InlineData(10, 10, 10, 43.301)]
        [InlineData(5, 3, 4, 6.0)]
        [InlineData(7, 6, 5, 14.697)]
        public void ComputeSquareShouldReturnRightResult(
            int firstSide,
            int secondSide,
            int thirdSide,
            double expectedResult)
        {
            var precision = 3;
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var result = triangle.ComputeSquare();
            Assert.Equal(expectedResult, result, precision);
        }

        /// <summary>
        /// Pass an existing triangles.
        /// Should return right result.
        /// </summary>
        [Theory]
        [InlineData(10, 10, 10, false)]
        [InlineData(5, 3, 4, true)]
        public void IsRectangularShouldReturnRightResult(
            int firstSide,
            int secondSide,
            int thirdSide,
            bool expectedResult)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var result = triangle.IsRectangular();
            Assert.Equal(expectedResult, result);
        }
    }
}
