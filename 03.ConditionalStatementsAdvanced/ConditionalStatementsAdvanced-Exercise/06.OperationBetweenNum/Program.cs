using System;

namespace _06.OperationBetweenNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            
            if ((operation == '/' || operation == '%') && num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            else if (operation == '/')
            {
                double delresult = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {delresult:f2}");
            }
            else if (operation == '%')
            {
                double modresult = num1 % num2;
                Console.WriteLine($"{num1} % {num2} = {modresult}");
            }
            else
            {
                double result = 0;
                if (operation == '+')
                {
                    result = num1 + num2;
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                }
                else if (operation == '*')
                {
                    result = num1 * num2;
                }
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
                }
            }
        }
    }
}
