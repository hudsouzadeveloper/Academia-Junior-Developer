using ASP.NETWebApplication2.Src.Domain.Models;
using ASP.NETWebApplication2.Src.Domain.ValueObjects;

namespace ASP.NETWebApplication2.Src.Application.Services
{
    public class CalculationService : ICalculationService
    {
        public CalculationResult Calculate(NumberSet numbers)
        {
            var list = numbers.ToList();

            if (list.Any(x => x.value == 0))
                throw new ArgumentException("Division by zero is not allowed.");

            var outcomes = new List<DivisionOutcome>();

            foreach (var i in list)
            {
                var outcome = new DivisionOutcome
                {
                    SourceLabel = i.label,
                    SourceValue = i.value
                };

                foreach (var j in list)
                {
                    if (i.label == j.label) continue;

                    var result = i.value / j.value;
                    outcome.Results.Add(result);
                    outcome.Total += result;
                }

                outcomes.Add(outcome);
            }

            var winner = outcomes.OrderBy(o => o.Total).First();

            return new CalculationResult
            {
                WinnerLabel = winner.SourceLabel,
                LowestTotal = winner.Total,
                Details = outcomes
            };
        }
    }
}
