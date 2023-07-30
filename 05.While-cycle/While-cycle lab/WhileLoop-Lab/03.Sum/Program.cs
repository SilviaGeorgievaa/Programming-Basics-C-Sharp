using System;
using System.Dynamic;

namespace _03.Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int sum = 0;
            while (sum < number1)
            {
                int number2 = int.Parse(Console.ReadLine());
                sum+= number2;
            }
            Console.WriteLine(sum);
        }
    }
}
