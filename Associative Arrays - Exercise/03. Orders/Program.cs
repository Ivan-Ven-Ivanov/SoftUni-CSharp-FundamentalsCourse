using System.Collections.Concurrent;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, Product> productPrices = new Dictionary<string, Product>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] commands = input.Split();

                string name = commands[0];
                decimal price = decimal.Parse(commands[1]);
                int quantity = int.Parse(commands[2]);

                Product product = new Product(name, price, quantity);

                if (!productPrices.ContainsKey(product.Name))
                {
                    productPrices.Add(product.Name, product);
                }
                else
                {
                    productPrices[product.Name].Update(product.Price, product.Quantity);
                }
            }

            foreach ( Product value in productPrices.Values )
            {
                Console.WriteLine(value);
            }
        }
    }

    public class Product
    {
        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public void Update(decimal price, int quantity)
        {
            Price = price;
            Quantity += quantity;
        }

        public decimal TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }

        public override string ToString()
        {
            return $"{Name} -> {TotalPrice:F2}";
        }
    }
}