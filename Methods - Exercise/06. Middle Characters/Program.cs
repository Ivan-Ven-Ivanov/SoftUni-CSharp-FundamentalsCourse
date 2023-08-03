namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacter(input);
        }

        static void PrintMiddleCharacter(string input)
        {
            char[] array = input.ToCharArray();

            string middleChar = "";

            if (array.Length % 2 != 0)
            {
                middleChar += array[array.Length / 2];
            }
            else
            {
                middleChar += array[array.Length / 2 - 1];
                middleChar += array[array.Length / 2];
            }

            Console.WriteLine(middleChar);
        }
    }
}