using System;

namespace _06.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceProcessorDollars = double.Parse(Console.ReadLine());
            double priceVideoCardDollars = double.Parse(Console.ReadLine());
            double priceRAMdollars = double.Parse(Console.ReadLine());
            int countRAM = int.Parse(Console.ReadLine());
            double discountPer = double.Parse(Console.ReadLine());

            double discountProc = priceProcessorDollars * discountPer;
            double priceProcessDISC = priceProcessorDollars - discountProc;
            double discVidCard = priceVideoCardDollars * discountPer;
            double priceVideo = priceVideoCardDollars - discVidCard;

            double allDollars = priceProcessDISC + priceVideo + priceRAMdollars * countRAM;
            double priceLeva = allDollars * 1.57;

            
            Console.WriteLine($"Money needed - {priceLeva:f2} leva.");

        }
    }
}
