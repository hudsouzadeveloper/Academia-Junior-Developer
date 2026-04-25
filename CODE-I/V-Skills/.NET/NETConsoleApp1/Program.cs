using NETConsoleApp1.Interfaces;
using NETConsoleApp1.Services;
using System;

namespace NETConsoleApp1;

public class Program
{
    static void Main(string[] args)
    {
        // JDCI-1.2 = Operations "The application receives two number,
        //                        then calculates which has the highest result
        //                        of the division of one from the other.

        // Manually Dependency Injection
        IRandomNumber random = new RandomNumber();
        IDivisionService division = new DivisionService();

        double a = random.Lottery(0, 100);
        double b = random.Lottery(0, 100);

        var (max, winner) = division.GetHighest(a, b);

        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");
        Console.WriteLine($"highest result: {max}");
        Console.WriteLine($"winner: {winner}");

        Console.ReadKey();
    }
}