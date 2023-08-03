namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomNumber = random.Next(0, input.Length);
                string word = input[randomNumber];
                input[randomNumber] = input[i];
                input[i] = word;
            }

            foreach (string word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}