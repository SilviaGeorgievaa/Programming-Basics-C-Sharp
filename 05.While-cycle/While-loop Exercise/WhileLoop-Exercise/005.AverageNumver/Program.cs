using System;

namespace _005.AverageNumver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
                count++;
            }
            Console.WriteLine($"{sum/count:f2}");
        }
    }
}
