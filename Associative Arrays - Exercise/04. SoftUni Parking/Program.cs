namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, User> users = new Dictionary<string, User>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string command = input[0];
                string username = input[1];

                switch (command)
                {
                    case "register":

                        string licensePlate = input[2];
                        User user = new User(username, licensePlate);

                        if (!users.ContainsKey(user.Username))
                        {
                            users.Add(user.Username, user);
                            Console.WriteLine($"{user.Username} registered {user.LicensePlate} successfully");
                        }
                        else
                        {
                            User foundUser = users[user.Username];
                            Console.WriteLine($"ERROR: already registered with plate number {foundUser.LicensePlate}");
                        }

                        break;
                    case "unregister":

                        if (users.ContainsKey(username))
                        {
                            users.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }

                        break;
                }
            }

            foreach (User value in users.Values)
            {
                Console.WriteLine(value);
            }
        }
    }

    public class User
    {
        public User(string username, string licensePlate)
        {
            Username = username;
            LicensePlate = licensePlate;
        }

        public string Username { get; set; }

        public string LicensePlate { get; set; }

        public override string ToString()
        {
            return $"{Username} => {LicensePlate}";
        }
    }
}