using System;

namespace _04.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            //
            if (time == "day" && km < 20)
            {
                double taxiday = 0.70 + km * 0.79;
                Console.WriteLine($"{taxiday:f2}");
            }
            else if (time != "day" && km < 20)
            {
                double taxinight = 0.70 + km * 0.90;
                Console.WriteLine($"{taxinight:f2}");
            }
            else if (km >= 20 && km < 100)
            {
                double buss = km * 0.09;
                Console.WriteLine($"{buss:f2}");
            }
            else
            {
                double train = km * 0.06;
                Console.WriteLine($"{train:f2}");
            }

        }
    }
}
