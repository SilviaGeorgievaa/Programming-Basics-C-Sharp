using System;

namespace _03.oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            string hallKind = Console.ReadLine();   
            int soldTicketsCount = int.Parse(Console.ReadLine());
            double price = 0;

            if (filmName == "A Star Is Born")
            {
                if (hallKind == "normal")
                {
                    price = 7.50;
                }
                else if (hallKind == "luxury")
                {
                    price = 10.50;
                }
                else
                {
                    price = 13.50;
                }
            }
            else if (filmName == "Bohemian Rhapsody")
            {
                if (hallKind == "normal")
                {
                    price = 7.35;
                }
                else if (hallKind == "luxury")
                {
                    price = 9.45;
                }
                else
                {
                    price = 12.75;
                }
            }
            else if (filmName == "Green Book")
            {
                if (hallKind == "normal")
                {
                    price = 8.15;
                }
                else if (hallKind == "luxury")
                {
                    price = 10.25;
                }
                else
                {
                    price = 13.25;
                }
            }
            else if (filmName == "The Favourite")
            {
                if (hallKind == "normal")
                {
                    price = 8.75;
                }
                else if (hallKind == "luxury")
                {
                    price = 11.55;
                }
                else
                {
                    price = 13.95;
                }
            }
            double income = price * soldTicketsCount;
            Console.WriteLine($"{filmName} -> {income:f2} lv.");
        }
    }
}
