using System;
using System.Diagnostics.CodeAnalysis;

namespace _05.Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double balance = 0;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double currentIncome = double.Parse(input);
                if (currentIncome < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += currentIncome;
                Console.WriteLine($"Increase: {currentIncome:f2}");
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
