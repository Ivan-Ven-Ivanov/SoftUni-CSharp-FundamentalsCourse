namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ");

            foreach (string username in usernames)
            {
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                bool charIsValid = username.All(x => char.IsLetterOrDigit(x) || x == 45 || x == 95);

                if (charIsValid)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}