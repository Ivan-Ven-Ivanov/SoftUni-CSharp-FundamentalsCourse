namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource;

            Dictionary<string, int> resourceQuantities = new Dictionary<string, int>();

            while ((resource = Console.ReadLine())!= "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resourceQuantities.ContainsKey(resource))
                {
                    resourceQuantities.Add(resource, 0);
                }

                resourceQuantities[resource] += quantity;
            }

            foreach (KeyValuePair<string, int> pair in resourceQuantities)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}