using System;

namespace _01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string cat = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());
            double moneyTicketsandTransport = 0;

            
            if (peopleCount >= 1 && peopleCount <= 4)
            {
                if (cat == "Normal")
                {
                    moneyTicketsandTransport = peopleCount * 249.99 + budget * 0.75;
                }
                else
                {
                    moneyTicketsandTransport = peopleCount * 499.99 + budget * 0.75;
                }
            }
            else if (peopleCount > 4 && peopleCount <= 9)
            {
                if (cat == "Normal")
                {
                    moneyTicketsandTransport = peopleCount * 249.99 + budget * 0.6;
                }
                else
                {
                    moneyTicketsandTransport = peopleCount * 499.99 + budget * 0.6;
                }
            }
            else if (peopleCount > 9 && peopleCount <= 24)
            {
                if (cat == "Normal")
                {
                    moneyTicketsandTransport = peopleCount * 249.99 + budget * 0.5;
                }
                else
                {
                    moneyTicketsandTransport = peopleCount * 499.99 + budget * 0.5;
                }
            }
            else if (peopleCount > 25 && peopleCount <= 49)
            {
                if (cat == "Normal")
                {
                    moneyTicketsandTransport = peopleCount * 249.99 + budget * 0.4;
                }
                else
                {
                    moneyTicketsandTransport = peopleCount * 499.99 + budget * 0.4;
                }
            }
            else if (peopleCount > 50)
            {
                if (cat == "Normal")
                {
                    moneyTicketsandTransport = peopleCount * 249.99 + budget * 0.25;
                }
                else
                {
                    moneyTicketsandTransport = peopleCount * 499.99 + budget * 0.25;
                }
            }
            double sum = 0;
            if (budget >= moneyTicketsandTransport)
            {
                sum = budget - moneyTicketsandTransport;
                Console.WriteLine($"Yes! You have {sum:f2} leva left.");
            }
            else if (budget < moneyTicketsandTransport)
            {
                sum = Math.Abs(budget - moneyTicketsandTransport);
                Console.WriteLine($"Not enough money! You need {sum:f2} leva.");
            }
            
        }
    }
}
