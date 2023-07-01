namespace Figures.Circles;

public class Circle : Figure
{
    private float _radius;

    public Circle(float radius)
    {
        _radius = radius;
    }

    public override float GetArea() => Area(_radius);

    public static float Area(float radius) => MathF.PI * MathF.Pow(radius, 2);
}
