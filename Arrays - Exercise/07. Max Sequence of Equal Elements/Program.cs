namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bestSequence = 0;
            int bestSymbol = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 1;
                
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (bestSequence < counter)
                {
                    bestSequence = counter;
                    bestSymbol = array[i];
                }
            }
            int[] best = new int[bestSequence];

            for (int i = 0; i < bestSequence; i++)
            {
                best[i] = bestSymbol;
            }

            Console.WriteLine(string.Join(" ", best));
        }
    }
}