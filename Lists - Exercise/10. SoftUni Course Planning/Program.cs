/*
Arrays, Lists, Methods
Swap:Arrays:Methods
Exercise:Databases
Swap:Lists:Databases
Insert:Arrays:0
course start
 */

using Microsoft.Win32.SafeHandles;
using System.Reflection.Metadata.Ecma335;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] commands = input.Split(":");
                string lessonTitle = commands[1];

                switch (commands[0])
                {
                    case "Add":
                        schedule = AddLesson(schedule, lessonTitle);
                        break;
                    case "Insert":
                        int index = int.Parse(commands[2]);
                        schedule = InsertLessonAtIndex(schedule, lessonTitle, index);
                        break;
                    case "Remove":
                        schedule = RemoveLesson(schedule, lessonTitle);
                        break;
                    case "Swap":
                        string lessonToSwap = commands[2];
                        schedule = SwapLessons(schedule, lessonTitle, lessonToSwap);
                        break;
                    case "Exercise":
                        schedule = AddExercise(schedule, lessonTitle);
                        break;
                }
            }

            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }

        static List<string> AddExercise(List<string> schedule, string lessonTitle)
        {
            string exerciseTitle = $"{lessonTitle}-Exercise";
            if (!schedule.Contains(lessonTitle))
            {
                AddLesson(schedule, lessonTitle);
            }

            if (schedule.Contains(lessonTitle) && !schedule.Contains(exerciseTitle))
            {
                int index = schedule.FindIndex(x => x == lessonTitle);
                InsertLessonAtIndex(schedule, exerciseTitle, index + 1);
            }

            return schedule;
        }

        static List<string> SwapLessons(List<string> schedule, string lessonTitle, string lessonToSwap)
        {
            if (schedule.Contains(lessonTitle) && schedule.Contains(lessonToSwap))
            {
                int firstIndex = schedule.FindIndex(x => x == lessonTitle);
                int secondIndex = schedule.FindIndex(x => x == lessonToSwap);

                string temp = schedule[firstIndex];
                schedule[firstIndex] = schedule[secondIndex];
                schedule[secondIndex] = temp;

                schedule = SwapExercise(schedule, lessonTitle, secondIndex);
                schedule = SwapExercise(schedule, lessonToSwap, firstIndex);
            }

            return schedule;

            return schedule;
        }

        private static List<string> SwapExercise(List<string> schedule, string lesson, int lessonIndex)
        {
            string exerciseTitle = $"{lesson}-Exercise";
            int index = schedule.FindIndex(x => x == exerciseTitle);
            if (index >= 0)
            {
                RemoveLesson(schedule, exerciseTitle);
                InsertLessonAtIndex(schedule, exerciseTitle, lessonIndex + 1);
            }

            return schedule;
        }

        static List<string> InsertLessonAtIndex(List<string> schedule, string lessonTitle, int index)
        {
            if (!schedule.Contains(lessonTitle))
            {
                schedule.Insert(index, lessonTitle);
            }

            return schedule;
        }

        static List<string> RemoveLesson(List<string> schedule, string lessonTitle)
        {
            schedule.Remove(lessonTitle);

            string exerciseTitle = $"{lessonTitle}-Exercise";
            int index = schedule.FindIndex(x => x == exerciseTitle);
            if (index >= 0)
            {
                RemoveLesson(schedule, exerciseTitle);
            }

            return schedule;
        }

        static List<string> AddLesson(List<string> schedule, string lessonTitle)
        {
            if (!schedule.Contains(lessonTitle))
            {
                schedule.Add(lessonTitle);
            }

            return schedule;
        }
    }
}