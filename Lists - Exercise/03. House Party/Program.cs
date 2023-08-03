namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();
                string name = input[0];

                if (!guestList.Contains(name))
                {
                    if (input[2] != "not")
                    {
                        guestList.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (input[2] != "not")
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestList.Remove(name);                      
                    }
                }
            }

            foreach (string guest in guestList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}