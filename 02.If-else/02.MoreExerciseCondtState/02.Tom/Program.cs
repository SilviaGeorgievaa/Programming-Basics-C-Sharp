using System;

namespace _02.Tom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            //
            int norm = 30000;
            int minutesWorkDays = 63;
            int minutesRestdays = 127;
            int daysPerYear = 365;
            //calc
            int workDays = daysPerYear - restDays;
            double timeForPlaying = restDays * minutesRestdays + workDays * minutesWorkDays;
            double time = Math.Abs(norm - timeForPlaying);
            double timeHours =Math.Floor(time / 60);
            double timeMinutes = time % 60;
            //if
            if (norm< timeForPlaying)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{timeHours} hours and {timeMinutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{timeHours} hours and {timeMinutes} minutes less for play");
            }
        }
    }
}
