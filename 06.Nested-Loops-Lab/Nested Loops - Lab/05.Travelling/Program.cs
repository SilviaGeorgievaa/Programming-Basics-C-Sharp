using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            
            while (input != "End")
            {
                double minBudjet = double.Parse(Console.ReadLine());
                
                
                while (minBudjet > 0)
                {
                    double currentSaveMoney = double.Parse(Console.ReadLine());
                    minBudjet -= currentSaveMoney;
                }
                Console.WriteLine($"Going to {input}!");

                input = Console.ReadLine();
            }
        }
    }
}
