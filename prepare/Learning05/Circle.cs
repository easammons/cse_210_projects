

public class Circle : Shape
{
    private double _radius;

    public Circle(string _color, double radius) : base(_color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}