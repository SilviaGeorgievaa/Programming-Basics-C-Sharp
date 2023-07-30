using System;

namespace _07.HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xheightOfHouse = double.Parse(Console.ReadLine());
            double ylenhgtOfHouse = double.Parse(Console.ReadLine());
            double hHeightOfRooftop = double.Parse(Console.ReadLine());
            //calculation square sides
            double squareSide = xheightOfHouse * xheightOfHouse;
            double withoutSquareSide = squareSide - (1.2 * 2);
            double twoSquareSidea = squareSide + withoutSquareSide;
            //calculation rectangle sides
            double rectangleSides = xheightOfHouse * ylenhgtOfHouse;
            double withoutRectangle = rectangleSides - (1.5 * 1.5);
            double twoRectangleSides = 2 * withoutRectangle;
            //
            double allSides = twoSquareSidea + twoRectangleSides;
            //calculation roof ractangle
            double roofRectangle = xheightOfHouse * ylenhgtOfHouse;
            double twoRoofRectangles = 2 * roofRectangle;
            //calculation roof triangles
            double trinangleRoofSide = xheightOfHouse * hHeightOfRooftop / 2;
            double twoTriangleRoofSides = 2 * trinangleRoofSide;
            //
            double allRoofSides = twoRoofRectangles + twoTriangleRoofSides;
            //littt
            double litRed = allRoofSides / 4.3;
            double litGreenPaint = allSides / 3.4;
            //print
            Console.WriteLine($"{litGreenPaint:f2}");
            Console.WriteLine($" {litRed:f2}");
        }
    }
}
