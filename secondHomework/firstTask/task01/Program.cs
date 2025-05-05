using System.Reflection.Metadata;

namespace task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("This is a sample document.");
            WebPage page = new WebPage("<html>This is a web page</html>");

            Console.WriteLine("Does document contains 'content'? " + doc.Search("content"));
            Console.WriteLine(" Does webPage contains 'html'? " + page.Search("html"));
        }
    }
}
