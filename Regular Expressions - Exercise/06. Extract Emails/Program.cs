using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<!\.|-|_)\b([A-Za-z0-9]+(?:[\.\-_][A-Za-z0-9]+)?)@[A-Za-z]+(?:-[A-Za-z]+)*(?:\.[A-Za-z]+(?:\-[A-Za-z])?)+\b";

            foreach (Match email in Regex.Matches(text, pattern))
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}