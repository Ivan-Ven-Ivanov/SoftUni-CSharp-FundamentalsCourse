namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintNumberOfVowels(input);
        }

        static void PrintNumberOfVowels(string input)
        {
            input = input.ToLower();

            char[] chars = input.ToCharArray();

            int vowelCounter = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                char symbol = chars[i];
                if (symbol == 'a' || symbol == 'e' || symbol == 'o' || symbol == 'i' || symbol == 'u')
                {
                    vowelCounter++;
                }
            }

            Console.WriteLine(vowelCounter);
        }
    }
}