using ASP.NETWebApplication2.Src.Domain.ValueObjects;

namespace ASP.NETWebApplication2.Src.Domain.Models
{
    public class CalculationResult
    {
        public string WinnerLabel { get; set; }
        public double LowestTotal { get; set; }
        public List<DivisionOutcome> Details { get; set; }
    }
}
