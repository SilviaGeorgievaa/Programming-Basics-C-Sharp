using System;

namespace _08.Tennis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countTours = int.Parse(Console.ReadLine());
            int basicPoints = int.Parse(Console.ReadLine());

            double points = 0;
            int countOfWonTour = 0;
            for (int i = 0; i < countTours; i++)
            {
                string stage = Console.ReadLine();

                if (stage == "W")
                {
                    points += 2000;
                    countOfWonTour++;
                }
                else if (stage == "F")
                {
                    points += 1200;
                }
                else
                {
                    points += 720;
                }
            }
            double finalPoints = basicPoints + points;
           
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(points / countTours)}");
            Console.WriteLine($"{(double)countOfWonTour / countTours * 100:f2}%");
        }
    }
}
