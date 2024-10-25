using System;

public abstract class Activity
{
    protected DateTime _date;
    protected int _minutes;
    // protected double _distance;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
        // _distance = distance;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }
    
    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date: dd MMM yyyy} {GetType().Name} ({_minutes} min) - Distance:{GetDistance():F1} miles, Speed:{GetSpeed():F1} mph, Pace:{GetPace():F1} min per mile";
    }

}