using ASP.NETWebApplication1.Domain.Interfaces;
using ASP.NETWebApplication1.Domain.Models;

namespace ASP.NETWebApplication1.Domain.Services
{
    public class DivisionService : IDivisionService
    {
        public DivisionResult GetHighest(double a, double b)
        {
            if (a == 0 || b == 0)
                throw new ArgumentException("Cannot divide by zero");

            double result1 = a / b;
            double result2 = b / a;

            return new DivisionResult
            {
                Result1 = result1,
                Result2 = result2,
                Max = Math.Max(result1, result2),
                Winner = result1 > result2 ? "a divided by b" : result2 > result1 ? "b divided by a" : "tie"
            };

        }
    }
}
