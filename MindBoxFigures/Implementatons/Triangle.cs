using MindBoxFigures.Contracts;

namespace MindBoxFigures.Implementatons
{
    public class Triangle : ITriangle
    {
        /// <summary>
        /// First side of the triangle.
        /// </summary>
        public double FirstSide { get; init; }

        /// <summary>
        /// Second side of the triangle.
        /// </summary>
        public double SecondSide { get; init; }

        /// <summary>
        /// Third side of the triangle.
        /// </summary>
        public double ThirdSide { get; init; }

        /// <summary>
        /// Initializator for triangle.
        /// </summary>
        /// <param name="firstSide">First side.</param>
        /// <param name="secondSide">Second side.</param>
        /// <param name="thirdSide">Third side.</param>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentOutOfRangeException("One of provided side's is negative.");
            if (firstSide + secondSide <= thirdSide ||
                firstSide + thirdSide <= secondSide ||
                secondSide + thirdSide <= firstSide)
                throw new ArgumentException("This triangle canno't exist.");
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        /// <inheritdoc/>
        public double ComputeSquare()
        {
            var halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(halfPerimeter *
                (halfPerimeter - FirstSide) *
                (halfPerimeter - SecondSide) *
                (halfPerimeter - ThirdSide));
        }

        /// <inheritdoc/>
        public bool IsRectangular()
        {
            ///Check for equal sided triangle.
            if (FirstSide == SecondSide && SecondSide == ThirdSide)
            {
                return false;
            }
            ///Check if the first side bigger than other's
            if (FirstSide > SecondSide && FirstSide > ThirdSide)
            {
                return Math.Pow(FirstSide, 2) == Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2);
            }
            ///Check if the second side is bigger than the third
            if (SecondSide > ThirdSide)
            {
                return Math.Pow(SecondSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(ThirdSide, 2);
            }
            ///Including a previous checks that means third side is the biggest one.
            else
            {
                return Math.Pow(ThirdSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2);
            }
        }
    }
}
