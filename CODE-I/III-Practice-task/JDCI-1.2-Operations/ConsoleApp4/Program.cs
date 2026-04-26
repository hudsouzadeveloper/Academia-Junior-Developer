using System;

namespace ConsoleApp4;

public class Program
{
    static void Main(string[] args)
    {
        // JDCI-1.2 = Operations Practice "The application receives two number 
        //                                 and divides them.
        //                                 The result must be returned,
        //                                 decimal places;

        Random random = new Random();

        decimal a = random.Next(1, 100);
        decimal b = random.Next(1, 100);

        decimal result1 = a / b;
        decimal result2 = b / a;


        Console.WriteLine(result1.ToString("F4"));
        Console.WriteLine(result2.ToString("F4"));
    }
}