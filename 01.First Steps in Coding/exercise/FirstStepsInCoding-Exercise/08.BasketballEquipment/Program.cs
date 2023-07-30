using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input
            int taxPerYear =  int.Parse(Console.ReadLine());
            //calculation
            double basketShoes = taxPerYear * 0.6;
            double basketEquipment = basketShoes * 0.8;
            double basketBall = basketEquipment * 25 / 100.0;
            double basketAcessor = basketBall * 20 / 100.0;

            double finalPrice = taxPerYear + basketShoes + basketEquipment + basketBall + basketAcessor;
            Console.WriteLine(finalPrice);
        }
    }
}
