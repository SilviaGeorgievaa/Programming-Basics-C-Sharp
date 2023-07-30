using System;

namespace _10.CalcDeposits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            Console.WriteLine("Deposit Sum:");
            double deposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Period (months)");
            int months = int.Parse(Console.ReadLine());
            Console.WriteLine("Interest Rate");
            double rate = double.Parse(Console.ReadLine());
            //Calculation
            double sum = deposit + months * (deposit * rate * 0.01 / 12);
            //print
            Console.WriteLine($"The Deposit sum is: {sum} lv.");
        }
    }
}
