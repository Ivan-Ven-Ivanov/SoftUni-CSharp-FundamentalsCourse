using System.Collections.Concurrent;
using System.Collections.Generic;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] arguments = command.Split();

                switch (arguments[0])
                {
                    case "merge":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        names = MergeIndexes(names, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(arguments[1]);
                        int partitions = int.Parse(arguments[2]);
                        names = DivideElementIntoPartitions(names, index, partitions);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }

        static List<string> DivideElementIntoPartitions(List<string> names, int index, int partitions)
        {
            /* if (index < 0 || index >= names.Count)
             {
                 return names;
             }
             if (partitions <= 0)
             {
                 return names;
             }

             if (partitions > names[index].Length)
             {
                 partitions = names[index].Length;
             }

             int length = names[index].Length;
             int symbolsInPartition = length / partitions;
             string temp = names[index];
             names.RemoveAt(index);
             int originalIndex = index;

             if (length % partitions == 0)
             {
                 for (int i = 0; i < length; i += symbolsInPartition)
                 {
                     names.Insert(index++, temp.Substring(i, symbolsInPartition));
                 }
             }
             else
             {
                 for (int i = 0; i < length - 1; i += symbolsInPartition)
                 {
                     names.Insert(index++, temp.Substring(i, symbolsInPartition));
                 }
                 names[names.Count - length % partitions] += temp.Substring(length - (length % partitions), length % partitions);
             }

             return names;
            */

            string element = names[index];

            if (partitions <= 0)
            {
                return names;
            }

            names.RemoveRange(index, 1);
            int subLength = element.Length / partitions;
            int remainingChars = element.Length % partitions;

            List<string> newElements = new List<string>();

            int elementIndex = 0;
            for (int i = 0; i < partitions; i++)
            {
                string newString = "";
                for (int j = 0; j < subLength; j++)
                {
                    newString += element[elementIndex];
                    elementIndex++;
                }

                newElements.Add(newString);
            }

            if (remainingChars > 0 && newElements.Count > 0)
            {
                for (int i = elementIndex; i < element.Length; i++)
                {
                    newElements[newElements.Count - 1] += element[i];
                }
            }

            names.InsertRange(index, newElements);

            return names;
        }

        static List<string> MergeIndexes(List<string> names, int startIndex, int endIndex)
        {
            if (startIndex > names.Count - 1 || endIndex < 0)
            {
                return names;
            }

            startIndex = Math.Max(0, startIndex);
            endIndex = Math.Min(endIndex, names.Count - 1);
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                names[startIndex] += names[i];
            }

            names.RemoveRange(startIndex + 1, endIndex - startIndex);
            return names;
        }
    }
}