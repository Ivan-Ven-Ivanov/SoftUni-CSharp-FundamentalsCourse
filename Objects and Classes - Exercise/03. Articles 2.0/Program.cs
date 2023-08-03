namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < commandCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ");
                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }


            Console.WriteLine(string.Join("\n", articles));
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}