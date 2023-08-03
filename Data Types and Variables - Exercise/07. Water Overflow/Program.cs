namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int litersInTank = 0;
            int capacity = 255;

            for (int i = 0; i < n; i++)
            {
                int litersWater = int.Parse(Console.ReadLine());
                if (litersWater <= capacity)
                {
                    litersInTank += litersWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                capacity -= litersWater;
            }

            Console.WriteLine(litersInTank);
        }
    }
}