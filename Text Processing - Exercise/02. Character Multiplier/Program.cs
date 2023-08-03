using System.Text;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            Console.WriteLine(SumOfChars(input[0], input[1]));
        }

        static int SumOfChars(string firstText, string secondText)
        {
            int result = 0;

            int biggerString = Math.Max(firstText.Length, secondText.Length);
            for (int i = 0; i < biggerString; i++)
            {
                if (i < firstText.Length && i < secondText.Length)
                {
                    result += firstText[i] * secondText[i];
                }
                else if (i < firstText.Length)
                {
                    result += firstText[i];
                }
                else if (i < secondText.Length)
                {
                    result += secondText[i];
                }
            }

            return result;
        }
    }
}