using ASP.NETWebApplication2.Src.Domain.Models;

namespace ASP.NETWebApplication2.Src.Application.Services
{
    public interface ICalculationService
    {
        CalculationResult Calculate(NumberSet numbers);
    }
}
