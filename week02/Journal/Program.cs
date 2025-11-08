using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int answer = 0;
        String description = "";

        List<String> questions = new List<String>();
        questions.Add("Who was the most interesting person I interacted with today?");
        questions.Add("What was the best part of my day?");
        questions.Add("How did I see the hand of the Lord in my life today?");
        questions.Add("What was the strongest emotion I felt today?");
        questions.Add("If I had one thing I could do over today, what would it be?");
        questions.Add("What goals am I working?");
        questions.Add("Who did I help today and how?");
        questions.Add("Who did help me today and how did I show gratitude?");
        int number = 0;

        Journal newJournal = new Journal();
        while (answer != 5)
        {
            Console.WriteLine("Please select one pf the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quite");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                number = randomGenerator.Next(0, questions.Count);
                Console.WriteLine(questions[number]);

                newJournal._lines.Add($"Date: {DateTime.Today.ToShortDateString()} - Prompt: {questions[number]}");

                description = Console.ReadLine();
                newJournal._lines.Add(description);
                newJournal._lines.Add("");

            }
            else if (answer == 2)
            {
                foreach (String line in newJournal._lines)
                {
                    Console.WriteLine(line);
                }
            }
            else if (answer == 3)
            {
                newJournal.LoadFile();
            }
            else if (answer == 4)
            {
                newJournal.SaveFile();
            }
            else if (answer != 5)
            {
                Console.WriteLine("Invalid answer, please select a valid option.");
            }
        }

    }
}