using NUnit.Framework;
using GeometryLibrary;

namespace GeometryLibrary.Tests
{
    public class FigureTests
    {
        [Test]
        public void Circle_GetArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            // Act
            double area = circle.GetArea();

            // Assert
            double expectedArea = 78.53981633974483;
            Assert.AreEqual(expectedArea, area, 0.0001);
        }

        [Test]
        public void Triangle_GetArea_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            double area = triangle.GetArea();

            // Assert
            double expectedArea = 6;
            Assert.AreEqual(expectedArea, area, 0.0001);
        }

        [Test]
        public void Triangle_IsRightTriangle_ValidSides_ReturnsTrue()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }

        [Test]
        public void Triangle_GetArea_InvalidSides_ThrowsArgumentException()
        {
            // Arrange
            double side1 = 1;
            double side2 = 2;
            double side3 = 4;

            // Act & Assert
            Assert.Throws<System.ArgumentException>(() => new Triangle(side1, side2, side3));
        }
    }
}
