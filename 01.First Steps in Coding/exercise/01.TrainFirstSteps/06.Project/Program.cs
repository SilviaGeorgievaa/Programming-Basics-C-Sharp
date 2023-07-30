using System;

namespace _06.Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            string name = Console.ReadLine();
            int countP = int.Parse(Console.ReadLine());
            int hours = 3;
            //calculation
            int projectsHours = countP * hours;
            //print
            Console.WriteLine($"The architect {name} will need {projectsHours} hours to complete {countP} project/s.");
        }
    }
}
