using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETConsoleApp1.Interfaces
{
    public interface IDivisionService
    {
        (double max, string winner) GetHighest(double a, double b);
    }
}
