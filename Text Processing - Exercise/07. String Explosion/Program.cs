using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(ExplodeChars(input));
        }

        private static string ExplodeChars(string input)
        {
            StringBuilder sb = new StringBuilder();
            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    sb.Append(input[i]);
                    power += int.Parse(input[i + 1].ToString());
                }
                else if (power == 0)
                {                   
                    sb.Append(input[i]);
                }
                else if (power > 0)
                {
                    power--;
                }
            }

            return sb.ToString();
        }
    }
}