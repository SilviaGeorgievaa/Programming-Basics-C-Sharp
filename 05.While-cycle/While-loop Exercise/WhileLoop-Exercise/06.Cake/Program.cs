using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int cakeVolume = width * lenght;
                        string input = Console.ReadLine();
            while (input != "STOP")
            {
                int pieceOfCake = int.Parse(input);
                if (cakeVolume > 0)
                {
                    cakeVolume -= pieceOfCake;
                }
                
                if (cakeVolume <= 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{Math.Abs(cakeVolume)} pieces are left.");
            }
            else if (cakeVolume <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeVolume)} pieces more.");
            }
           


        }
    }
}
