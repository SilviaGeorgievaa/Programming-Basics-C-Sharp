using System;
using System.Threading.Tasks.Dataflow;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());

            double price = area * 7.61;
            double discount = price * 0.18; //18/100
            double result = price - discount;

            Console.WriteLine($"The final price is: {result} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
