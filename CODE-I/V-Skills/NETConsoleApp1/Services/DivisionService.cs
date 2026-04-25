using NETConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETConsoleApp1.Services
{
    public class DivisionService : IDivisionService
    {
        public (double max, string winner) GetHighest(double a, double b)
        {
            if (a == 0 || b == 0)
                throw new ArgumentException("Cannot divide by zero");

            double result1 = a;
            double result2 = b;

            double max = Math.Max(result1, result2);

            string winner = result1 > result2
                ? "a divided by b"
                : result2 > result1 
                ? "b divided by a"
                : "tie";

            return (max, winner);
        }
    }
}
