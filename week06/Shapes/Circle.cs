using System;
public class Circle : Shapes
{
    private double _radius;

    public Circle(string color, double raduis) : base(color)
    {
        _radius = raduis;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}