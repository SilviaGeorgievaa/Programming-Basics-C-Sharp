using System;

namespace _10._Multip
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            double number = double.Parse(Console.ReadLine());

            while (number >= 0)
            {
                Console.WriteLine($"Result: {2 * number:f2}");

                number = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Negative ");



            //while (true)
            //{
            //    double number = double.Parse(Console.ReadLine());

            //    if (number < 0)
            //    {
            //        Console.WriteLine("Negative number!");
            //        break;
            //    }

            //    Console.WriteLine($"Result: {2 * number:f2}");
            //}
        }
    }
}
