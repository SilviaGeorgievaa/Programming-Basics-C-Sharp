using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countpage = int.Parse(Console.ReadLine());
            int page = int.Parse(Console.ReadLine());
            int countdays = int.Parse(Console.ReadLine());

            int hoursday = countpage / page / countdays;

            Console.WriteLine(hoursday);
        }
    }
}
