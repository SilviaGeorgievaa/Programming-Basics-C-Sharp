using System;

namespace _07.GreeenYard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Please, write the area in square meters:");
            double squareMeters = double.Parse(Console.ReadLine());
            double priceForSquareM = 7.61;
            double discount = 18 / 100.0;
            //calculation
            double finalPriceForSquareM = squareMeters * priceForSquareM;
            double theDiscount = discount * finalPriceForSquareM;
            double finPriceWithDiscount = finalPriceForSquareM - theDiscount;
            //print
            Console.WriteLine($"The final price is: {finPriceWithDiscount} lv.");
            Console.WriteLine($"The discount is: {theDiscount}");
        }
    }
}
