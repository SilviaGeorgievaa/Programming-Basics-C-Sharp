using System;

namespace _06.ZooPetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Please, write the amount of dog food:");
            int dogFood = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, write the ammount of cat food:");
            int catFood = int.Parse(Console.ReadLine());
            double priceDog = 2.50;
            int priceCat = 4;
            //calculate
            double priceFinal = dogFood * priceDog + catFood * priceCat;
            //print
            Console.WriteLine($"The final price is {priceFinal:f2} lv.");
        }
    }
}
