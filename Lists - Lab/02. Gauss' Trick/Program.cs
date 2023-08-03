namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> newList = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int sum = 0;
                int first = numbers[i];
                int last = numbers[numbers.Count - 1 - i];
                sum += first + last;
                newList.Add(sum);
            }

            if (numbers.Count % 2 != 0)
            {
                newList.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", newList));
        }
    }
}