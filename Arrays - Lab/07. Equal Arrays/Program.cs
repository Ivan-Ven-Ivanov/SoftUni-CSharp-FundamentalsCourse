using System;
using System.Linq;
using System.Reflection;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] arr2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool isIdentical = true;

            for (int i = 0; i < arr1.Length; i++)
            {
                int arr1Number = arr1[i];
                int arr2Number = arr2[i];

                if (arr1Number == arr2Number)
                {
                    sum += arr1Number;
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    isIdentical = false;
                    break;
                }
            }

            if (isIdentical) 
            { 
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}