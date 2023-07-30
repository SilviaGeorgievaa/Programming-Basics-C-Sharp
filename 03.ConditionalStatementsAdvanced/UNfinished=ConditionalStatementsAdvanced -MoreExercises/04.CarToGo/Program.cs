using System;

namespace _04.CarToGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string type = "";
            string clas = "";
            if (budget <= 100)
            {
                clas = "Economy class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    price = budget * 0.35;
                }
                else 
                {
                    type = "Jeep";
                    price = budget * 0.65;
                } 
            }
            else if (budget > 100 && budget <= 500)
            {
                clas = "Compact class";
                if (season == "Summer")
                {
                    type = "Cabrio";
                    price = budget * 0.45;
                }
                else
                {
                    type = "Jeep";
                    price = budget * 0.8;
                }
            }
            else
            {
                clas = "Luxury class";
                type = "Jeep";
                price = budget * 0.9;
            }
            Console.WriteLine($"{clas}");
            Console.WriteLine($"{type} - {price:f2}");

        }
    }
}
