using System;

namespace ConvertSmIntoInch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("input the inch:");
            int inch = int.Parse(Console.ReadLine());
            double inchSM = 2.54;
            //calculate
            double calculationInchSm = inch * inchSM;
            //print
            Console.WriteLine($"The result is: {calculationInchSm}");
        }
    }
}
