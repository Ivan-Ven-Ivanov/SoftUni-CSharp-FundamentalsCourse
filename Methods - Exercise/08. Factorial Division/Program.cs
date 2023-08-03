namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{DivisionOfTwoFactorials(firstNumber, secondNumber):F2}");
        }

        static double DivisionOfTwoFactorials(int num1, int num2)
        {
            return (double)Factorial(num1) / Factorial(num2);
        }

        static long Factorial(long number)
        {
            long factorialSum = number;
            for (int i = 1; i < number; i++)
            {
                factorialSum *= i;
            }

            return factorialSum;
        }
    }
}