namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companies = new Dictionary<string, Company>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(" -> ");

                string companyName = tokens[0];
                string employeeId = tokens[1];

                if (!companies.ContainsKey(companyName))
                {
                    Company company = new Company(companyName);
                    companies.Add(companyName, company);
                }

                if (companies[companyName].Employees.Any(x => x.ID.Contains(employeeId)))
                {
                    continue;
                }

                Employee employee = new Employee(employeeId);
                companies[companyName].Employees.Add(employee);
            }

            foreach (KeyValuePair<string, Company> pair in companies)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }

    public class Company
    {
        public Company(string name)
        {
            Name = name;
            Employees = new List<Employee>();
        }

        public string Name { get; set; }

        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            string result = "";
            result += $"{Name}\n";
            foreach (Employee list in Employees)
            {
                result += list;
            }

            return result.Trim();
        }
    }

    public class Employee
    {
        public Employee(string iD)
        {
            ID = iD;
        }

        public string ID { get; set; }

        public override string ToString()
        {           
            return $"-- {ID}\n";
        }
    }
}