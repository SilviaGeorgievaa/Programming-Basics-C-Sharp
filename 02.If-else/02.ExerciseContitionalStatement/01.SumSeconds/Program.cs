﻿using System;

namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            //calculation the sum
            int totalTime = firstTime + secondTime + thirdTime;
            //calculate minutes and seconds
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            // print
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
