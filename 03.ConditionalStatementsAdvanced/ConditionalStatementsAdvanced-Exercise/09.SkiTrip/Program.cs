using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string place = Console.ReadLine();
            string rating = Console.ReadLine();

            int nights = days - 1;
            double cost = 0;
            if (days < 10)
            {
                if (place == "room for one person")
                {
                    cost = nights * 18;
                }
                else if (place == "apartment")
                {
                    cost = nights * 25 * 0.7;
                }
                else if (place == "president apartment")
                {
                    cost = nights * 35 * 0.9;
                }
            }
            else if (days >= 10 && days <= 15)
            {
                if (place == "room for one person")
                {
                    cost = nights * 18;
                }
                else if (place == "apartment")
                {
                    cost = nights * 25 * 0.65;
                }
                else if (place == "president apartment")
                {
                    cost = nights * 35 * 0.85;
                }
            }
            else
            {
                if (place == "room for one person")
                {
                    cost = nights * 18;
                }
                else if (place == "apartment")
                {
                    cost = nights * 25 * 0.5;
                }
                else if (place == "president apartment")
                {
                    cost = nights * 35 * 0.8;
                }
            }

            double ratingCost = 0;
            if (rating == "positive")
            {
                ratingCost = cost * 1.25;
            }
            else
            {
                ratingCost = cost * 0.9;
            }
            Console.WriteLine($"{ratingCost:f2}");
        }
        
    }
}
