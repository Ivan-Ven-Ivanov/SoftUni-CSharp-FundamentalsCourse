namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetCount = 0;
            int originalPower = power;

            while (power >= distance)
            {
                power -= distance;
                targetCount++;

                if (power == originalPower * 0.5)
                {
                    if (exhaustionFactor != 0)
                    {
                        power /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(targetCount);
        }
    }
}