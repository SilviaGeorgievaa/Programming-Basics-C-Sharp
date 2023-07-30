using System;

namespace _10.test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorsName = Console.ReadLine();
            double academiaPoints = double.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            double allPoints = 0;
            for (int i = 1; i <= num; i++)
            {
                string name = Console.ReadLine();
                int lenght = name.Length;
                double points = double.Parse(Console.ReadLine());

                allPoints += academiaPoints + (lenght * points) / 2;
            }
            
            if (allPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {allPoints}!");
            }
            else
            {
                double needed = Math.Abs(allPoints - 1250.5);
                Console.WriteLine($"Sorry, {actorsName} you need {needed:f1} more!");
            }
        }
    }
}
