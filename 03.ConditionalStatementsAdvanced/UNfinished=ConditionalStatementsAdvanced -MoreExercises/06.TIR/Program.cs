using System;

namespace _06.TIR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            double money = 0;
            if (kmPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    money = kmPerMonth * 0.75;
                }
                else if (season == "Summer")
                {
                    money = kmPerMonth * 0.90;
                }
                else 
                {
                    money = kmPerMonth * 1.05;
                }
            }
            else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    money = kmPerMonth * 0.95;
                }
                else if (season == "Summer")
                {
                    money = kmPerMonth * 1.10;
                }
                else
                {
                    money = kmPerMonth * 1.25;
                }
            }
            else if (kmPerMonth > 10000 && kmPerMonth<= 20000)
            {
                money = kmPerMonth * 1.45;
            }
            double salary = money * 4 * 0.9;
            Console.WriteLine($"{salary:f2}");
        }
    }
}
