using MindBoxFigures.Contracts;

namespace MindBoxFigures.Implementatons
{
    public class Circle : ICircle
    {
        public double Radius { get; init; }

        /// <summary>
        /// Initialize a new instance of the Circle.
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(radius),
                    "Radius canno't be negative.");
            }
            Radius = radius;
        }

        /// <inheritdoc/>
        public double ComputeSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
