using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            string currentPassword = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                char symbol = username[i];
                password += symbol;
            }

            int wrongPassCounter = 0;
            while ((currentPassword = Console.ReadLine()) != password)
            {
                wrongPassCounter++;
                if (wrongPassCounter >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                
            }

            if (currentPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}