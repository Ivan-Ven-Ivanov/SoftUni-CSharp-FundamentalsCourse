namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bestNum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool isBreak = false;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        bestNum = array[i];
                    }
                    else
                    {
                        isBreak = true;
                        break;
                    }
                }

                if (isBreak == false)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}