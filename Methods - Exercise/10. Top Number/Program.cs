namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTopNumbersInRange(n);
        }

        static void PrintTopNumbersInRange(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (SumOfDigits(i) % 8 == 0 && HasMinimumOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int SumOfDigits(int n)
        {
            int sumOfDigits = 0;
            while (n != 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {

                }
                sumOfDigits += lastDigit;
                n /= 10;
            }

            return sumOfDigits;
        }

        static bool HasMinimumOddDigit(int n)
        {
            int oddDigitCounter = 0;
            while (n != 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    oddDigitCounter++;
                }
                n /= 10;
            }

            if (oddDigitCounter > 0)
            {
                return true;
            }
            return false;
        }
    }
}