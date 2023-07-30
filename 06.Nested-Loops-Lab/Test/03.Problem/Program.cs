using System;

namespace _03.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string sortOfRoom = Console.ReadLine();
            string grade = Console.ReadLine();

            double priseRoomForPerNIght = 18.00;
            double priceApartmentnight = 25.00;
            double pricePresidentNight = 35.00;
            int nights = days - 1;
            double roomPrice = 0;
            if (sortOfRoom == "room for one person")
            {
                if (days < 10)
                {
                    roomPrice = nights * priseRoomForPerNIght;
                }
                else if (days >= 10 && days <= 15)
                {
                    roomPrice = nights * priseRoomForPerNIght;
                }
                else
                {
                    roomPrice = nights * priseRoomForPerNIght;
                }
            }
            else if (sortOfRoom == "apartment")
            {
                if (days < 10)
                {
                    roomPrice = nights * priceApartmentnight * 0.7;
                }
                else if (days >= 10 && days <= 15)
                {
                    roomPrice = nights * priceApartmentnight * 0.65;
                }
                else
                {
                    roomPrice = nights * priceApartmentnight * 0.5;
                }
            }
            else if (sortOfRoom == "president apartment")
            {
                if (days < 10)
                {
                    roomPrice = nights * pricePresidentNight * 0.9;
                }
                else if (days >= 10 && days <= 15)
                {
                    roomPrice = nights * pricePresidentNight * 0.85;
                }
                else
                {
                    roomPrice = nights * pricePresidentNight * 0.8;
                }
            }
            if (grade == "positive")
            {
                roomPrice *= 1.25;
            }
            else if (grade == "negative")
            {
                roomPrice *= 0.9;
            }
            Console.WriteLine($"{roomPrice:f2}");
        }
    }
}
