namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            IsPasswordValid(password);
        }

        static void IsPasswordValid(string password)
        {
            password = password.ToLower();
            char[] array = password.ToCharArray();
            bool isValid = true;
            int counterOfDigits = 0;

            if (array.Length < 6 || array.Length > 10)
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            for (int i = 0; i < array.Length; i++)
            {
                char firstSymbol = array[i];
                if (firstSymbol >= 48 && firstSymbol <= 57)
                {
                    counterOfDigits++;
                }

                if (firstSymbol < 48 || (firstSymbol > 57 && firstSymbol < 97) || firstSymbol > 122)
                {
                    isValid = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
            }


            if (counterOfDigits < 2)
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}