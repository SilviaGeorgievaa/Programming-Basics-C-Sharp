using System;

namespace _02.AddBags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOver20kg = double.Parse(Console.ReadLine());
            double kgLuggage = double.Parse(Console.ReadLine());
            int daysTillJourney = int.Parse(Console.ReadLine());
            int countLuggage = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (kgLuggage < 10)
            {
                totalPrice = priceOver20kg * 0.2;
            }
            else if (kgLuggage >= 10 && kgLuggage <= 20)
            {
                totalPrice = priceOver20kg * 0.5;
            }
            else if (kgLuggage > 20)
            {
                totalPrice = priceOver20kg;
            }
            if (daysTillJourney > 30)
            {
                totalPrice = totalPrice * 1.1;
            }
            else if (daysTillJourney >= 7 && daysTillJourney <= 30)
            {
                totalPrice = totalPrice * 1.15;
            }
            else if (daysTillJourney < 7)
            {
                totalPrice = totalPrice * 1.4;
            }
            double priceforBags = totalPrice * countLuggage;
            Console.WriteLine($"The total price of bags is: {priceforBags:f2} lv.");
        }
    }
}
