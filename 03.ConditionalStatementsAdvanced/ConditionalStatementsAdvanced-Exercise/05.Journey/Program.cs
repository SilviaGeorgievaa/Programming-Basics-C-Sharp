using System;
using System.Text;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double oneBudget = 0;
            string destination = "";
            string place = "";
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    oneBudget = budget * 0.3;
                }
                else 
                {
                    place = "Hotel";
                    oneBudget = budget * 0.7;
                }    
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    oneBudget = budget * 0.4;
                }
                else
                {
                    place = "Hotel";
                    oneBudget = budget * 0.8;
                }
            }
            else
            {
                destination = "Europe";
                if (season == "summer" || season == "winter")
                {
                    place = "Hotel";
                    oneBudget = budget * 0.9;
                }
                
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {oneBudget:f2}");
        }
    }
}
