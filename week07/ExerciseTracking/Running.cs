using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double runDistance)
        : base(date, minutes)
    {
        _distance = runDistance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / _distance;
    }
}