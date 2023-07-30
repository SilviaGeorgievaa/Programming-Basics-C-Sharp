using System;

namespace SofthePR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            Console.WriteLine("Input the big side:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the small side");
            int b = int.Parse(Console.ReadLine());
            //calculation
            int c = a * b;
            //Print
            Console.WriteLine($"The result is: {c}");
        }
    }
}
