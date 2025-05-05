namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape rect = new Rectangle(5, 2);
            IShape circle = new Circle(4);
            IShape triangle = new Triangle(6, 4);

            Console.WriteLine("Rectangle Area: " + rect.GetArea());
            Console.WriteLine("Circle Area: " + circle.GetArea());
            Console.WriteLine("Triangle Area: " + triangle.GetArea());
        }
    }
}
