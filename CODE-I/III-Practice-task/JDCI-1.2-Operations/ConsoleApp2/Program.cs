using System;
using ConsoleApp2.Services;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            RandomNumber randomNumber = new RandomNumber();

            double a = randomNumber.Lottery(0, 100);
            double b = randomNumber.Lottery(0, 100);

            if (a == 0 || b == 0)
                throw new ArgumentException("Division by zero is not allowed.");

            double result1 = a / b;
            double result2 = b / a;

            double max = Math.Max(result1, result2);

            string highestResult;

            if (result1 > result2)
                highestResult = "A divided by B";
            else if (result2 > result1)
                highestResult = "B divided by A";
            else 
                highestResult = "tie";

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");

            Console.WriteLine($"highest reult: {max}");
            Console.WriteLine($"Winner: {highestResult}");

            Console.ReadKey();
        }
    }
}