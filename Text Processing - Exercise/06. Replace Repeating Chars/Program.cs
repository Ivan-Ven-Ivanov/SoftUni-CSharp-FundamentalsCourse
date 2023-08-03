using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ReplaceRepeatingChars(input));
        }

        private static string ReplaceRepeatingChars(string input)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    sb.Append(input[i]);
                }
            }

            return sb.ToString();
        }
    }
}