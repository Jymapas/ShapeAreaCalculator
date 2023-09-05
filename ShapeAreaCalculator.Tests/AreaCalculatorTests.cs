using ShapeAreaCalculator.Interfaces;
using ShapeAreaCalculator.Shapes;
using NUnit.Framework;

namespace ShapeAreaCalculator.Tests
{
    public class Tests
    {
        private ICalculator _areaCalculator;

        [SetUp]
        public void Setup() 
        {
            _areaCalculator = new AreaCalculator();
        }

        [Test]
        [TestCase(new double[] { 3, 4, 5 }, 6)]
        [TestCase(new double[] { 6, 8, 10 }, 24)]
        public void TriangleTest(double[] args, double area)
        {
            // Arrange & Act
            var result = _areaCalculator.Calculate(args);

            // Assert
            Assert.That(result, Is.EqualTo(area));
        }

        [Test]
        [TestCase(new double[] { 3, 4, 5 }, true)]
        [TestCase(new double[] { 5, 5, 5 }, false)]
        public void RightTriangleTest(double[] args, bool expectedIsRight)
        {
            // Arrange
            var triangle = new Triangle(args[0], args[1], args[2]);

            // Act
            var isRight = triangle.IsRight;

            // Assert
            Assert.That(isRight, Is.EqualTo(expectedIsRight));
        }

        [Test]
        [TestCase(1, Math.PI)]
        [TestCase(2, Math.PI * 4)]
        public void CircleTest(double radius, double area)
        {
            // Arrange & Act
            var result = _areaCalculator.Calculate(radius);

            // Assert
            Assert.That(result, Is.EqualTo(area));

        }

        [Test]
        [TestCase(new double[] { 1, 2, 10 })]
        [TestCase(new double[] { -3, -4, -5 })]
        [TestCase(new double[] { -2 })]
        public void IncorrectInputTest(double[] args)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(
                () => _areaCalculator.Calculate(args),
                "Incorrect input.");
        }
    }
}