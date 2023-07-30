using System;
using System.Threading.Tasks;

namespace _07.FuelTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            int litres = int.Parse(Console.ReadLine());
            //if
            if (fuel == "diesel")
            {
                if (litres < 25)
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
                else
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
            }
            else if (fuel == "gasoline")
            {
                if (litres < 25) 
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
                else
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
            }
            else if (fuel == "gas")
            {
                if (litres < 25)
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
                else
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
                
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }

        }
    }
}
