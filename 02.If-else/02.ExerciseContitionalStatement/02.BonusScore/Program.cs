using System;

namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int points = int.Parse(Console.ReadLine());
            //calculate first bonus points
            double bonus = 0;
            if (points <= 100)
            {
                bonus = 5;
            }
            else if (points <=1000)
            {
                bonus = points * 0.2;
            }
            else
            {
                bonus = points * 0.1;
            }
            //calculate second bonus pints
            if (points % 2 == 0)
            {
                bonus = bonus + 1;
            }
            if (points % 10 == 5)
            {
                bonus = bonus + 2;
            }
            //print
            Console.WriteLine(bonus);
            Console.WriteLine(points + bonus);
        }
    }
}
