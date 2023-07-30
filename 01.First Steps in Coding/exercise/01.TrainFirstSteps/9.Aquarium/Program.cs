using System;

namespace _9.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            Console.WriteLine("lenght");
            int lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("width");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("percentage");
            double percentage = double.Parse(Console.ReadLine());
            //calculate the V of paralelepiped = a * b * C in dm3
            double paraleleVsm = lenght * width * height;
            double dm3paraleleV = paraleleVsm * 0.001;
            //calculate the the V with fullness
            double theVWithFullness = dm3paraleleV - (dm3paraleleV * percentage / 100.0);
            //print
            Console.WriteLine($"The V is: {theVWithFullness} dm3");
        }
    }
}
