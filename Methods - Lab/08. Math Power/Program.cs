namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(number, power));
        }

        static double RaiseToPower(double num, int pow)
        {
            double result = Math.Pow(num, pow);

            return result;
        }
    }
}