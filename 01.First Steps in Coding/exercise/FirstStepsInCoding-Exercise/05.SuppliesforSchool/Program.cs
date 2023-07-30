using System;

namespace _05.SuppliesforSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int litCleaning = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pricePens = pen * 5.80;
            double priceMarkers = marker * 7.20;
            double priceLitCleaning = litCleaning * 1.20;

            double moneysum = pricePens + priceMarkers + priceLitCleaning;
            double moneysumdiscount = moneysum * (discount * 0.01);
            double finalprice = moneysum - moneysumdiscount;
            Console.WriteLine(finalprice);
        }
    }
}
