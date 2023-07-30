using System;

namespace _001.Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countofVero = int.Parse(Console.ReadLine());
            int consistencyVero = 750;
            int vero = consistencyVero * countofVero;

            int plate = 5;
            int tendjera = 15;
            int zarejdaniqCount = 0;
            int platescount = 0;
            int tendjeracount = 0;
            string input = Console.ReadLine();
            while (input != "End")
            {
                int pribori = int.Parse(input);
                zarejdaniqCount++;
                if (vero >= 0)
                {
                    if (zarejdaniqCount % 3 == 0)
                    {
                        vero -= pribori * tendjera;
                        tendjeracount += pribori;
                    }
                    else
                    {
                        vero -= pribori * plate;
                        platescount += pribori;
                    }
                }
                if (vero < 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (vero >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{platescount} dishes and {tendjeracount} pots were washed.");
                Console.WriteLine($"Leftover detergent {vero} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(vero)} ml. more necessary!");
            }
        }
    }
}
