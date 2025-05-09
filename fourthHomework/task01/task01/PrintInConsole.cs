namespace task01
{
   public class PrintInConsole
    {
        public void Print<T>(T something)
        {
            Console.WriteLine(something);
        }

        public void PrintCollection<T>(List<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
