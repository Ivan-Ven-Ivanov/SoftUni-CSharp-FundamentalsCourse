
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string decryptPattern = @"[sStTaArR]";
            int n = int.Parse(Console.ReadLine());
            List<Message> messages = new List<Message>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = Regex.Matches(input, decryptPattern);
                int decryptionKey = matches.Count;
                StringBuilder decrypted = new StringBuilder();
                for (int j = 0; j < input.Length; j++)
                {
                    char character = input[j];
                    decrypted.Append((char)(character - decryptionKey));
                }

                string pattern = @"[^@\-!:>]*@[^@\-!:>]*?(?<name>[A-Za-z]+)[^@\-!:>]*:[^@\-!:>]*?(?<population>\d+)[^@\-!:>]*![^@\-!:>]*(?<attack>[AD])[^@\-!:>]*![^@\-!:>]*->[^@\-!:>]*?(?<soldiers>\d+)[^@\-!:>]*";
                MatchCollection decryptedMessages = Regex.Matches(decrypted.ToString(), pattern);
                foreach (Match match in decryptedMessages)
                {
                    string planetName = match.Groups["name"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    string attackType = match.Groups["attack"].Value;
                    int soldiersCount = int.Parse(match.Groups["soldiers"].Value);

                    Message message = new Message(planetName, population, attackType, soldiersCount);
                    messages.Add(message);
                }
            }

            List<Message> attackedPlanets = messages.FindAll(x => x.AttackType == "A")
                .OrderBy(x => x.PlanetName)
                .ToList();
            List<Message> destroyedPlanets = messages.FindAll(x => x.AttackType == "D")
                .OrderBy(x => x.PlanetName)
                .ToList();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                foreach (Message message in attackedPlanets)
                {
                    Console.WriteLine($"-> {message.PlanetName}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (Message message in destroyedPlanets)
                {
                    Console.WriteLine($"-> {message.PlanetName}");
                }
            }
        }

        public class Message
        {
            public Message(string planetName, int population, string attackType, int soldiersCount)
            {
                PlanetName = planetName;
                Population = population;
                AttackType = attackType;
                SoldiersCount = soldiersCount;
            }

            public string PlanetName { get; set; }

            public int Population { get; set; }

            public string AttackType { get; set; }

            public int SoldiersCount { get; set; }
        }
    }
}