using System;

namespace _12.SchoolMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int cleaningTool = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            //calculate
            double pensCost = pens * 5.80;
            double markersCost = markers * 7.20;
            double cleaningCost = cleaningTool * 1.20;
            double notDiscMoney = pensCost + markersCost + cleaningCost;
            double disOfMoney = (pensCost + markersCost + cleaningCost) * discount / 100.0;
            double money = notDiscMoney - disOfMoney;
            //print
            Console.WriteLine(money);
        }
    }
}
