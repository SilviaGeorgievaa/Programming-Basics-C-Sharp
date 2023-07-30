using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read all input
            int plastic = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int solvent = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());

            //calculate material costs (nylon + 2 square meters, paint + 10%, solvent, bags)
            double plasticCost = (plastic + 2) * 1.50;
            double paintCost = 1.1 * paint * 14.5;
            double solventCost = solvent * 5;
            double materialCost = plasticCost + paintCost + solventCost + 0.4;

            //calculate wage ( 30% from total expenses)
            double wageCost = materialCost * 30/100.0;
            double finalWageCost = wageCost * hoursWork;

            //calculate the final price (total expenses + wage)
            double finaleCosts = materialCost + finalWageCost;
            //print
            Console.WriteLine(finaleCosts);
        }
    }
}
