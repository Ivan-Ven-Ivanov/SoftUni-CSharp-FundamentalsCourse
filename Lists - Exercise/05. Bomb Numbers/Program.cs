namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] special = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int specialNumber = special[0];
            int power = special[1];

            while (numbers.Contains(specialNumber))
            {
                int index = numbers.IndexOf(specialNumber);
                int leftIndex = Math.Max(0, index - power);
                int rightIndex = Math.Min(numbers.Count - 1, index + power);

                int range = rightIndex - leftIndex + 1;
                numbers.RemoveRange(leftIndex, range);               
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}