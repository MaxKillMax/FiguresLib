using Figures.Triangles;

namespace FiguresTests;

public class TriangleTest
{
    [Test]
    public void IsRectangular_WithSides3And4And5_ReturnTrue()
    {
        // Arrange
        Triangle triangle = new(3, 4, 5);
        bool result = true;

        // Act
        bool isRectangular = triangle.IsRectangular();

        // Assert
        Assert.That(isRectangular, Is.EqualTo(result));
    }

    [Test]
    public void Area_WithSides3And4And5_Return6()
    {
        // Arrange
        float side1 = 3;
        float side2 = 4;
        float side3 = 5;
        float result = 6;

        // Act
        float area = Triangle.Area(side1, side2, side3);

        // Assert
        Assert.That(area, Is.EqualTo(result));
    }
}