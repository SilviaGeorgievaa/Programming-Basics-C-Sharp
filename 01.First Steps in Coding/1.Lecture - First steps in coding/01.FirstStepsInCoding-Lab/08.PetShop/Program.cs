using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodDogs = int.Parse(Console.ReadLine());
            double priceDogs = foodDogs * 2.50;


            int foodCats = int.Parse(Console.ReadLine());
            int priceCats = foodCats * 4;


            double finalSum = priceDogs + priceCats;
            Console.WriteLine($"{finalSum} lv.");
        }
    }
}
