using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int numberLength = number.Length;
            int factorialSum = 0;

            for (int i = 0; i < numberLength; i++)
            {
                int separateNumber = number[i] - 48;

                int factorial = 1;

                for (int x = 1; x <= separateNumber; x++)
                {
                    factorial *= x;
                }
                factorialSum += factorial;
            }

            if (factorialSum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}