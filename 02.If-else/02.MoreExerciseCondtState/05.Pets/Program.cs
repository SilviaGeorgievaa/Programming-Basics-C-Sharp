using System;

namespace _05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int days = int.Parse(Console.ReadLine());
            int foodLeftKg = int.Parse(Console.ReadLine());
            double dogFoodAdayKg = double.Parse(Console.ReadLine());
            double catFoodAdayKg = double.Parse(Console.ReadLine());
            double turtleFoodAday = double.Parse(Console.ReadLine());
            // grams into kg
            double kgTurtleFoodAday = turtleFoodAday * 0.001;
            // calculate the eaten food
            double eatenFoodKg = dogFoodAdayKg * days + catFoodAdayKg * days + kgTurtleFoodAday * days;
            //if
            if (foodLeftKg >= eatenFoodKg)
            {
                double excess = Math.Floor(foodLeftKg - eatenFoodKg);
                Console.WriteLine($"{excess} kilos of food left.");
            }
            else
            {
                double shortage = Math.Ceiling(eatenFoodKg - foodLeftKg);
                Console.WriteLine($"{shortage} more kilos of food are needed.");
            }
        }
    }
}
