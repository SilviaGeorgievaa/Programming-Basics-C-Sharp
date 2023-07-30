using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            double price = 0;
            if (season == "Spring")
            {
                
                if (fishers <= 6)
                {
                    price = 3000 * 0.9;
                }
                else if (fishers > 7 && fishers <= 11)
                {
                    price = 3000 * 0.85;
                }
                else
                {
                    price = 3000 * 0.75;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                if (fishers <= 6)
                {
                    price = 4200 * 0.9;
                }
                else if (fishers > 7 && fishers <= 11)
                {
                    price = 4200 * 0.85;
                }
                else
                {
                    price = 4200 * 0.75;
                }
            }
            else if (season == "Winter")
            {
                price = 2600 * 0.75;
                if (fishers <= 6)
                {
                    price = 2600 * 0.9;
                }
                else if (fishers > 7 && fishers <= 11)
                {
                    price = 2600 * 0.85;
                }
                else
                {
                    price = 2600 * 0.75;
                }
            }
            if (fishers % 2 == 0 && season != "Autumn")
            {
                price = price * 0.95;
            }
            double sumMoney = Math.Abs(budget - price);
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {sumMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {sumMoney:f2} leva.");
            }
        }
    }
}
