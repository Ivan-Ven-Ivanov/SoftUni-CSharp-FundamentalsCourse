namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> removed = new List<int>();

            while (list.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int temp;
                if (index < 0)
                {
                    temp = list[0];
                    removed.Add(list[0]);
                    list.RemoveAt(0);
                    list.Insert(0, list[list.Count - 1]);
                }
                else if (index > list.Count - 1)
                {
                    temp = list[list.Count - 1];
                    removed.Add(list[list.Count - 1]);
                    list.RemoveAt(list.Count - 1);
                    list.Add(list[0]);
                }
                else
                {
                    temp = list[index];
                    removed.Add(list[index]);
                    list.RemoveAt(index);
                }

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= temp)
                    {
                        list[i] += temp;
                    }
                    else
                    {
                        list[i] -= temp;
                    }
                }
            }

            Console.WriteLine(removed.Sum());
        }
    }
}