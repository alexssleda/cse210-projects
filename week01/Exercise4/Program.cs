using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = 1;
        int sum = 0;
        int average = 0;
        int larger = 0;
        int smallPositive = 9999;
        while (number != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            number = int.Parse(Console.ReadLine());
            if (number > larger)
            {
                larger = number;
            }

            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
            }
            if (number > 0 && smallPositive > number)
            {
                smallPositive = number;
            }

        }
        Console.WriteLine($"The sum is: {sum}");

        average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {larger}");
        if (smallPositive == 9999)
        {
            Console.WriteLine("There is no small positive number");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallPositive}");
        }
    }
}