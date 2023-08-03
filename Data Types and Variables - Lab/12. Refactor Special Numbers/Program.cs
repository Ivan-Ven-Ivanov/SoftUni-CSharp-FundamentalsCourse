namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            for (int i = 1; i <= inputNumber; i++)
            {

                int number = i;
                while (i > 0)
                {
                    sumOfDigits += i % 10;
                    i = i / 10;
                }
                bool isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecial);
                sumOfDigits = 0;
                i = number;
            }

        }


    }
}