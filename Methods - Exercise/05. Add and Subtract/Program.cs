namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractTwoNumbers(firstNumber, secondNumber, thirdNumber));
        }

        static int SumOfTwoNumbers(int first, int second)
        {
            return first + second;
        }

        static int SubtractTwoNumbers(int first, int second, int third)
        {
            return SumOfTwoNumbers(first, second) - third;
        }
    }
}