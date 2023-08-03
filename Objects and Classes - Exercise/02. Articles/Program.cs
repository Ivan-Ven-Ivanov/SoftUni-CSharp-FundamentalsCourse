/*
Fight club, love story, Martin Scorsese
2
Edit: underground fight club that evolves into much more
ChangeAuthor: Chuck Palahniuk
*/
namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ");
            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article(title, content, author);

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(": ");
                string newText = commands[1];

                switch (commands[0])
                {
                    case "Edit":
                        article.EditContent(newText);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(newText);
                        break;
                    case "Rename":
                        article.RenameTitle(newText);
                        break;
                }
            }

            Console.WriteLine(article);
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

        public void EditContent(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void RenameTitle(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}