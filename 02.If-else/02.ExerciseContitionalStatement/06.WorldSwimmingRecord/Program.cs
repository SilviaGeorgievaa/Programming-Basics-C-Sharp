using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double recordSeconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());
            //calc
            double timesPer15Meters = Math.Floor(meters / 15);
            double slowTimePerMinutes =timesPer15Meters * 12.5;
            double ivansTime = meters * secondsPerMeter;
            double totalIvansTime = ivansTime + slowTimePerMinutes;
            if (totalIvansTime < recordSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalIvansTime:f2} seconds.");
            }
            else
            {
                double secondsSlower =Math.Abs (recordSeconds- totalIvansTime);
                Console.WriteLine($"No, he failed! He was {secondsSlower:f2} seconds slower.");
            }
        }
    }
}
