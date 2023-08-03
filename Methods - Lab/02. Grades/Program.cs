namespace _02._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGradeDefinition(grade);
        }

        static void PrintGradeDefinition(double grade)
        {
            if (grade <= 6.00 && grade >= 5.50)
            {
                Console.WriteLine("Excellent");
            }
            else if (grade >= 4.50)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 3.50)
            {
                Console.WriteLine("Good");
            }
            else if(grade >= 3.00)
            {
                Console.WriteLine("Poor");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}