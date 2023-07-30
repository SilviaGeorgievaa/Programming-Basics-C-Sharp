using System;

namespace _14.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veggie = int.Parse(Console.ReadLine());
            double delivery = 2.50;
            //calculation 
            double wholeMenu = chicken * 10.35 + fish * 12.40 + veggie * 8.15;
            double dessert = wholeMenu * 20 / 100.0;
            //calculate 
            double withDessertMenuAndDel = wholeMenu + dessert + delivery;
            //print
            Console.WriteLine(withDessertMenuAndDel);
        }
    }
}
