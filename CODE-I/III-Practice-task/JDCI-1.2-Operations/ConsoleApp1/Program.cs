using System;

namespace ConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        // JDCI-1.2 = Operations Practice "The application receives four numbers
        //                                 and see which one is the highest.
        //                                 The result must be returned;"
        //

        /// Primitive

        Console.WriteLine("Write ist number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Write 2nd number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Write 3rd number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Write 4th number: ");
        int d = Convert.ToInt32(Console.ReadLine());

        int highestNumber = 10;

        if (a > highestNumber)
        {
            highestNumber = a;
        }

        if (b > highestNumber)
        {
            highestNumber = b;
        }

        if (c > highestNumber)
        {
            highestNumber = c;
        }

        if (d > highestNumber)
        {
            highestNumber = d;
        } else
        {
            Console.WriteLine("The highest number is 10!");
        }

        Console.WriteLine($"The highest number is {highestNumber}");

        Console.ReadKey();

    }
}