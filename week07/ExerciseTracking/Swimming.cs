using System;

class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int totalLaps)
        : base(date, minutes)
    {
        _laps = totalLaps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }
}