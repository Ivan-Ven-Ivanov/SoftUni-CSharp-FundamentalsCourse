namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input, repeatCount));
        }

        static string RepeatString (string input, int n)
        {
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                result += input;
            }
            return result;
        }
    }
}