using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Participant> participants = new List<Participant>();
            string[] names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in names)
            {
                Participant participant = new Participant();
                participant.Name = name;
                participant.Distance = 0m;
                participants.Add(participant);
            }

            string input;
            string letterPattern = @"[A-Za-z]";
            string digitPattern = @"\d";
            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder sb = new StringBuilder();
                foreach (Match match in Regex.Matches(input, letterPattern))
                {
                    sb.Append(match.Value);
                }

                decimal distance = 0m;
                foreach (Match match in Regex.Matches(input, digitPattern))
                {
                    distance += decimal.Parse(match.Value);
                }

                Participant foundParticipant = participants.FirstOrDefault(x => x.Name == sb.ToString());

                if (foundParticipant != null)
                {
                    foundParticipant.Distance += distance;
                }
            }

            List<Participant>orderedParticipants = participants.OrderByDescending(x => x.Distance)
                .Take(3)
                .ToList();

            if (participants.Count >= 3)
            {
                Console.WriteLine($"1st place: {orderedParticipants[0].Name}\n" +
                    $"2nd place: {orderedParticipants[1].Name}\n" +
                    $"3rd place: {orderedParticipants[2].Name}");
            }
        }
    }

    class Participant
    {
        public string Name { get; set; }

        public decimal Distance { get; set; }
    }
}