using System;

namespace _08.ConvertUSDintoBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Please, write the amount of money in BGN:");
            double bgn = double.Parse(Console.ReadLine());
            double usd = 1.79549;
            //calculate
            double bgnIntoUsd = bgn * usd;
            //print
            Console.WriteLine($"The result is: {bgnIntoUsd} USD.");
        }
    }
}
