using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int smallNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(MultyplyBigNumbers(bigNumber, smallNumber));
        }

        private static string MultyplyBigNumbers(string bigNumber, int smallNumber)
        {
            if (bigNumber == "0" || smallNumber == 0)
            {
                return "0";
            }
            StringBuilder sb = new StringBuilder();
            int carry = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(bigNumber[i].ToString());
                int product = digit * smallNumber + carry;

                sb.Insert(0, product % 10);
                carry = product / 10;
            }

            if (carry > 0)
            {
                sb.Insert(0, carry);
            }
            return sb.ToString();
        }
    }
}