using System;

namespace _13.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int solvent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double bags = 0.40;
            //calculate
            double paintCost = 1.1 * paint * 14.50;
            double nylonCost = (nylon + 2) * 1.50;
            double solventCost = solvent * 5.00;
            double sumCost = paintCost + nylonCost + solventCost + bags;
            double hourCost = sumCost * 30 / 100.0 * hours;
            //calculate the whole sum with working hours
            double sumCoastWithWorkHours = sumCost + hourCost;
            //print
            Console.WriteLine(sumCoastWithWorkHours);
        }
    }
}
