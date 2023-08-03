namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                int passengers;
                if (arguments[0] == "Add")
                {
                    passengers = int.Parse(arguments[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    passengers = int.Parse(arguments[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (maxCapacity - wagons[i] >= passengers)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}