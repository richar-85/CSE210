using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // // This is use for step 3 - 5
        // // Create a Square instance
        // Square _Square = new Square("Blue", 5.0);

        // // Call GetColor() and GetArea()
        // string color = _Square.GetColor();
        // double area = _Square.GetArea();

        // // Print results
        // Console.WriteLine($"Square Color: {color}");
        // Console.WriteLine($"Square Area: {area}");

        // This is use for step 6 - 7
        // Create a list of shape
        List<Shapes> shapes = new List<Shapes>();

        // Add a Square, Rectangle, and Circle
        shapes.Add(new Square("Blue", 5.0));
        shapes.Add(new Rectangle("Red", 4.0, 6.0));
        shapes.Add(new Circle("Green", 3.0));

        // Iterate and display color and area
        foreach (Shapes shape in shapes)
        {
            // string color = shape.GetColor();
            // double area = shape.GetArea();
            // Console.WriteLine($"The {color} shape has an area of {area}.");
            Console.WriteLine($"The {shape.GetColor()} shape");
            Console.WriteLine($"Has an area of {shape.GetArea():F2}");
            Console.WriteLine();
        }
    }
}