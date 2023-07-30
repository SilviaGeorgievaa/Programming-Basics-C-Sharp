using System;
using System.Threading;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;
            if (month == "May" || month == "October")
            {
                if (nights <= 7)
                {
                    priceStudio = 50 * nights;
                    priceApartment = 65 * nights;
                }
                else if (nights > 7 && nights <= 14)
                {
                    priceStudio = 50 * nights * 0.95;
                    priceApartment = 65 * nights;
                }
                else if (nights > 14)
                {
                    priceStudio = 50 * nights * 0.7;
                    priceApartment = 65 * nights * 0.9;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights <= 14)
                {
                    priceStudio = 75.20 * nights;
                    priceApartment = 68.70 * nights;
                }
                else if (nights > 14)
                {
                    priceStudio = 75.20 * nights * 0.8;
                    priceApartment = 68.70 * nights * 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights <= 14)
                {
                    priceStudio = 76 * nights;
                    priceApartment = 77 * nights;
                }
                else if (nights > 14)
                {
                    priceStudio = 76 * nights;
                    priceApartment = 77 * nights * 0.9;
                }
            }
            Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
