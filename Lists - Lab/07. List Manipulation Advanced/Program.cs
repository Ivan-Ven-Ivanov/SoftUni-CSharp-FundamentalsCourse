using System.ComponentModel;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> notEditedList = new List<int>();
            foreach (int number in numbers)
            {
                notEditedList.Add(number);
            }

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> arguments = input.Split()
                    .ToList();
                string command = arguments[0];
                int n;

                switch (command)
                {
                    case "Add":
                        n = int.Parse(arguments[1]);
                        numbers.Add(n);
                        break;
                    case "Remove":
                        n = int.Parse(arguments[1]);
                        numbers.Remove(n);
                        break;
                    case "RemoveAt":
                        n = int.Parse(arguments[1]);
                        numbers.RemoveAt(n);
                        break;
                    case "Insert":
                        n = int.Parse(arguments[1]);
                        numbers.Insert(int.Parse(arguments[2]), n);
                        break;
                    case "Contains":
                        n = int.Parse(arguments[1]);
                        if (IsNumberInList(numbers, n))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        PrintAllEvenNumbers(numbers);
                        break;
                    case "PrintOdd":
                        PrintAllOddNumbers(numbers);
                        break;
                    case "GetSum":
                        PrintSumOfAllNumbers(numbers);
                        break;
                    case "Filter":
                        string condition = arguments[1];
                        int conditionNumber = int.Parse(arguments[2]);
                        PrintAllNumbersOnCondition(numbers, condition, conditionNumber);
                        break;
                }
            }

            bool isEqual = true;
            for (int i = 0; i < Math.Min(numbers.Count, notEditedList.Count); i++)
            {
                if (numbers[i] != notEditedList[i])
                {
                    isEqual = false;
                    break;
                }
            }

            if(numbers.Count != notEditedList.Count)
            {
                isEqual = false;
            }

            if (!isEqual)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static void PrintAllNumbersOnCondition(List<int> list, string condition, int conditionNumber)
        {
            List<int> newList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (condition == "<")
                {
                    if (list[i] < conditionNumber)
                    {
                        newList.Add(list[i]);
                    }
                }
                else if (condition == ">")
                {
                    if (list[i] > conditionNumber)
                    {
                        newList.Add(list[i]);
                    }
                }
                else if (condition == ">=")
                {
                    if (list[i] >= conditionNumber)
                    {
                        newList.Add(list[i]);
                    }
                }
                else if (condition == "<=")
                {
                    if (list[i] <= conditionNumber)
                    {
                        newList.Add(list[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", newList));
        }

        static void PrintSumOfAllNumbers(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            Console.WriteLine(sum);
        }

        static void PrintAllOddNumbers(List<int> list)
        {
            List<int> oddList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    oddList.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ", oddList));
        }

        static void PrintAllEvenNumbers(List<int> list)
        {
            List<int> evenList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    evenList.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ", evenList));
        }

        static bool IsNumberInList(List<int> list, int n)
        {
            return list.Contains(n);
        }
    }
}