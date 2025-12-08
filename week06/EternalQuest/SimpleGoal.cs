// SimpleGoal.cs
using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("This goal has already been completed. No points awarded.");
            return 0;
        }

        _isComplete = true;
        Console.WriteLine($"You completed '{_name}' and earned {_points} points!");
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        // SimpleGoal:name|description|points|isComplete
        return $"SimpleGoal:{_name}|{_description}|{_points}|{_isComplete}";
    }
}
