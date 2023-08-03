using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(?:\.\d+)?)\$";
            string input;
            decimal totalIncome = 0m;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                foreach (Match match in Regex.Matches(input, pattern))
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    uint count = uint.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    Order order = new Order(name, product, count, price);

                    Console.WriteLine($"{name}: {product} - {order.Total:F2}");
                    totalIncome += order.Total;
                }
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }

    public class Order
    {
        public Order(string name, string product, uint count, decimal price)
        {
            Name = name;
            Product = product;
            Count = count;
            Price = price;
        }

        public string Name { get; set; }

        public string Product { get; set; }

        public uint Count { get; set; }

        public decimal Price { get; set; }

        public decimal Total
        {
            get
            {
                return Price * Count;
            }
        }
    }
}