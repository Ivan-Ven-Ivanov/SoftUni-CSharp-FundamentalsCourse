namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            PrintAllCharactersBetween(firstSymbol, secondSymbol);
        }

        static void PrintAllCharactersBetween(char a, char b)
        {
            int first = a;
            int second = b;

            if(first > second)
            {
                for (int i = second + 1; i < first; i++)
                {
                    char digit = (char)i;

                    Console.Write(digit + " ");
                }
            }
            else
            {
                for (int i = first + 1; i < second; i++)
                {
                    char digit = (char)i;

                    Console.Write(digit + " ");
                }
            }
            
        } 
    }
}