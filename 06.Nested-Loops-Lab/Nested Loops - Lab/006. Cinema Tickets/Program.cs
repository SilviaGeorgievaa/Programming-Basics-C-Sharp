using System;

namespace _006._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int totalSoldTickets = 0;
            int kidTickets = 0; int studentTickets = 0; int standardTickets = 0;
            while (filmName != "Finish")
            {
                int emptySeats = int.Parse(Console.ReadLine());
                int soldTicketsforCurrentFilm = 0;

                string ticket = Console.ReadLine();   
                while (ticket != "End")
                {

                    if (ticket == "kid")
                    {
                        kidTickets++;
                    }
                    else if (ticket == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticket == "standard")
                    {
                        standardTickets++;
                    }
                    soldTicketsforCurrentFilm++;
                    
                    if (soldTicketsforCurrentFilm >= emptySeats)
                    {
                        break;
                    }
                    ticket = Console.ReadLine();
                }
                double percentage =(double)soldTicketsforCurrentFilm / emptySeats * 100;
                Console.WriteLine($"{filmName} - {percentage:f2}% full.");
               totalSoldTickets += soldTicketsforCurrentFilm;
                filmName = Console.ReadLine();
            }
            double studentPer = (double)studentTickets / totalSoldTickets * 100;
            double standartPer = (double)standardTickets / totalSoldTickets * 100;
            double kidper = (double)kidTickets / totalSoldTickets * 100;
            Console.WriteLine($"Total tickets: {totalSoldTickets}");
            Console.WriteLine($"{studentPer:f2}% student tickets.");
            Console.WriteLine($"{standartPer:f2}% standard tickets.");
            Console.WriteLine($"{kidper:f2}% kids tickets.");
        }
    }
}
