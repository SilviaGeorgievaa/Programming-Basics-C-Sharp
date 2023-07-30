using System;

namespace _05.CinemaStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "ACTION")
                {
                    break;
                }
                int count = name.Length;
                if (count <= 15)
                {
                    double price = double.Parse(Console.ReadLine());
                    budget -= price;
                }
                else
                {
                    budget -= budget * 0.2;
                }
                if (budget < 0)
                {
                    break;
                }
            }
           
            if (budget < 0)
            {
                Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
            }
            else
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }

        }
    }
}
