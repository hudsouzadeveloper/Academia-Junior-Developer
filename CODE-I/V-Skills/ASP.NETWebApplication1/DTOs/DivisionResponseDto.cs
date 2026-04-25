namespace ASP.NETWebApplication1.DTOs
{
    public class DivisionResponseDto
    {
        public double A { get; set; }
        public double B { get; set; }

        public double ResultAOverB { get; set; }
        public double ResultBOverA { get; set; }

        public double Max { get; set; }
        public string Winner { get; set; }
    }
}
