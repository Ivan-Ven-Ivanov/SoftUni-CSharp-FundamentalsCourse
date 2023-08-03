namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int nameIndex = path.LastIndexOf('\\');
            int extensionIndex = path.LastIndexOf('.');
            string fileName = path.Substring(nameIndex + 1, extensionIndex - nameIndex - 1);
            string extension = path.Substring(extensionIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}