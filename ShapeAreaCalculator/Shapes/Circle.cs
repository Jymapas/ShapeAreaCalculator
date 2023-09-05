using ShapeAreaCalculator.Interfaces;

namespace ShapeAreaCalculator.Shapes;

public class Circle : IShape
{
    public double Area => Math.PI * Math.Pow(Radius, 2);
    public double Radius { get; }
    public Circle(double radius)
    {
        if (radius <= 0) 
            throw new ArgumentException("Incorrect input.");
        Radius = radius;
    }
}