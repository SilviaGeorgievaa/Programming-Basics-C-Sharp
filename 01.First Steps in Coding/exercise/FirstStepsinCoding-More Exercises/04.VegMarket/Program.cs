using System;

namespace _04.VegMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Write the price of vegetables:");
            double priceVeg = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the price of friuts: ");
            double priceFruits = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the kg of vegetables:");
            int kgVeg = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the kg of fruits:");
            int kgFruits = int.Parse(Console.ReadLine());
            //const
            double euro = 1.94;
            //calculate
            double income = (priceVeg * kgVeg + priceFruits * kgFruits) / euro;
            //print
            Console.WriteLine($"The income is: {income:f2} euro.");
        }
    }
}
