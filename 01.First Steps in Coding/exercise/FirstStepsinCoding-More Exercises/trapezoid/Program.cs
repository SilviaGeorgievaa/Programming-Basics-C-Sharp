using System;

namespace FirstStepsinCoding_More_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input
            Console.WriteLine("Input big base:");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input small base:");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Input height:");
            double h = double.Parse(Console.ReadLine());
            // formula S= (b1+b2) * h / 2
            double formulaS = (b1 + b2) * h / 2;
            //print
            Console.WriteLine($"{formulaS:f2}");
        }
    }
}
