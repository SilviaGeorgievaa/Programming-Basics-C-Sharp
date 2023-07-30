using System;

namespace _03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vineyardX = int.Parse(Console.ReadLine());
            double grapeOneSqmY = double.Parse(Console.ReadLine());
            int neededLitersForWine = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            //
            double harvestForAllVineyard = vineyardX * grapeOneSqmY;
            double harvestForWine = harvestForAllVineyard * 0.4;
            double doneLitersForWine = harvestForWine / 2.5;
            //if
            if (doneLitersForWine < neededLitersForWine)
            {
                double shortage = Math.Abs(doneLitersForWine - neededLitersForWine);
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(shortage)} liters wine needed.");
            }
            else
            {
                double excess = Math.Ceiling(doneLitersForWine - neededLitersForWine);
                double winePerPerson = Math.Ceiling(excess / countWorkers);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(doneLitersForWine)} liters.");
                Console.WriteLine($"{excess} liters left -> {winePerPerson} liters per person.");

            }
        } 
    }
}
