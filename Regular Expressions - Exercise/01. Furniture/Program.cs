using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Furniture> furnitures = new List <Furniture> ();
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(?:\.\d+)?)!(?<quantity>\d+)";
            string input;
            decimal moneySpent = 0m;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                MatchCollection matches = Regex.Matches (input, pattern);
                foreach (Match match in matches)
                {
                    string name = match.Groups["name"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    uint quantity = uint.Parse(match.Groups["quantity"].Value);

                    Furniture furniture = new Furniture (name, price, quantity);
                    furnitures.Add(furniture);
                    moneySpent += furniture.Total;
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach(Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture.Name);
            }

            Console.WriteLine($"Total money spend: {moneySpent:F2}");
        }
    }

    public class Furniture
    {
        public Furniture(string name, decimal price, uint quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public uint Quantity { get; set; }

        public decimal Total
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
}