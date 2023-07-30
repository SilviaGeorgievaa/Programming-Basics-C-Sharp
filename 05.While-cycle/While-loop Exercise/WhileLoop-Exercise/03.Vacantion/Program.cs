using System;

namespace _03.Vacantion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoneyForVacantion = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int dayCounter = 0;
            int spendingDay = 0;
            
            while (ownedMoney <= neededMoneyForVacantion && spendingDay < 5)
            {
                string word = Console.ReadLine();
                double savedSpendMoney = double.Parse(Console.ReadLine());
                if (word == "spend")
                {
                    if (spendingDay == 5)
                    {
                        break;
                    }
                    ownedMoney -= savedSpendMoney;
                    if (ownedMoney <= 0)
                    {
                        ownedMoney = 0;
                    }
                    spendingDay++;
                }
                else if (word == "save")
                {
                    ownedMoney += savedSpendMoney;
                    spendingDay = 0;
                }
                dayCounter++;
                if (ownedMoney >= neededMoneyForVacantion)
                {
                    break;
                }  
            }
            if (spendingDay == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{dayCounter}");
            }
            else if (ownedMoney >= neededMoneyForVacantion)
            {
                Console.WriteLine($"You saved the money for {dayCounter} days.");
            }
        }
    }
}
