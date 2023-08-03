namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, Course> courses = new Dictionary<string, Course>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(" : ");
                string courseName = tokens[0];
                string studentName = tokens[1];


                if (!courses.ContainsKey(courseName))
                {
                    Course course = new Course(courseName);
                    courses.Add(course.Name, course);
                }

                courses[courseName].Students.Add(studentName);
            }

            foreach (Course value in courses.Values)
            {
                Console.WriteLine($"{value}".Trim());
            }
        }
    }

    public class Course
    {
        public Course(string name)
        {
            Name = name;
            Students = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Students { get; set; }

        public override string ToString()
        {
            string result = "";
            result += $"{Name}: {Students.Count}\n";
            foreach (string student in Students)
            {
                result += $"-- {student}\n";
            }
            return result;
        }
    }
}