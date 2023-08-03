using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double totalMoney = 0;

            while ((input = Console.ReadLine()) != "Start")
            {
                double coin = double.Parse(input);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    totalMoney += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
            }

            string productName;

            while ((productName = Console.ReadLine()) != "End")
            {
                if (productName == "Nuts")
                {
                    if (totalMoney >= 2.0)
                    {
                        Console.WriteLine($"Purchased {productName.ToLower()}");
                        totalMoney -= 2.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (productName == "Water")
                {
                    if (totalMoney >= 0.7)
                    {
                        Console.WriteLine($"Purchased {productName.ToLower()}");
                        totalMoney -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (productName == "Crisps")
                {
                    if (totalMoney >= 1.5)
                    {
                        Console.WriteLine($"Purchased {productName.ToLower()}");
                        totalMoney -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (productName == "Soda")
                {
                    if (totalMoney >= 0.8)
                    {
                        Console.WriteLine($"Purchased {productName.ToLower()}");
                        totalMoney -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (productName == "Coke")
                {
                    if (totalMoney >= 1.0)
                    {
                        Console.WriteLine($"Purchased {productName.ToLower()}");
                        totalMoney -= 1.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }

            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}