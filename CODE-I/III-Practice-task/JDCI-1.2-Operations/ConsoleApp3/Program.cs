using System;
using System.Reflection;

namespace ConsoleApp3;

public class Program
{
    static void Main(string[] args)
    {
        // JDCI-1.2 = Operations Practice "The application receives four number
        //                                 then calculates which is the lowest
        //                                 after being divided by the remaining.
        //                                 The result must be returned;

        Console.WriteLine("Enter 1st number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 3rd number: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 4th number: ");
        double d = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0 || d == 0)
            throw new ArgumentException("Division by zero is not allowed.");

        double[] numbers = { a, b, c, d };
        string[] labels = { "a", "b", "c", "d" };

        double minTotal = double.MaxValue;
        string winner = "";

        for (int i = 0; i < numbers.Length; i++) // - line
        {
            double total = 0;

            Console.WriteLine($"\n{labels[i]} ({numbers[i]}) divided by:");

            for (int j = 0; j < numbers.Length; j++) // | column
            {
                if (i != j && numbers[j] != 0)
                {
                    double result = numbers[i] / numbers[j];
                    Console.WriteLine($" {numbers[i]} / {numbers[j]} = {result:F2}");
                    total += result;
                }
            }

            Console.WriteLine($"  Total of {labels[i]}: {total:F2}");

            if (total < minTotal)
            {
                minTotal = total;
                winner = labels[i];
            }
        }

        Console.WriteLine($"\n✔ Lowest result: {winner} with total = {minTotal:F2}");

        Console.ReadKey();
    }
}