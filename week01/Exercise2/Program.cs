using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?");
        int grade = int.Parse(Console.ReadLine());
        String letter = "";
        if (grade >= 90)
        {
            letter = "Your grade is A";
        }
        else if (grade >= 80)
        {
            letter = "Your grade is B";
        }
        else if (grade >= 70)
        {
            letter = "Your grade is C";
        }
        else if (grade >= 60)
        {
            letter = "Your grade is D";
        }
        else
        {
            letter = "Your grade is F";
        }
        int rest = grade % 10;
        String signal = "";

        if (grade < 60)
        {
            signal = "";
        }
        else if (rest >= 7 && grade < 90)
        {
            signal = "+";
        }
        else if (rest < 3)
        {
            signal = "-";
        }

        Console.WriteLine(letter + signal);

        if (grade > 70)
        {
            Console.WriteLine("Congratulations, you passed this course");
        }
        else
        {
            Console.WriteLine("I am sorry, but you do not have grato to complete this couse,");
            Console.WriteLine("please prepare to the final exam, you still have time");
        }
    }
}