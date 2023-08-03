namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PriceOfOrder(product, quantity);
        }

        static void PriceOfOrder (string input, int n)
        {
            double price = 0;
            switch (input)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }

            double totalPrice = price * n;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}