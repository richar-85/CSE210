using System;
public class Square : Shapes
{
    // Private member variable for the side
    private double _side;
    
    // Constructor that accepts color and side
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override the GetArea() method
    public override double GetArea()
    {
        return _side * _side;
    }
}