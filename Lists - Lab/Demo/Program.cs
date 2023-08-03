namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };

            List<int> shifted = list.GetRange(0, 2);
            list.RemoveRange(0, 2);
            list.InsertRange(list.Count, shifted);

            Console.WriteLine();




        }
    }
}