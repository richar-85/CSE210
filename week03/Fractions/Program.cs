using System;

class Program
{
    static void Main(string[] args)
    {
        // All Steps
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        // Step 4
        //f1.Display();
        //f2.Display();
        //f3.Display();

        // Step 5
        //Console.WriteLine($"f1: {f1.GetTop()}/{f1.GetBottom()}");
        //Console.WriteLine($"f2: {f2.GetTop()}/{f2.GetBottom()}");
        //Console.WriteLine($"f3: {f3.GetTop()}/{f3.GetBottom()}");

        // Step 6
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}