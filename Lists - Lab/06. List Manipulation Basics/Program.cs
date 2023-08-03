namespace _06._List_Manipulation_Basics
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
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> arguments = input.Split()
                    .ToList();
                string command = arguments[0];
                int n = int.Parse(arguments[1]);

                switch(command)
                {
                    case "Add":
                        numbers.Add(n);
                        break;
                    case "Remove":
                        numbers.Remove(n);
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(n);
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(arguments[2]), n);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

/*
23 1 456 63 32 87 9 32
Remove 5
Add 1
Insert 14 2
RemoveAt 3
Add 34
end
*/