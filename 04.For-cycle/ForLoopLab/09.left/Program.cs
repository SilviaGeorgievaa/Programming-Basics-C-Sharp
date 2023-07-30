using System;

namespace _09.left
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0; int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNum1 = int.Parse(Console.ReadLine());
                
                sum1 += currentNum1;
            }
            for (int i = 0; i < n; i++)
            {
                int currentNum1 = int.Parse(Console.ReadLine());
                sum2 += currentNum1;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                int raz = Math.Abs(sum1 - sum2);
                Console.WriteLine($"No, diff = {raz}");
            }
        }
    }
}
