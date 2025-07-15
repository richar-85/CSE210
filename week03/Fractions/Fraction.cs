// All Steps
public class Fraction
{
    // All Steps
    private int _top;
    private int _bottom;

    // All Steps
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Step 4
    //public void Display()
    //{
    //Console.WriteLine($"{_top}/{_bottom}");
    //}

    // Step 5 - 6 Getters & Setters for top and bottom
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Step 6 Returns fraction as string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}
