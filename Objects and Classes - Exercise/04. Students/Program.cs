using System.Diagnostics;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();
                string firstName = input[0];
                string lastName = input[1];
                decimal grade = decimal.Parse(input[2]);
                
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            List<Student> orderedByGrades = students.OrderByDescending(x => x.Grade)
                .ToList();

            Console.WriteLine(string.Join("\n", orderedByGrades));
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, decimal grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}