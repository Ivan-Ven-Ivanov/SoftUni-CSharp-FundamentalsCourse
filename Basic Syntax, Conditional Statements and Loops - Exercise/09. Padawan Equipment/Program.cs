using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double ligthsaberPerPerson = double.Parse(Console.ReadLine());
            double robePerPerson = double.Parse(Console.ReadLine());
            double beltPerPerson = double.Parse(Console.ReadLine());

            
            int freeBelts = 0;

            for (int i = 1; i <= studentsCount; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelts++;
                }
            }

            double lightsaberPrice = ligthsaberPerPerson * (Math.Ceiling(studentsCount * 1.1));
            double robePrice = robePerPerson * studentsCount;
            double beltPrice = beltPerPerson * (studentsCount - freeBelts);
            double totalPrice = lightsaberPrice + robePrice + beltPrice;

            if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {(totalPrice - money):F2}lv more.");
            }
        }
    }
}