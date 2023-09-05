using ShapeAreaCalculator.Interfaces;

namespace ShapeAreaCalculator.Shapes
{
    public class Triangle : IShape, ITriangle
    {
        public double Area => GetArea();
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public bool IsRight { get; }
        public Triangle(double a, double b, double c)
        {
            var condition = Condition(a, b, c);
            if (!condition)
                throw new ArgumentException("Incorrect input.");

            A = a;
            B = b;
            C = c;

            IsRight = IsRightChecker(A, B, C);
        }

        private bool Condition(double a, double b, double c)
        {
            return a > 0 
                   && b > 0 
                   && c > 0 
                   && a + b > c 
                   && a + c > b 
                   && b + c > a;
        }

        private bool IsRightChecker(double a, double b, double c)
        {
            var aSquare = Math.Pow(a, 2);
            var bSquare = Math.Pow(b, 2);
            var cSquare = Math.Pow(c, 2);
            return (aSquare + bSquare).Equals(cSquare)
                   || (aSquare + cSquare).Equals(bSquare)
                   || (bSquare + cSquare).Equals(aSquare);
        }

        private double GetArea()
        {
            var semiPerimeter = (A + B + C) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }
    }
}
