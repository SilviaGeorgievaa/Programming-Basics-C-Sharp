using System;

namespace _04.TwoToyPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            //calculation 
            double totalPrice = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
            int countOfToys = puzzles + dolls + bears + minions + trucks;
            // discount 25%
            if (countOfToys >= 50)
            {
                totalPrice = totalPrice - 0.25 * totalPrice;
            }
            // rent 10%
            double totalPriceWithdisc = totalPrice - 0.1 * totalPrice;
            //
            if (totalPriceWithdisc >= tripPrice)
            {
                double moneyleft = totalPriceWithdisc - tripPrice;
                Console.WriteLine($"Yes! {moneyleft:f2} lv left.");
            }
            else
            {
                double moneyneeded = tripPrice - totalPriceWithdisc;
                Console.WriteLine($"Not enough money! {moneyneeded:f2} lv needed.");
            }
        }
    }
}
