namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                string name = tokens[0];
                string iD = tokens[1];
                int age = int.Parse(tokens[2]);

                Person person = new Person(name, iD, age);

                Person sameID = people.Find(x => x.ID == iD);
                if (sameID != null)
                {
                    sameID.Name = name;
                    sameID.Age = age;
                    continue;
                }

                people.Add(person);
            }

            List<Person> orderedPeople = people.OrderBy(x => x.Age)
                .ToList();

            Console.WriteLine(string.Join("\n", orderedPeople));
        }
    }

    public class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }

    }
}