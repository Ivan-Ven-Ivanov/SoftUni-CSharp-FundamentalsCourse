namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string partToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(partToRemove))
            {
                int index = text.IndexOf(partToRemove);
                text = text.Remove(index, partToRemove.Length);
            }

            Console.WriteLine(text);
        }
    }
}