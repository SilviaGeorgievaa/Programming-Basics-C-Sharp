using System;

namespace _07.Trecking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            int g5 = 0;
            for (int i = 1; i <= num; i++)
            {
                int count = int.Parse(Console.ReadLine());
                
                if (count <= 5)
                {
                    g1 += count;
                }
                else if (count <= 12)
                {
                    g2 += count;
                }
                else if (count <= 25 )
                {
                    g3 += count;
                }
                else if (count <= 40)
                {
                    g4 += count;
                }
                else
                {
                    g5 += count;
                }
            }
            int all = g1 + g2 + g3 + g4 + g5;
            Console.WriteLine($"{(double)g1 / all * 100:f2}%");
            Console.WriteLine($"{(double)g2 / all * 100:f2}%");
            Console.WriteLine($"{(double)g3 / all * 100:f2}%");
            Console.WriteLine($"{(double)g4 / all * 100:f2}%");
            Console.WriteLine($"{(double)g5 / all * 100:f2}%");
        }
    }
}
