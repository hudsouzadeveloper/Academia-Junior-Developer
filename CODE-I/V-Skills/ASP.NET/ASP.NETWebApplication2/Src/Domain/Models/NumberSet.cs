namespace ASP.NETWebApplication2.Src.Domain.Models
{
    public class NumberSet
    {
        /// <summary>
        /// Properties
        /// </summary>
        public double A { get; }
        public double B { get; }
        public double C { get; }
        public double D { get; }

        /// <summary>
        /// Constructor()
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public NumberSet(double a, double b, double c, double d)
        {
            A = a; B = b; C = c; D = d;
        }

        /// <summary>
        /// Method()
        /// </summary>
        /// <returns></returns>
        public List<(string label, double value)> ToList()
        {
            return new()
            {
                ("a", A), ("b", B), ("c", C), ("d", D)
            };
        }
    }
}
