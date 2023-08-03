namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            float totalExpenses = 0;
            int keyboardTrash = 0;


            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    totalExpenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    totalExpenses += mousePrice;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    totalExpenses += keyboardPrice;
                    keyboardTrash++;

                    if (keyboardTrash % 2 == 0)
                    {
                        totalExpenses += displayPrice;
                    }
                }
                
            }
            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv."); */

            int LostGamesCount = int.Parse(Console.ReadLine());
            double HeadsetPrice = double.Parse(Console.ReadLine());
            double MousePrice = double.Parse(Console.ReadLine());
            double KeyboardPrice = double.Parse(Console.ReadLine());
            double DisplayPrice = double.Parse(Console.ReadLine());

            double HeadsetCost = (LostGamesCount / 2) * HeadsetPrice;
            double MiceCost = (LostGamesCount / 3) * MousePrice;
            double KeyboardCost = (LostGamesCount / 6) * KeyboardPrice;
            double DisplayCost = (LostGamesCount / 12) * DisplayPrice;
            double Expenses = HeadsetCost + MiceCost + KeyboardCost + DisplayCost;

            Console.WriteLine($"Rage expenses: {Expenses:f2} lv.");
        }
    }
}