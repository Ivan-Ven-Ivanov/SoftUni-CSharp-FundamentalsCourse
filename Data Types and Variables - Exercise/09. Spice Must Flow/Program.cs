namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int daysCount = 0;
            int spicesExtracted = 0;

            while (yield >= 100)
            {
                spicesExtracted += yield;
                yield -= 10;
                daysCount++;
                spicesExtracted -= 26;
            }

            spicesExtracted -= 26;

            if (spicesExtracted < 0)
            {
                spicesExtracted = 0;
            }

            Console.WriteLine(daysCount);
            Console.WriteLine(spicesExtracted);
        }
    }
}