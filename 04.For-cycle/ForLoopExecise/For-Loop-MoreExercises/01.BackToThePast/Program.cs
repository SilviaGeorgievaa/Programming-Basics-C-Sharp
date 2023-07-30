using System;

namespace _01.BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double ivanchoYears = 18;
            double money = 0;
            
            for (int i = 1800; i <= year; i++)
            {
                
                if (i % 2 == 0)
                {
                    money += 12000;
                }
                else
                {
                    double age = ivanchoYears + (i - 1800);
                    money += 12000 + 50 * age;
                }
            }
            if (money <= inheritedMoney)
            {
                double leftMoney = inheritedMoney - money;
                Console.WriteLine($"Yes! He will live a carefree life and will have {leftMoney:f2} dollars left.");
            }
            else
            {
                double survive = Math.Abs(inheritedMoney- money);
                Console.WriteLine($"He will need {survive:f2} dollars to survive.");
            }
        }
    }
}
