using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class RandomNumber
    {
        /// <summary>
        /// obj
        /// </summary>
        private readonly Random rand = new Random();

        /// <summary>
        /// method()
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public double Lottery(double min, double max)
        {
            return rand.NextDouble() * (max - min) + min;
        }
    }
}
