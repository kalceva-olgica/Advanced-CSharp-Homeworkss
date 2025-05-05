namespace task01
{
    public class Document : ISearchable
    {
        public string content;

        public Document(string text)
        {
            content = text;
        }

        public bool Search(string word)
        {
            return content.Contains(word);
        }
    }
}
