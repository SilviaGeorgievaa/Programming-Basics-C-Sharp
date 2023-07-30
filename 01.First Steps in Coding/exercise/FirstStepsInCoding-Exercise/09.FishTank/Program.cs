using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //write the inpust 
           int lenght = int.Parse(Console.ReadLine());
           int width = int.Parse(Console.ReadLine());
           int height = int.Parse(Console.ReadLine());
           double percentage = double.Parse(Console.ReadLine());
            // formula V=a*b*c converto to dm3
            int formulaV = lenght * width * height;
            double convertFormulaV = formulaV * 0.001;
            // aquariumV
            double aquarioumV = convertFormulaV * (1 - percentage / 100.0);
            Console.WriteLine(aquarioumV);
        }
    }
}
