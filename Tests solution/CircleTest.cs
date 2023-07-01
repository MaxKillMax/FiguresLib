using Figures.Circles;

namespace FiguresTests;

public class CircleTest
{
    [Test]
    public void Area_WithRadius2_Return4MultipliedOnPI()
    {
        // Arrange
        float radius = 2;
        float result = 4 * MathF.PI;

        // Act
        float area = Circle.Area(radius);

        // Assert
        Assert.That(area, Is.EqualTo(result));
    }
}
