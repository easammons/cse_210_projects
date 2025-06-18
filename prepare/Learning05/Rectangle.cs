
public class Rectangle : Shape
{
    private double _side;
    private double _length;

    public Rectangle(string _color, double side, double length) : base(_color)
    {
        _side = side;
        _length = length;
    }

    public override double GetArea()
    {
        return _side * _length;
    }
}