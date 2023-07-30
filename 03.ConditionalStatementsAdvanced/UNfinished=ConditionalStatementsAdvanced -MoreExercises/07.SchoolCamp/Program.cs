using System;

namespace _07.SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string sport = "";
            double price = 0;
            
            if (season == "Winter")
            {
                if (group == "girls")
                {
                    sport = "Gymnastics";
                    price = studentsCount * 9.60 * nights;
                }
                else if (group == "boys")
                {
                    sport = "Judo";
                    price = studentsCount * 9.60 * nights;
                }
                else
                {
                    sport = "Ski";
                    price = studentsCount * 10 * nights;
                }

            }
            else if (season == "Spring")
            {
                if (group == "girls")
                {
                    sport = "Athletics";
                    price = studentsCount * 7.20 * nights;
                }
                else if (group == "boys")
                {
                    sport = "Tennis";
                    price = studentsCount * 7.20 * nights;
                }
                else
                {
                    sport = "Cycling";
                    price = studentsCount * 9.50 * nights;
                }
            }
            else if (season == "Summer")
            {
                if (group == "girls")
                {
                    sport = "Volleyball";
                    price = studentsCount * 15 * nights;
                }
                else if (group == "boys")
                {
                    sport = "Football";
                    price = studentsCount * 15 * nights;
                }
                else
                {
                    sport = "Swimming";
                    price = studentsCount * 20 * nights;
                }
            }
            if (studentsCount >= 10 && studentsCount < 20)
            {
                price = price * 0.95;
            }
            else if (studentsCount >= 20 && studentsCount < 50)
            {
                price = price * 0.85;
            }
            else if (studentsCount >= 50)
            {
                price = price * 0.5;
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
