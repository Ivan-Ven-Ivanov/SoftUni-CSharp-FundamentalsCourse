namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string command = "";
            int bestSum = 0;
            int bestSequenceSum = 0;
            int index = int.MaxValue;
            int lowestIndex = int.MaxValue;
            int[] bestArray = new int[length];
            int bestSequence = 0;
            int inputCounter = 0;
            int bestCounter = 0;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                inputCounter++;

                int[] array = command.Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();


                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                    int counter = 1;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            if (array[i] == 1)
                            {
                                counter++;
                                lowestIndex = i;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (bestSequence < counter)
                    {
                        bestSequence = counter;
                        bestArray = array;
                        bestSequenceSum = sum;
                        bestCounter = inputCounter;
                    }

                }

                if (lowestIndex < index)
                {
                    index = lowestIndex;
                    bestArray = array;
                    bestSequenceSum = sum;
                    bestCounter = inputCounter;
                }


                if (bestSum < sum)
                {
                    bestSum = sum;
                    bestArray = array;
                    bestSequenceSum = sum;
                    bestCounter = inputCounter;
                }


            }

            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestArray));
        }
    }
}