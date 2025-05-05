namespace task03
{
   public  class CircleShape : Shape
    {
        public double Radius { get; set; }

        public CircleShape(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}

