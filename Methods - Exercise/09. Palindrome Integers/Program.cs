namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());
            }
        }

        static bool IsPalindrome(string input)
        {

            char[] array = input.ToCharArray();

            Array.Reverse(array);

            string reversed = new string(array);

            return input == reversed;

        }
    }
}