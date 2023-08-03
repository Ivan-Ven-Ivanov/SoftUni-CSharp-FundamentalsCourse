namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNumber = numbers[i];
                if (counts.ContainsKey(currentNumber))
                {
                    counts[currentNumber]++;
                }
                else
                {
                    counts[currentNumber] = 1;
                }

            }

            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}