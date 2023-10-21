using System;

namespace _08.TimeOnExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            int examNorm = hourExam * 60 + minutesExam;
            int arrivalNorm = hourArrival * 60 + minutesArrival;
            string output, keyword;
            if (arrivalNorm > examNorm)
            {
                output = "Late";
                keyword = "after";
            }
            else
            {
                if (arrivalNorm >= examNorm - 30)
                {
                    output = "On time";
                    keyword = "before";
                }
                else
                {
                    output = "Early";
                    keyword = "before";
                }
            }
            int diff = Math.Abs(examNorm - arrivalNorm);
            int diffHours = diff / 60;
            int diffMinutes = diff % 60;
            string formateddiff;
            
            if (diffMinutes < 10)
            {
                if (diffHours <= 0)
                {
                    formateddiff = $"{diffMinutes} minutes";
                }
                else
                {
                    formateddiff = $"{diffHours}:0{diffMinutes} hours";
                }
            }
            else 
            {
                if (diffHours <= 0)
                {
                    formateddiff = $"{diffMinutes} minutes";
                }
                else
                {
                    formateddiff = $"{diffHours}:{diffMinutes} hours";
                } 
            }
            
            Console.WriteLine(output);
            Console.WriteLine($"{formateddiff} {keyword} the start");
        }
     }
}
