namespace _05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(string.Join("", input.Where(x => char.IsDigit(x))));
            Console.WriteLine(string.Join("", input.Where(char.IsLetter)));
            Console.WriteLine(string.Join("", input.Where(x => !char.IsLetterOrDigit(x))));
        }
    }
}