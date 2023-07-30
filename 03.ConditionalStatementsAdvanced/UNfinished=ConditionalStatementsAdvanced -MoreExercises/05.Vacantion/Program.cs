using System;
using System.Diagnostics;

namespace _05.Vacantion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string accomod = "";
            string location = "";

            if (budget <= 1000)
            {
                accomod = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                accomod = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else
                {
                    location = "Morocco";
                    price = budget * 0.6;
                }
            }
            else
            {
                accomod = "Hotel";
                price = budget * 0.9;
                if (season == "Summer")
                {
                    location = "Alaska";
                }
                else
                {
                    location = "Morocco";
                }
            }
            Console.WriteLine($"{location} - {accomod} - {price:f2}");
        }
    }
}
