using System;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // JDCI-1.2 = Operations practice "The application receives two number,
            //                                 calculates the multiplication
            //                                 and return the word “Bizz”
            //                                 when even and “Buzz” when odd;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The application receives two number, calculates the multiplication and return the word “Bizz”\n when even and “Buzz” when odd;\n");
            Console.ResetColor();

            Random random = new Random();

            int num1 = random.Next(1, 100);
            int num2 = random.Next(1, 100);

            int result = num1 * num2;

            Console.WriteLine($"The result is: {result}");

            if (result % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Bizz!");
                Console.ResetColor();
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Buzz!");
                Console.ResetColor();
            }

            Console.Write("The numbers received: ");

            for (int i = 0; i <= 2; i++)
            {
                if (i == 0)

                    Console.WriteLine($"1st number: {num1}");
                else

                    Console.WriteLine($"2nd number: {num2}");
            }
            Console.WriteLine($"Multiplication of {num1} x {num2} = {result}");

            Console.ReadKey();
        }
    }
}