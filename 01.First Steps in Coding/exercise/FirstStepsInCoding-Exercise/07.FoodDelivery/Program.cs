using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write the input
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine()) ;
            int veg = int.Parse(Console.ReadLine()) ;
            // calculate price without dessert
            double priceWithout = chicken * 10.35 + fish * 12.40 + veg * 8.15;
            //calculate the price of dessert
            double priceOfDessert = priceWithout * 20 / 100.0;
            double delivery = 2.50;
            // calculate the final price
            double finalPrice = priceWithout + priceOfDessert + delivery;
            Console.WriteLine(finalPrice);
        }
    }
}
