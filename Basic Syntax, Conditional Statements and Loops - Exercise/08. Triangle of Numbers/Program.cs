using System;

namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                counter++;
            }
        }
    }
}