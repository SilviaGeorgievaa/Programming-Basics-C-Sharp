using System;

namespace _02.TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            //Console.WriteLine("Input the a-side:");
            double aSide = double.Parse(Console.ReadLine());
            //Console.WriteLine("Input the triangle height:");
            double height = double.Parse(Console.ReadLine());
            //calculate the area S= a*h /2
            double area = aSide * height / 2 ;
            //print
            Console.WriteLine($"T {area:f2} sm.");
        }
    }
}
