using System;

namespace _03.ConsoleConv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Input degrees (Celsius):");
            double degreesC = double.Parse(Console.ReadLine());
            double constOne = 1.8;
            double constTwo = 32;
            //calculation T(f) = T(c) * 1.8 + 32
            double degreesF = degreesC * constOne + constTwo;
            //print
            Console.WriteLine($"The temperature in degrees Fahrenheit is: {degreesF:f2} F.");
        }
    }
}
