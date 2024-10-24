using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _eventCount;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _eventCount = 0;
    }

    public int GetEventCount()
    {
        return _eventCount;
    }
    public virtual string GetDetailString()
    {
        if (!IsComplete())
        {
            return $"[ ] {_name} ({_description})";
        }
        else
        {
            return $"[X] {_name} ({_description})";
        }
    }

    public int GetPoints()
    {
        return _points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();


}