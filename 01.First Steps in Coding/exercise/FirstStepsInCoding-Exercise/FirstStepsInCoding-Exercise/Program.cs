﻿using System;

namespace FirstStepsInCoding_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double usdBgn = usd * 1.79549;
            
            Console.WriteLine(usdBgn);
        }
    }
}
