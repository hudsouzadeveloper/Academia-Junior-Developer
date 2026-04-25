using ASP.NETWebApplication1.Domain.Models;

namespace ASP.NETWebApplication1.Domain.Interfaces
{
    public interface IDivisionService
    {
        DivisionResult GetHighest(double a, double b);
    }
}
