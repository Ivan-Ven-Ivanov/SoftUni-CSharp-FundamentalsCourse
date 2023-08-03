using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long fieldSize = int.Parse(Console.ReadLine());

            int[] ladyBugs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            long[] field = new long[fieldSize];
            for (int i = 0; i < ladyBugs.Length; i++)
            {
                int currentIndex = ladyBugs[i];
                if (currentIndex >= 0 && currentIndex < field.Length)
                {
                    field[currentIndex] = 1;
                }
            }


            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                int ladybugIndex = int.Parse(arguments[0]);
                string direction = arguments[1];
                int flyLength = int.Parse(arguments[2]);

                if (ladybugIndex < 0 || ladybugIndex > field.Length - 1)
                {
                    continue;
                }

                if (field[ladybugIndex] == 0)
                {
                    continue;
                }

                field[ladybugIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = ladybugIndex + flyLength;

                    if (landIndex > field.Length - 1 || landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLength;
                            if (landIndex > field.Length - 1 || landIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex <= field.Length - 1 && landIndex >= 0)
                    {
                        field[landIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = ladybugIndex - flyLength;

                    if (landIndex < 0 || landIndex > field.Length - 1)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0 || landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(' ', field));
        }
    }
}