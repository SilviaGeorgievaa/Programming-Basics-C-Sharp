using System;

namespace _05.SchoolHall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            int hallway = 100;
            //calculate w and h from meters to santimeters
            double wCentimeters = w * 100;
            double hCentimeters = h * 100;
            //calculation for H
            double hMinusOne = hCentimeters - hallway;
            int countOfPlacesH = (int)(hMinusOne / 70);
            //calc for W
            int countOfPlacesW = (int)(wCentimeters / 120); // double countOfPlacesw = Math.Floor (wCentimeters / 120);
            //calc all places
            int allPlaces = countOfPlacesH * countOfPlacesW;
            //calc the possible places
            int countOfPossiblePlaces = allPlaces - 3;
            //print
            Console.WriteLine(countOfPossiblePlaces);
        }
    }
}
