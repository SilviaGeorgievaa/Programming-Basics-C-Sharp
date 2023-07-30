using System;

namespace _02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniorCount = int.Parse(Console.ReadLine());
            int seniorCount = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();
            double charityMoney = 0;
            int allParticipants = juniorCount + seniorCount;
            if (trace == "trail")
            {
                charityMoney = juniorCount * 5.50 + seniorCount * 7;
            }
            else if (trace == "cross-country")
            {
                if (allParticipants >= 50)
                {
                    charityMoney = (juniorCount * 8 + seniorCount * 9.50) * 0.75;
                }
                else
                {
                    charityMoney = juniorCount * 8 + seniorCount * 9.50;
                }
            }
            else if (trace == "downhill")
            {
                charityMoney = juniorCount * 12.25 + seniorCount * 13.75;
            }
            else
            {
                charityMoney = juniorCount * 20 + seniorCount * 21.50;
            }

            double final = charityMoney * 0.95;
            Console.WriteLine($"{final:f2}");

        }
    }
}
