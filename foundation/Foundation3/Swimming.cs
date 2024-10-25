using System;

public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, int minutes, int numberOfLaps) : base(date, minutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_minutes / 60.0);
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
}