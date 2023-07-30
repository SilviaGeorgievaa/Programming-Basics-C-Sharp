using System;

namespace _04CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toy = int.Parse(Console.ReadLine());

            int countToy = 0;
            int money = 0;
            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    money += ((5 * i) - 1) ;
                }
                else
                {
                    countToy += 1;
                }
            }
            int allMoneyForToys = countToy * toy;
            int allMoney = money + allMoneyForToys;
            if (allMoney >= price)
            {
                Console.WriteLine($"Yes! {allMoney - price:f2}");
            }
            else
            {
                double final = Math.Abs(allMoney - price);
                Console.WriteLine($"No! {final:f2}");
            }
        }
    }
}
