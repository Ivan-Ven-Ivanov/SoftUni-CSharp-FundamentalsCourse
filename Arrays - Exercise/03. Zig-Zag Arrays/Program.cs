namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] inputArr = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int num1 = inputArr[0];
                int num2 = inputArr[1];

                if (i % 2 == 0)
                {
                    firstArr[i] = num1;
                    secondArr[i] = num2;
                }
                else
                {
                    firstArr[i] = num2;
                    secondArr[i] = num1;
                }
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}