namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if (Char.IsUpper(letter))
            {
                Console.WriteLine("upper-case");
            }
            else if (Char.IsLower(letter))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}