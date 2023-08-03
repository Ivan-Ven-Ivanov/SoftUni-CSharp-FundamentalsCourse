namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int index = 0;
            bool isBreak = false;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (i < j)
                    {
                        rightSum += array[j];
                    }
                    else if (j == i)
                    {
                        continue;
                    }
                    else if (i > j)
                    {
                        leftSum += array[j];
                    }
                }

                if (leftSum == rightSum)
                {
                    index = i;
                    isBreak = true;
                    break;
                }
            }

            if (isBreak)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}