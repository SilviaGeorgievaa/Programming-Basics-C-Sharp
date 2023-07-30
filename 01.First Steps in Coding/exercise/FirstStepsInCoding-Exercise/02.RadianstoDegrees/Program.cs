using System;

namespace _02.RadianstoDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double radian = double.Parse(Console.ReadLine());
            double degrees = radian * 180 / Math.PI;

            Console.WriteLine(degrees);
        }
    }
}
