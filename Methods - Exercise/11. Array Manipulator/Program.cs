/*using System.Windows.Input;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[] input = Console.ReadLine()
                .Split();
            string command = input[0];
            int index = int.Parse(input[1]);

            while (command != "end")
            {
                switch (command)
                {
                    case "exchange":

                        if (index >= 0 && index < numbersArray.Length)
                        {
                            Exchange(numbersArray, index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "max":
                        command = input[1];
                        Max(numbersArray, command);
                        break;
                    case "min":
                        command = input[1];
                        Min(numbersArray, command);
                        break;
                    case "first":
                        int count = int.Parse(input[1]);
                        command = input[2];
                        if (count > numbersArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            First(numbersArray, count, command);
                        }
                        break;
                    case "last":
                        count = int.Parse(input[1]);
                        command = input[2];
                        if (count > numbersArray.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            Last(numbersArray, count, command);
                        }
                        break;
                }

                input = Console.ReadLine()
                    .Split();
                command = input[0];
            }

            Console.WriteLine($"[{string.Join(", ", Exchange(numbersArray, index))}]");
        }

        static int[] Exchange(int[] array, int n)
        {
            int[] exchangedArray = new int[array.Length];

            for (int i = 0; i < array.Length - n - 1; i++)
            {
                exchangedArray[i] = array[n + 1 + i];
            }

            for (int i = 0; i <= n; i++)
            {
                exchangedArray[n + i] = array[i];
            }

            return exchangedArray;
        }

        static void Max(int[] array, string command)
        {
            int maxIndex = -1;
            int maxNumber = int.MinValue;
            int number = 0;
            int counter = 0;

            if (command == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[0] % 2 == 0)
                    {
                        number = array[0];
                        counter++;
                    }
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                        maxIndex = i;
                    }
                }
            }
            else if (command == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[0] % 2 != 0)
                    {
                        number = array[0];
                        counter++;
                    }
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                        maxIndex = i;
                    }
                }
            }
            if (counter < 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        static void Min(int[] array, string command)
        {
            int minIndex = -1;
            int minNumber = int.MaxValue;
            int number = 0;
            int counter = 0;

            if (command == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[0] % 2 == 0)
                    {
                        number = array[0];
                        counter++;
                    }
                    if (number < minNumber)
                    {
                        minNumber = number;
                        minIndex = i;
                    }
                }
            }
            else if (command == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[0] % 2 != 0)
                    {
                        number = array[0];
                        counter++;
                    }
                    if (number < minNumber)
                    {
                        minNumber = number;
                        minIndex = i;
                    }
                }
            }
            if (counter < 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }

        static void First(int[] array, int n, string command)
        {
            int counter = 0;
            int number;
            for (int i = 0; i < array.Length; i++)
            {
                if (command == "even")
                {
                    if (array[i] % 2 == 0)
                    {
                        number = array[i];
                        counter++;
                        if (counter < n)
                        {
                            Console.Write($"[{i}, ");
                            if (counter == n - 1)
                            {
                                Console.Write("]");
                                return;
                            }
                        }
                    }
                }
                else if (command == "odd")
                {
                    if (array[i] % 2 != 0)
                    {
                        number = array[i];
                        counter++;
                        if (counter < n)
                        {
                            Console.Write($"[{i}, ");
                            if (counter == n - 1)
                            {
                                Console.Write("]");
                                return;
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.Write("[");
            }
            Console.Write("]");
        }

        static void Last(int[] array, int n, string command)
        {
            int counter = 0;
            int number;
            string numbersText = "";
            for (int i = array.Length - 1; i < 0; i--)
            {
                if (command == "even")
                {
                    if (array[i] % 2 == 0)
                    {
                        number = array[i];
                        counter++;
                        if (counter < n)
                        {
                            numbersText = i + numbersText;
                            if (counter == n - 1)
                            {
                                return;
                            }
                        }
                    }
                }
                else if (command == "odd")
                {
                    if (array[i] % 2 != 0)
                    {
                        number = array[i];
                        counter++;
                        if (counter < n)
                        {
                            numbersText = i + ", " + numbersText;
                            if (counter == n - 1)
                            {
                                return;
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.Write("[]");
            }
            else
            {
                Console.Write($"[{numbersText}]");
            }
        }
    }
}
*/

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine() 
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (command != "end") 
        {
            string[] commandArgs = command.Split();

            switch (commandArgs[0])
            {
                case "exchange":
                    int index = int.Parse(commandArgs[1]);
                    numbers = ExchangeElements(numbers, index);
                    break;
                case "max":
                    string maxType = commandArgs[1];
                    PrintMaxIndex(numbers, maxType);
                    break;
                case "min":
                    string minType = commandArgs[1];
                    PrintMinIndex(numbers, minType);
                    break;
                case "first":
                    int length = int.Parse(commandArgs[1]);
                    string firstType = commandArgs[2];
                    PrintFirstElements(numbers, length, firstType);
                    break;
                case "last":
                    int lastCount = int.Parse(commandArgs[1]);
                    string lastType = commandArgs[2];
                    PrintLastElements(numbers, lastCount, lastType);
                    break;
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }

    static int[] ExchangeElements(int[] array, int index)
    {
        if (CheckForOutOfRange(array, index))
        {
            Console.WriteLine("Invalid index");
            return array;
        }

        int[] changedArray = new int[array.Length];
        int changedArrayIndex = 0;

        for (int i = index + 1; i <= array.Length - 1; i++)
        {
            changedArray[changedArrayIndex++] = array[i];
        }

        for (int i = 0; i <= index; i++)
        {
            changedArray[changedArrayIndex++] = array[i];
        }

        return changedArray;
    }

    static void PrintMaxIndex(int[] numbers, string type)
    {
        int maxIndex = -1;
        int maxNumber = int.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            if (IsOddOrEven(type, number))
            {
                if (number >= maxNumber)
                {
                    maxNumber = number;
                    maxIndex = i;
                }
            }
        }

        PrintNotDefaultIndex(maxIndex);
    }

    static void PrintMinIndex(int[] numbers, string type)
    {
        int minIndex = -1;
        int minNumber = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            if (IsOddOrEven(type, number))
            {
                if (number <= minNumber)
                {
                    minNumber = number;
                    minIndex = i;
                }
            }
        }

        PrintNotDefaultIndex(minIndex);
    }

    static void PrintFirstElements(int[] numbers, int count, string type)
    {
        if (count > numbers.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        string firstElements = "";
        int elementCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            if (IsOddOrEven(type, number))
            {
                firstElements += $"{number}, ";
                elementCount++;
                if (elementCount >= count)
                {
                    break;
                }
            }
        }

        Console.WriteLine($"[{firstElements.Trim(' ', ',')}]");
    }

    static void PrintLastElements(int[] numbers, int count, string type)
    {
        if (count > numbers.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }

        string lastElements = "";
        int elementCount = 0;

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            int number = numbers[i];
            if (IsOddOrEven(type, number))
            {
                lastElements = $"{number}, " + lastElements;
                elementCount++;
                if (elementCount == count)
                {
                    break;
                }
            }
        }

        Console.WriteLine($"[{lastElements.Trim(' ', ',')}]");
    }

    static bool CheckForOutOfRange(int[] numbers, int index)
    {
        return index < 0 || index >= numbers.Length;
    }

    static bool IsOddOrEven(string type, int number)
    {
        return (type == "even" && number % 2 == 0) ||
               (type == "odd" && number % 2 != 0);
    }

    static void PrintNotDefaultIndex(int index)
    {
        if (index != -1)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}