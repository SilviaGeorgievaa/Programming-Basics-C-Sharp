using System;

namespace _06.FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());
            //
            double totalPrice = magnolii * 3.25 + zumbuli * 4 + roses * 3.50 + cactus * 8;
            double totalPriceWithoutTax = totalPrice - (totalPrice * 0.05);
            //
            if (totalPriceWithoutTax >= presentPrice)
            {
                double excess = Math.Floor(totalPriceWithoutTax - presentPrice);
                Console.WriteLine($"She is left with {excess} leva.");
            }
            else
            {
                double shortage = Math.Ceiling(presentPrice - totalPriceWithoutTax);
                Console.WriteLine($"She will have to borrow {shortage} leva.");
            }
        }
    }
}
