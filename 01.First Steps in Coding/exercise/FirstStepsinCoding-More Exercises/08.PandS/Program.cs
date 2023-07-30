using System;
using System.Threading;

namespace _08.PandS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            //formula S
            double circleS = (r * r) * Math.PI;
            //formula P
            double circleP = 2 * r * Math.PI;
            Console.WriteLine($"S= {circleS:f2}");
            Console.WriteLine($"P= {circleP:f2}");
        }
    }
}
