namespace task03
{
   public class TriangleShape : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public TriangleShape(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double CalculateArea()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public override double CalculatePerimeter()
        {
            return A + B + C;
        }
    }
}
