using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        // I added a simple "level up" system that notifies the user whenever their score surpasses each multiple of 1000.
        // I also kept the save/load system in plain text to make it easier to read/edit
        // and to remain compatible with the assignment specifications.
        //

        bool running = true;
        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Eternal Quest - Main Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record an Event (complete a goal)");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    manager.CreateNewGoalFromInput();
                    break;
                case "2":
                    manager.ListGoals();
                    break;
                case "3":
                    Console.Write("Enter filename to save to (e.g. save.txt): ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load from (e.g. save.txt): ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;
                case "5":
                    manager.RecordEvent();
                    break;
                case "6":
                    Console.WriteLine($"Current score: {manager.Score}");
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
