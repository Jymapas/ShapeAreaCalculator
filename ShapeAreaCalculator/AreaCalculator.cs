using ShapeAreaCalculator.Interfaces;
using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator
{
    public class AreaCalculator : ICalculator
    {
        private IShape _shape;
        public double Calculate(params double[] args)
        {
            _shape = args.Length switch
            {
                1 => new Circle(args[0]),
                3 => new Triangle(args[0], args[1], args[2]),
                _ => _shape
            };

            return _shape.Area;
        }
    }
}