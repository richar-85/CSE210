using System;

class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double cycleSpeed)
        : base(date, minutes)
    {
        _speed = cycleSpeed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return (_speed * LengthInMinutes) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}