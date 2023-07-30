using System;

namespace _09.testGraduat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double grade = 0;
            int klas = 1;
            int badGrades = 0;

            while (klas <= 12)
            {
                double currentGrade = double.Parse((Console.ReadLine()));
                if (currentGrade < 4)
                {
                    badGrades++;
                    if (badGrades == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {klas} grade");
                        return;
                    }
                    continue;
                }
                klas++;
                grade += currentGrade;
            }
            double sum = grade / 12;
            Console.WriteLine($"{name} graduated. Average grade: {sum:f2}");
        }
    }
}
