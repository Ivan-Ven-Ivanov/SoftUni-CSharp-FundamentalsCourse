/*
1 2 3 4 5 5 5 6
Delete 5
Insert 10 1
Delete 5
end

*/

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                switch (arguments[0])
                {
                    case "Delete":
                        DeleteAllNumbersFromType(numbers, arguments);
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(arguments[2]), int.Parse(arguments[1]));
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void DeleteAllNumbersFromType(List<int> numbers, string[] arguments)
        {
            while (numbers.Contains(int.Parse(arguments[1])))
            {
                numbers.Remove(int.Parse(arguments[1]));
            }
        }
    }
}