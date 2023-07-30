using System;

namespace TestPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfTennisRacket = double.Parse(Console.ReadLine());  
            int countOfRackets = int.Parse(Console.ReadLine());
            int countOfSneakers = int.Parse(Console.ReadLine());

            double priceOfSneakers = priceOfTennisRacket * 1 / 6;
            double allSneakersPrice = priceOfSneakers * countOfSneakers;
            double allRachetPrice = priceOfTennisRacket * countOfRackets;
            double bothSneakersAndRacketsPrice = allSneakersPrice + allRachetPrice;
            double priceEquipment = bothSneakersAndRacketsPrice * 0.2;

            double allPrice = bothSneakersAndRacketsPrice + priceEquipment;

            double priceForNovak = allPrice * 1 / 8;
            double priceForSponsors = allPrice * 7 / 8;
            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceForNovak)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceForSponsors)}");
        }
    }
}
