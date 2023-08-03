namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> mergedList = new List<int>();



            for (int i = 0; i < Math.Min(firstNumbers.Count, secondNumbers.Count); i++)
            {
                mergedList.Add(firstNumbers[i]);
                mergedList.Add(secondNumbers[i]);
            }

            for (int i = Math.Min(firstNumbers.Count, secondNumbers.Count); i < Math.Max(firstNumbers.Count, secondNumbers.Count); i++)
            {
                if (firstNumbers.Count > secondNumbers.Count)
                {
                    mergedList.Add(firstNumbers[i]);
                }
                else
                {
                    mergedList.Add(secondNumbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}