using System;

namespace _05.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goalForADay = int.Parse(Console.ReadLine());
            int income = 0;
            
            while (true)
            {
                string service = Console.ReadLine();
                if (service == "closed")
                {
                    break;
                }
                if (service == "haircut")
                {
                    service = Console.ReadLine();
                    if (service == "mens")
                    {
                        income += 15;
                    }
                    else if (service == "ladies")
                    {
                        income += 20;
                    }
                    else if (service == "kids")
                    {
                        income += 10;
                    }
                }
                if (service == "color")
                {
                    service = Console.ReadLine();
                    if (service == "touch up")
                    {
                        income += 20;
                    }
                    else if (service == "full color")
                    {
                        income += 30;
                    }

                }
                if (income >= goalForADay)
                {
                    break;
                }
                
            }
            if (income >= goalForADay)
            {
                Console.WriteLine("You have reached your target for the day!");
                Console.WriteLine($"Earned money: {income}lv.");
            }
            else
            {
                int need = goalForADay - income;
                Console.WriteLine($"Target not reached! You need {need}lv. more.");
                Console.WriteLine($"Earned money: {income}lv.");
            }
        }
    }
}
