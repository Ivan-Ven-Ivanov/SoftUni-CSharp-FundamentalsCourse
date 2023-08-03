namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                decimal studentGrade = decimal.Parse(Console.ReadLine());


                if (!students.ContainsKey(studentName))
                {
                    Student student = new Student(studentName);
                    students.Add(student.Name, student);
                }

                students[studentName].Grades.Add(studentGrade);
            }

            var topStudents = students.Where(x => x.Value.AverageGrade >= 4.50m);

            foreach (var pair in topStudents)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }

    class Student
    {
        public Student(string name)
        {
            Name = name;
            Grades = new List<decimal>();
        }

        public string Name { get; set; }

        public List<decimal> Grades { get; set; }

        public decimal AverageGrade
        {
            get
            {
                return Grades.DefaultIfEmpty()
                    .Average();
            }
        }

        public override string ToString()
        {
            return $"{Name} -> {AverageGrade:F2}";
        }
    }
}