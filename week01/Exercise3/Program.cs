using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        String finish = "yes";
        int count = 0;
        while (finish == "yes")
        {
            Console.WriteLine("What is your guess?");
            int response = int.Parse(Console.ReadLine());
            count++;
            if (response < number)
            {
                Console.WriteLine("Higher");
            }
            else if (response > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                number = randomGenerator.Next(1, 100);
                Console.WriteLine($"You guessed it in {count} times!");
                Console.WriteLine("Do you whant to play again?");
                finish = Console.ReadLine();
                count = 0;
            }
        }
    }
}