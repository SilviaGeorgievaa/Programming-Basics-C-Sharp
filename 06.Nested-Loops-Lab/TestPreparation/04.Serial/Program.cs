using System;

namespace _04.Serial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int serialCount = int.Parse(Console.ReadLine());

            double allCosts = 0;
            for (int i = 0; i < serialCount; i++)
            {
                string nameSerial = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                if (nameSerial == "Thrones")
                {
                    price = price * 0.5;
                }
                else if (nameSerial == "Lucifer")
                {
                    price = price * 0.6;
                }
                else if (nameSerial == "Protector")
                {
                    price = price * 0.7;
                }
                else if (nameSerial == "TotalDrama")
                {
                    price = price * 0.8;
                }
                else if (nameSerial == "Area")
                {
                    price = price * 0.9;
                }

                allCosts+= price;
            }
            if (budget >= allCosts)
            {
                double leftMoney = budget - allCosts;
                Console.WriteLine($"You bought all the series and left with {leftMoney:f2} lv.");
            }
            else if (budget < allCosts)
            {
                double needs = allCosts - budget;
                Console.WriteLine($"You need {needs:f2} lv. more to buy the series!");
            }
        }
    }
}
