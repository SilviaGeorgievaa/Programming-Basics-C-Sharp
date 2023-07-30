using System;

namespace _002.ReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int neededMOney = int.Parse(Console.ReadLine());
            double sumcash = 0;
            double sumcart = 0;
            double summoney = 0;
            int transactioncount = 0;
            int cashcount = 0;
            int cartcount = 0;
            string input = Console.ReadLine();
            while (input != "End")
            {

                int money = int.Parse(input);
                transactioncount++;


                if (transactioncount % 2 != 0)
                {

                    if (money > 100)
                    {
                        Console.WriteLine("Error in transaction!");

                    }
                    else
                    {
                        sumcash += money;
                        cashcount++;
                        Console.WriteLine("Product sold!");
                    }

                }
                else
                {
                    if (money < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        sumcart += money;
                        cartcount++;
                        Console.WriteLine("Product sold!");
                    }
                    summoney = sumcash + sumcart;
                    if (summoney >= neededMOney)
                    {
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            double card = sumcart / cartcount;
            double cash = sumcash / cashcount;
            if (summoney >= neededMOney)
            {
                Console.WriteLine($"Average CS: {cash:f2}");
                Console.WriteLine($"Average CC: {card:f2}");
            }
            else if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
