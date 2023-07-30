using System;
using System.Data;

namespace _05.GodzillavsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double budjet = double.Parse(Console.ReadLine());
            int stat = int.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());
            //calculation for expenses
            double decor = budjet * 0.1; 
            // discount 10 % 
            if (stat > 150 )
            {
                clothing = clothing - clothing * 0.1;
            }
            // expenses
            double totalClothing = stat * clothing;
            double expenses = totalClothing + decor;
            if (expenses > budjet)
            {
                double moneyneeded = expenses - budjet;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyneeded:f2} leva more.");
            }
            else
            {
                double moneyleft = budjet - expenses;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyleft:f2} leva left.");
            }
        }
    }
}
