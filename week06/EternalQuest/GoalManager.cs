// GoalManager.cs
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int Score => _score;

    // Level system (criatividade extra): a cada 1000 pontos sobe um level.
    private int GetLevelFromScore(int score)
    {
        return score / 1000;
    }

    public void AddGoal(Goal g)
    {
        _goals.Add(g);
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateNewGoalFromInput()
    {
        Console.WriteLine("Choose the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Option: ");
        string opt = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter the points for the goal (integer): ");
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Invalid points. Aborting.");
            return;
        }

        switch (opt)
        {
            case "1":
                var sg = new SimpleGoal(name, desc, points);
                AddGoal(sg);
                Console.WriteLine("Simple goal added.");
                break;
            case "2":
                var eg = new EternalGoal(name, desc, points);
                AddGoal(eg);
                Console.WriteLine("Eternal goal added.");
                break;
            case "3":
                Console.Write("Enter bonus points for completing the checklist: ");
                if (!int.TryParse(Console.ReadLine(), out int bonus))
                {
                    Console.WriteLine("Invalid bonus. Aborting.");
                    return;
                }
                Console.Write("Enter the number of times required to complete this goal (target): ");
                if (!int.TryParse(Console.ReadLine(), out int target))
                {
                    Console.WriteLine("Invalid target. Aborting.");
                    return;
                }
                var cg = new ChecklistGoal(name, desc, points, bonus, target);
                AddGoal(cg);
                Console.WriteLine("Checklist goal added.");
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record. Create some first.");
            return;
        }

        Console.WriteLine("Which goal did you accomplish? (enter the number)");
        ListGoals();
        Console.Write("Choice: ");
        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Goal g = _goals[choice - 1];

        int oldLevel = GetLevelFromScore(_score);
        int gained = g.RecordEvent();
        _score += gained;
        int newLevel = GetLevelFromScore(_score);

        Console.WriteLine($"Your total score is now {_score}.");

        if (newLevel > oldLevel)
        {
            Console.WriteLine($"Congratulations! You leveled up to level {newLevel}!");
        }
    }

    public void SaveGoals(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // First line: score
                writer.WriteLine(_score);

                // Then each goal line
                foreach (Goal g in _goals)
                {
                    writer.WriteLine(g.GetStringRepresentation());
                }
            }
            Console.WriteLine($"Goals and score saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    public void LoadGoals(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            _goals.Clear();

            string[] lines = File.ReadAllLines(filename);
            if (lines.Length == 0)
            {
                Console.WriteLine("File is empty.");
                return;
            }

            // First line is score
            if (!int.TryParse(lines[0], out _score))
            {
                Console.WriteLine("Invalid score in file; resetting to 0.");
                _score = 0;
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                if (string.IsNullOrEmpty(line)) continue;

                // Format: Type:name|desc|... (see each class)
                int colon = line.IndexOf(':');
                if (colon < 0) continue;
                string type = line.Substring(0, colon);
                string payload = line.Substring(colon + 1);
                string[] parts = payload.Split('|');

                switch (type)
                {
                    case "SimpleGoal":
                        // name|description|points|isComplete
                        if (parts.Length >= 4 &&
                            int.TryParse(parts[2], out int sp) &&
                            bool.TryParse(parts[3], out bool isComp))
                        {
                            var sg = new SimpleGoal(parts[0], parts[1], sp, isComp);
                            _goals.Add(sg);
                        }
                        break;
                    case "EternalGoal":
                        // name|description|points
                        if (parts.Length >= 3 && int.TryParse(parts[2], out int ep))
                        {
                            var eg = new EternalGoal(parts[0], parts[1], ep);
                            _goals.Add(eg);
                        }
                        break;
                    case "ChecklistGoal":
                        // name|description|points|bonus|target|amountCompleted
                        if (parts.Length >= 6 &&
                            int.TryParse(parts[2], out int cp) &&
                            int.TryParse(parts[3], out int cb) &&
                            int.TryParse(parts[4], out int ct) &&
                            int.TryParse(parts[5], out int cac))
                        {
                            var cg = new ChecklistGoal(parts[0], parts[1], cp, cb, ct, cac);
                            _goals.Add(cg);
                        }
                        break;
                    default:
                        // unknown type - ignore
                        break;
                }
            }

            Console.WriteLine($"Loaded {_goals.Count} goals. Current score: {_score}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}
