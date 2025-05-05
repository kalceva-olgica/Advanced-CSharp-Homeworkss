namespace task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Manager("Ariana", 1800);
            Employee programmer = new Programmer("Eminem", 160, 25);

            manager.DisplayInfo();
            programmer.DisplayInfo();
        }
    }
}
