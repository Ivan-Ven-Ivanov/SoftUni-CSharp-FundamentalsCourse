namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0;
            foreach (string text in input)
            {
                decimal sum = Sum(text);
                totalSum += sum;
            }

            Console.WriteLine($"{totalSum:F2}");
        }

        private static decimal Sum(string text)
        {
            char firstLetter = text[0];
            char lastLetter = text[text.Length - 1];
            decimal number = int.Parse(text.Substring(1, text.Length - 2));
            if (char.IsUpper(firstLetter))
            {
                number /= firstLetter - 64;
            }
            else
            {
                number *= firstLetter - 96;
            }

            if (char.IsUpper(lastLetter))
            {
                number -= lastLetter - 64;
            }
            else
            {
                number += lastLetter - 96;
            }

            return number;
        }
    }
}