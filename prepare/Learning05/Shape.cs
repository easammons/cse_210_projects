using System;
public abstract class Shape
{
    private string _color;

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public Shape(string _color)
    {
        this._color = _color;
    }

    public virtual double GetArea()
    {
        return 0;
    }

}