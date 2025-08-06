using System;
public abstract class Shapes
{
    // Private member variable with underscore
    private string _color;

    // Constructor
    public Shapes(string color)
    {
        _color = color;
    }

    // Getter for _color
    public string GetColor()
    {
        return _color;
    }

    // Setter for _color
    public void SetColor(string color)
    {
        _color = color;
    }

    // public virtual double GetArea()
    // {
    //     return 0;
    // }

    // Abstract method for Area
    public abstract double GetArea();
}
