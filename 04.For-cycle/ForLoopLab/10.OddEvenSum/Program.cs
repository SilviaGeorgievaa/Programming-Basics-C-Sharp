using System;

namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0; int evenSum2 = 0;

            for (int i = 1; i <= n; i++)
            {
                int Num1 = int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    oddSum+= Num1;
                }
                else
                {
                    evenSum2 += Num1;
                }
            }
            if (oddSum == evenSum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddSum - evenSum2)}");    
            }
        }
    }
}
