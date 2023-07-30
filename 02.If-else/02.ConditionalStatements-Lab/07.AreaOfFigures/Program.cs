using System;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                double area = sideA * sideA;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double areaRectangle = sideA * sideB;
                Console.WriteLine($"{areaRectangle:f3}");
            }
            else if (figure == "circle")
            {
                double rad = double.Parse(Console.ReadLine());
                double areaCircle = Math.Pow(rad,2) * Math.PI;
                Console.WriteLine($"{areaCircle:f3}");
            }
            else if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideH = double.Parse(Console.ReadLine());
                double areaTriangle = sideA * sideH / 2;
                Console.WriteLine($"{areaTriangle:f3}");
            }
        }
    }
}
