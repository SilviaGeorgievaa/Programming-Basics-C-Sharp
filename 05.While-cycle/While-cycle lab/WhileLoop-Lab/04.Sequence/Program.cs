﻿using System;

namespace _04.Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            while (result <= n)
            {
                Console.WriteLine(result);
                result = result * 2 + 1;
            } 
        }
    }
}
