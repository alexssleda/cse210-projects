// ChecklistGoal.cs
using System;

public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _target;
    private int _amountCompleted;

    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted = 0)
        : base(name, description, points)
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"'{_name}' is already complete. No points awarded.");
            return 0;
        }

        _amountCompleted++;

        if (_amountCompleted < _target)
        {
            Console.WriteLine($"You recorded '{_name}' ({_amountCompleted}/{_target}) and earned {_points} points.");
            return _points;
        }
        else // atingiu o target agora
        {
            int total = _points + _bonus;
            Console.WriteLine($"You completed '{_name}'! You earned {_points} points plus a bonus of {_bonus} (total {total} points)!");
            return total;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        // ChecklistGoal:name|description|points|bonus|target|amountCompleted
        return $"ChecklistGoal:{_name}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }
}
