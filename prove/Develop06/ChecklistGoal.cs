using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted, bool isComplete) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _points += _bonus;
            Console.WriteLine();
            Console.WriteLine("Target achieved! Bonus points added!");
        }

        _eventCount++;
        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target || _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {_name}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}|{_isComplete}";
    }

    public override string GetDetailString()
    {
        if (!IsComplete())
        {
            return $"[ ] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[X] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

}