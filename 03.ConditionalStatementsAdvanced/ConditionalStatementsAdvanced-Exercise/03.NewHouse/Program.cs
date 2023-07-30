using System;
using System.Runtime.InteropServices;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            if (flowers == "Roses")
            {
                if (count > 80)
                {
                    price = count * 5 - (count * 5 * 0.1);
                }
                else
                {
                    price = count * 5;
                }
            }
            else if (flowers == "Dahlias")
            {
                if (count > 90)
                {
                    price = count * 3.80 - (count * 3.80 * 0.15);
                }
                else
                {
                    price = count * 3.80;
                }
            }
            else if (flowers == "Tulips")
            {
                if (count > 80)
                {
                    price = count * 2.80 - (count * 2.80 * 0.15);
                }
                else
                {
                    price = count * 2.80;
                }
            }
            else if (flowers == "Narcissus")
            {
                if (count < 120)
                {
                    price = count * 3 + (count * 3 * 0.15);
                }
                else
                {
                    price = count * 3;
                }
            }
            else if (flowers == "Gladiolus")
            {
                if (count < 80)
                {
                    price = count * 2.50 + (count * 2.50 * 0.20);
                }
                else
                {
                    price = count * 2.50;
                }
            }
            if (budget >= price)
            {
                double sumleft = budget - price;
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {sumleft:f2} leva left.");
            }
            else
            {
                double sumNeeded = price - budget;
                Console.WriteLine($"Not enough money, you need {sumNeeded:f2} leva more.");
            }
        }
    }
}
