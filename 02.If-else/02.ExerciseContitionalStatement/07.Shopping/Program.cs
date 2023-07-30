using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budjetIvan = double.Parse(Console.ReadLine());
            int numVideocards = int.Parse(Console.ReadLine());
            int numProcessors = int.Parse(Console.ReadLine());
            int numRamMemory = int.Parse(Console.ReadLine());
            int priceOfVideocard = 250;
            //calculation
            int costOfVideocards = numVideocards * priceOfVideocard;
            double priceOfTheProcessors = costOfVideocards * 0.35;
            double priceOfRamMemory = costOfVideocards * 0.1;
            double costOfProcessors = numProcessors * priceOfTheProcessors;
            double costOfRamMemory = numRamMemory * priceOfRamMemory;
            double sum = costOfVideocards + costOfRamMemory + costOfProcessors;
            //if
            if (numVideocards > numProcessors)
            {
                sum = sum - sum * 0.15;
            }
            if (budjetIvan >= sum)
            {
                double moneyLeft = budjetIvan - sum;
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
            else
            {
                double moneyNeeded = Math.Abs(budjetIvan - sum);
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva more!");
            }
        }
    }
}
