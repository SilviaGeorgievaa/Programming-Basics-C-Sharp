using System;

namespace _01.TestProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            int num1 = number % 10;
            int num10 = number / 10 % 10;
            int num100 = number / 100 % 10;

            for (int i = 1; i <= num1; i++)
            {
                for (int i2 = 1; i2 <= num10; i2++)
                {
                    for (int i3 = 1; i3 <= num100; i3++)
                    {
                        result = i * i2 * i3;
                        Console.WriteLine($"{i} * {i2} * {i3} = {result};");
                    }

                }

            }

        }
    }
}
