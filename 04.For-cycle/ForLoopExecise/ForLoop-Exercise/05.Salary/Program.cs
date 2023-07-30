﻿using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int fee = 0; 
            for (int i = 0; i < n && salary > fee ; i++)
            {
                string openTab = Console.ReadLine();
                if (openTab == "Facebook")
                {
                    fee += 150;
                }
                else if (openTab == "Instagram")
                {
                    fee += 100;
                }
                else if (openTab == "Reddit")
                {
                    fee += 50;
                }
            }
            if (salary <= fee)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary - fee);
            }
        }
    }
}
