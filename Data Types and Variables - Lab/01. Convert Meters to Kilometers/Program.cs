namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float kilometres = meters / 1000.0F;
            Console.WriteLine($"{kilometres:F2}");
        }
    }
}