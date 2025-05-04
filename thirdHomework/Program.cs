namespace thirdHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var results = UserDatabase.Search(name: "Sofia");

            foreach (var user in results)
            {
                Console.WriteLine($"Your Id: {user.Id}, your name: {user.Name}, and your age: {user.Age}");
            }
        }
    }
}
