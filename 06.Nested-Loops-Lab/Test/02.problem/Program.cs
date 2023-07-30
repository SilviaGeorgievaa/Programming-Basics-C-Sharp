using System;

namespace _02.problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double neededSumForBall = double.Parse(Console.ReadLine());

            double shortiPrice = tshirtPrice * 0.75;
            double socksPrice = shortiPrice * 0.20;
            double bothShortiSocks = tshirtPrice + shortiPrice;
            double butonkiPrice = bothShortiSocks * 2;
            double beforeDisc = bothShortiSocks + butonkiPrice + socksPrice;
            double priceAfterDisc = beforeDisc - beforeDisc * 0.15;

            if (priceAfterDisc >= neededSumForBall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {priceAfterDisc:f2} lv.");
            }
            else
            {
                double neededM = neededSumForBall - priceAfterDisc;
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {neededM:f2} lv. more." ); 
            }
        }
    }
}
