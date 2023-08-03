namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        static int GetSumOfOddDigits(int number)
        {
            int sumOfOdd = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOfOdd += lastDigit;
                }

                number /= 10;
            }

            return sumOfOdd;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumOfEven = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sumOfEven += lastDigit;
                }

                number /= 10;
            }

            return sumOfEven;
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);

            return result;
        }
    }
}