using System;

namespace _06.FishMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceSkumriq = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMidi = int.Parse(Console.ReadLine());
            double priceMidi = 7.50;
            //calculation palamud
            double pricePalamud = (priceSkumriq * 0.6) + priceSkumriq;
            double kgPricePalamud = pricePalamud * kgPalamud;
            //calc safrid
            double priceSafrid = (priceCaca * 0.8) + priceCaca;
            double kgPriceSafrid = priceSafrid * kgSafrid;
            //calc sum
            double sum = kgPriceSafrid + kgPricePalamud + priceMidi * kgMidi;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
