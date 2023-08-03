namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> symbols = new List<string>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                string[] range = list[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                symbols.AddRange(range);
            }

            Console.WriteLine(string.Join(" ", symbols));

        }
    }
}