namespace task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new CircleShape(6);
            Shape triangle = new TriangleShape(3, 4, 5);

            Console.WriteLine("Circle:");
            Console.WriteLine("Area: " + circle.CalculateArea());
            Console.WriteLine("Perimeter: " + circle.CalculatePerimeter());

            Console.WriteLine();

            Console.WriteLine("Triangle:");
            Console.WriteLine("Area: " + triangle.CalculateArea());
            Console.WriteLine("Perimeter: " + triangle.CalculatePerimeter());
        }
    }
}
