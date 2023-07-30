using System;

namespace _04.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            double allLitRakia = 0;
            double allDegrees = 0;
            for (int i = 0; i < countDays; i++)
            {
                double rakia = double.Parse(Console.ReadLine());
                double degreesRakia = double.Parse(Console.ReadLine());
                double rakiaForTheDay = 0;
                double degreesForTheDay = 0;

                rakiaForTheDay += rakia;
                degreesForTheDay += rakia * degreesRakia;

                allLitRakia += rakiaForTheDay;
                allDegrees += degreesForTheDay;

            }
            double deg = allDegrees / allLitRakia;
            if (deg < 38)
            {
                Console.WriteLine($"Liter: {allLitRakia:f2}");
                Console.WriteLine($"Degrees: {deg:f2}");
                Console.WriteLine("Not good, you should baking!");
            }
            else if (deg >= 38 && deg <= 42)
            {
                Console.WriteLine($"Liter: {allLitRakia:f2}");
                Console.WriteLine($"Degrees: {deg:f2}");
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine($"Liter: {allLitRakia:f2}");
                Console.WriteLine($"Degrees: {deg:f2}");
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
