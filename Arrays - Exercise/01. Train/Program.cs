namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonCount = int.Parse(Console.ReadLine());
            int[] passengers = new int[wagonCount];

            for (int i = 0; i < wagonCount; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", passengers));
            Console.WriteLine(passengers.Sum());
        }
    }
}