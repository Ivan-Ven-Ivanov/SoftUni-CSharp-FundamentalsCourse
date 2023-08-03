namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> playerTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (playerOne.Count != 0 && playerTwo.Count != 0)
            {
                if (playerOne[0] > playerTwo[0])
                {
                    playerOne.Add(playerOne[0]);
                    playerOne.Add(playerTwo[0]);
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
                else if (playerTwo[0] > playerOne[0])
                {
                    playerTwo.Add(playerTwo[0]);
                    playerTwo.Add(playerOne[0]);
                    playerTwo.RemoveAt(0);
                    playerOne.RemoveAt(0);
                }
                else
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
            }

            if (playerOne.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            }
        }
    }
}