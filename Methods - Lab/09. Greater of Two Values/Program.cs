using System.Diagnostics.CodeAnalysis;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if (type == "int")
            {
                int firstNumber = int.Parse(firstValue);
                int secondNumber = int.Parse(secondValue);   
                Console.WriteLine(GetMax(firstNumber, secondNumber));
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                Console.WriteLine(GetMax(firstChar, secondChar));
            }
            else
            {
                Console.WriteLine(GetMax(firstValue, secondValue));
            }
        }

        static string GetMax(string a, string b)
        {
            int comparison = a.CompareTo(b);
            if (comparison > 0)
            {
                return a;
            }
            else
            {
                return b;
            }       
        }

        static int GetMax(int a, int b)
        {
            int result = Math.Max(a, b);
            return result;
        }

        static char GetMax (char a, char b)
        {
            char result = (char)Math.Max(a, b);
            return result;
        }
    }
}