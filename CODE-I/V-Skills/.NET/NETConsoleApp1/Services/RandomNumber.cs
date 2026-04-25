using NETConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETConsoleApp1.Services
{
    public class RandomNumber : IRandomNumber
    {
        private readonly Random _random = new Random();

        public double Lottery(double min, double max)
        {
            return _random.NextDouble() * (max - min) + min;
        }
    }
}
