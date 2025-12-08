// EternalGoal.cs
using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"You recorded '{_name}' and earned {_points} points!");
        return _points;
    }

    public override bool IsComplete()
    {
        return false; // Nunca se completa
    }

    public override string GetStringRepresentation()
    {
        // EternalGoal:name|description|points
        return $"EternalGoal:{_name}|{_description}|{_points}";
    }
}
 