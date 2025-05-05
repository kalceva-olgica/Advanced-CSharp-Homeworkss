namespace task01
{
   public class WebPage : ISearchable
    {
        public string html;

        public WebPage(string htmlContent)
        {
            html = htmlContent;
        }

        public bool Search(string word)
        {
            return html.Contains(word);
        }
    }
}
