using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfHoliday = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            //
            double toysPrice = puzzles * 2.60 + dolls * 3.00 + bears * 4.10 + minions * 8.20 + trucks * 2.00;
            int countToys = puzzles + dolls + bears + minions + trucks;
            if (countToys >= 50)
            {
                toysPrice = toysPrice - toysPrice * 0.25;
            }
            // 10% for rent
            toysPrice = toysPrice * 0.9;
            // check if profit is enough
            if (toysPrice >= priceOfHoliday)
            {
                double moneyleft = toysPrice - priceOfHoliday;
                Console.WriteLine($"Yes! {moneyleft:f2} lv left.");
            }
            else
            {
                double neededMoney = priceOfHoliday - toysPrice;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
            }
        }
    }
}
