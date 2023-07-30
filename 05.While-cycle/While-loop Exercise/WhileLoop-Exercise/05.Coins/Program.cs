using System;

namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int countOfCoins = 0;
            while (amountOfMoney > 0)
            {
                if (amountOfMoney >= 2)
                {
                    amountOfMoney -= 2;
                }
                else if (amountOfMoney >= 1)
                {
                    amountOfMoney -= 1;
                }
                else if (amountOfMoney >= 0.5m)
                {
                    amountOfMoney -= 0.5m;
                }
                else if (amountOfMoney >= 0.2m)
                {
                    amountOfMoney -= 0.2m;
                }
                else if (amountOfMoney >= 0.1m)
                {
                    amountOfMoney -= 0.1m;
                }
                else if (amountOfMoney >= 0.05m)
                {
                    amountOfMoney -= 0.05m;
                }
                else if (amountOfMoney >= 0.02m)
                {
                    amountOfMoney -= 0.02m;
                }
                else
                {
                    amountOfMoney -= 0.01m;
                }
                countOfCoins++;
                
            }
            Console.WriteLine($"{countOfCoins}");
        }
    }
}
