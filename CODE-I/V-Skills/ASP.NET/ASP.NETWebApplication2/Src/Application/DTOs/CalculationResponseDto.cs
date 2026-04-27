namespace ASP.NETWebApplication2.Src.Application.DTOs
{
    public class CalculationResponseDto
    {
        public string Winner { get; set; }
        public double LowestTotal { get; set; }
        public List<DivisionDetailDto> Details { get; set; }
    }
}
