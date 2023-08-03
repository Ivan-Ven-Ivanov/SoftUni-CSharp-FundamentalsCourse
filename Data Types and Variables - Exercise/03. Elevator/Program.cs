namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double courses = Math.Ceiling((double)peopleCount / capacity);

            Console.WriteLine(courses);


        }
    }
}