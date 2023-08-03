namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(commands[1]));
                        break;
                    case "Insert":
                        if (int.Parse(commands[2]) >= 0 && int.Parse(commands[2]) < numbers.Count)
                        {
                            numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;
                    case "Remove":
                        if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < numbers.Count)
                        {
                            numbers.RemoveAt(int.Parse(commands[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        
                        break;
                    case "Shift":
                        numbers = Switch(numbers, commands[1], int.Parse(commands[2]));
                        break;
                }
            }

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        private static List<int> Switch(List<int> numbers, string direction, int count)
        {
            List<int> switchedNumbers = new List<int>();
            count %= numbers.Count;

            switch (direction)
            {
                case "left":
                    switchedNumbers = numbers.GetRange(0, count);
                    numbers.RemoveRange(0, count);
                    numbers.AddRange(switchedNumbers);
                    break;
                case "right":
                    switchedNumbers = numbers.GetRange(numbers.Count - count, count);
                    numbers.RemoveRange(numbers.Count - count, count);
                    numbers.InsertRange(0, switchedNumbers);
                    break;
            }
            return numbers;
        }
    }
}