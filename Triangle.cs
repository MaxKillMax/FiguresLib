namespace Figures.Triangles;

public class Triangle : Figure
{
    private readonly float[] _sides;

    public Triangle(float side1, float side2, float side3)
    {
        _sides = new float[] { side1, side2, side3 };
        _sides = _sides.OrderByDescending((i) => i).ToArray();
    }

    public bool IsRectangular() => _sides[0].Square() == _sides[1].Square() + _sides[2].Square();

    public override float GetArea() => Area(_sides[0], _sides[1], _sides[2]);

    public static float Area(float side1, float side2, float side3)
    {
        float halfPerimeter = side1 + side2 + side3;
        halfPerimeter /= 2;

        return MathF.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
    }
}
