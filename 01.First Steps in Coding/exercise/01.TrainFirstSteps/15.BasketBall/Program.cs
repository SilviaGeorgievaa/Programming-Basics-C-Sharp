using System;

namespace _15.BasketBall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input 
            int annualTax = int.Parse(Console.ReadLine());
            //calculation of the tools
            double basketShoes = annualTax - (annualTax * 40 / 100.0);
            double basketequipment = basketShoes - (basketShoes * 20 / 100.0);
            double ball = basketequipment * 1 / 4;
            double acessoary = ball * 1 / 5;
            //calculation 
            double theWholeTax = annualTax + basketShoes + basketequipment + ball + acessoary;
            //print
            Console.WriteLine(theWholeTax);
        }
    }
}
