namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

            foreach (char character in input)
            {
                if (character == ' ')
                {
                    continue;
                }

                if (!charOccurrences.ContainsKey(character))
                {
                    charOccurrences.Add(character, 0);
                }

                charOccurrences[character]++;
            }

            foreach (KeyValuePair<char, int> pair in charOccurrences)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}