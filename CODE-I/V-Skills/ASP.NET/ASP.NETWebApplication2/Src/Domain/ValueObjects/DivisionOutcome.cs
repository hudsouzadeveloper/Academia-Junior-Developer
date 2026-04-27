namespace ASP.NETWebApplication2.Src.Domain.ValueObjects
{
    public class DivisionOutcome
    {
        public string SourceLabel { get; set; }
        public double SourceValue { get; set; }
        public List<double> Results { get; set; } = new();
        public double Total { get; set; }
    }
}
