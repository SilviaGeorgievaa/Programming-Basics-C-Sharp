using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int durationOfEpizod = int.Parse(Console.ReadLine());
            int durationBreak = int.Parse(Console.ReadLine());
            //calculation
            double lunchTime = durationBreak * 0.125;
            double restTime = durationBreak * 0.25;
            double timeForSerial = durationBreak - lunchTime - restTime;
            //if
            if (timeForSerial > durationOfEpizod)
            {
                double timeLeft =Math.Ceiling(timeForSerial - durationOfEpizod);
                Console.WriteLine($"You have enough time to watch {serialName} and left with {timeLeft} minutes free time.");
            }
            else
            {
                double timeNeeded = Math.Ceiling(durationOfEpizod - timeForSerial);
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {timeNeeded} more minutes.");
            }
        }
    }
}
