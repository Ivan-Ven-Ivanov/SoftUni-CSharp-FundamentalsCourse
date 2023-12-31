﻿namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double pricePerPerson = 0;
            double totalPrice = 0;

            switch (groupType)
            {
                case "Students":

                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 8.45;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46;
                            break;
                    }

                    totalPrice = peopleCount * pricePerPerson;

                    if (peopleCount >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Business":

                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 10.90;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60;
                            break;
                        case "Sunday":
                            pricePerPerson = 16;
                            break;
                    }

                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                    }

                    totalPrice = peopleCount * pricePerPerson;
                    break;
                case "Regular":

                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 15;
                            break;
                        case "Saturday":
                            pricePerPerson = 20;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50;
                            break;
                    }

                    totalPrice = peopleCount * pricePerPerson;

                    if(peopleCount >= 10 && peopleCount <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;

            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}