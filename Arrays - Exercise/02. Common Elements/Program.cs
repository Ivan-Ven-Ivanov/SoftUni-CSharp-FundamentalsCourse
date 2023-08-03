namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split();
            string[] secondArr = Console.ReadLine()
                .Split();

            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (firstArr[j] == secondArr[i])
                    {
                        Console.Write(firstArr[j] + " ");
                    }
                }
            }
        }
    }
}