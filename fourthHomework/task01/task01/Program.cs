namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInConsole printInConsole = new PrintInConsole();
            printInConsole.Print(123);
            printInConsole.Print("This homework is confusing :)");
            printInConsole.Print(123.44);

            printInConsole.PrintCollection(new List<int> { 1, 2, 3 });
            printInConsole.PrintCollection(new List<string>{"cat","parrot","bear"});

        }
    }
}
