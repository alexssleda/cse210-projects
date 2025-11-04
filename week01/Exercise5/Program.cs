using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String name = PromptUserName();
        int square = PromptUserNumber();

        DisplayResult(name, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static String PromptUserName()
    {
        Console.WriteLine("Please enter your name.");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(String name, int square)
    {
        square = SquareNumber(square);
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}