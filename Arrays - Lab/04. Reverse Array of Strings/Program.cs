using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console
                .ReadLine()
                .Split(' ')
                .ToArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                string firstCharacter = array[i];
                string lastCharacter = array[array.Length - 1 - i];
                array[i] = lastCharacter;
                array[array.Length - 1 - i] = firstCharacter;
            }

            Console.WriteLine(string.Join(' ', array));
        }
    }
}