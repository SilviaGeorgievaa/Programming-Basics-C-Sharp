using System;

namespace _09.RadiansIntoDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            double radians = double.Parse(Console.ReadLine());
            double multiplier = 180 / Math.PI;
            //calculate
            double degrees = radians * multiplier;
            //print
            Console.WriteLine(degrees);
        }
    }
}
