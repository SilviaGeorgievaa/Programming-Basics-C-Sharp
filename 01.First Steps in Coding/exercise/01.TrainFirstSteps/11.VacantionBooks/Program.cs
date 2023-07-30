using System;

namespace _11.VacantionBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int pagesInBook = int.Parse(Console.ReadLine());
            int pagesForHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            //calculate
            int readPagesForHour = pagesInBook / pagesForHour;
            int countOfHours = readPagesForHour / days;
            //print
            Console.WriteLine(countOfHours);
        }
    }
}
