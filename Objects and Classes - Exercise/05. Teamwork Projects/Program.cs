/*
2
John-PowerPuffsCoders
Tony-Tony is the best
Peter->PowerPuffsCoders
Tony->Tony is the best
end of assignment

*/
namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int teamsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamsCount; i++)
            {
                string[] creatorsWithTeams = Console.ReadLine()
                    .Split("-");
                string creator = creatorsWithTeams[0];
                string team = creatorsWithTeams[1];

                Team teamAlreadyCreated = teams.Find(x => x.Name == team);

                if (teamAlreadyCreated != null)
                {
                    Console.WriteLine($"Team {team} was already created!");
                    continue;
                }

                Team creatorHasCreated = teams.Find(x => x.Creator == creator);

                if (creatorHasCreated != null)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team createdTeam = new Team(team, creator);
                teams.Add(createdTeam);
                Console.WriteLine($"Team {team} has been created by {creator}!");
            }

            string input;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] membersWithTeams = input.Split("->");
                string member = membersWithTeams[0];
                string teamName = membersWithTeams[1];

                Team existingMember = teams.Find(x => x.Members.Contains(member));
                if (existingMember != null)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                Team memberIsCreator = teams.Find(x => x.Creator == member);

                if (memberIsCreator != null)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                Team existingTeam = teams.Find(x => x.Name == teamName);
                if (existingTeam != null)
                {
                    existingTeam.Members.Add(member);
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
            }

            List<Team> validTeams = teams.FindAll(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.Name)
                .ToList();
            List<Team> disbandedTeams = teams.FindAll(x => x.Members.Count <= 0)
                .OrderBy(x => x.Name)
                .ToList();

            if (validTeams.Count > 0)
            {
                Console.WriteLine(string.Join("", validTeams).Trim());
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team team in disbandedTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public override string ToString()
        {
            Members.Sort();
            string result = "";
            result += $"{Name}\n";
            result += $"- {Creator}\n";
            foreach (string member in Members)
            {
                result += $"-- {member}\n";
            }
            return result;
        }

    }
}