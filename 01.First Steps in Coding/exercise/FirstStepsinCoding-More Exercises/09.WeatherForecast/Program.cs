﻿using System;

namespace _09.WeatherForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string weather = (Console.ReadLine());
            if (weather == "sunny")
            {
                Console.WriteLine("It's sunny outside!");
            }
            else 
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
