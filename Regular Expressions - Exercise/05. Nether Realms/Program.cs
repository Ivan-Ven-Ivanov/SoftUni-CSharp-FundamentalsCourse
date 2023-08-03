using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> demonNames = Console.ReadLine()
                .Split(",", StringSplitOptions.TrimEntries)
                .ToList();
            List<Demon> demons = new List<Demon>();
            string healthPattern = @"[^0-9+,\-*/.]";
            string damagePattern = @"-?\d+(?:\.\d+)?";
            string arithmeticPattern = @"[/*]";

            foreach (string name in demonNames) 
            {
                MatchCollection healthMatches = Regex.Matches(name, healthPattern);
                decimal health = 0;
                foreach (Match healthMatch in healthMatches)
                {
                    char matchedChar = char.Parse(healthMatch.Value);
                    health += matchedChar;
                }

                MatchCollection damageMatches = Regex.Matches(name, damagePattern);
                decimal damage = 0;
                foreach (Match damageMatch in damageMatches)
                {
                    damage += decimal.Parse(damageMatch.Value);
                }

                MatchCollection arithmeticMatches = Regex.Matches(name, arithmeticPattern);
                foreach (Match arithmeticMatch in arithmeticMatches)
                {
                    if (arithmeticMatch.Value == "*")
                    {
                        damage *= 2;
                    }
                    else if (arithmeticMatch.Value == "/")
                    {
                        damage /= 2;
                    }
                }

                Demon demon = new Demon(name, health, damage);
                demons.Add(demon);
            }

            List<Demon> sortedDemons = demons.OrderBy(x => x.Name)
                .ToList();
            foreach (Demon sortedDemon in sortedDemons)
            {
                Console.WriteLine($"{sortedDemon.Name} - {sortedDemon.Health} health, {sortedDemon.Damage:F2} damage");
            }

        }
    }

    public class Demon
    {
        public Demon(string name, decimal health, decimal damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }

        public decimal Health { get; set; }

        public decimal Damage { get; set; }
    }
}