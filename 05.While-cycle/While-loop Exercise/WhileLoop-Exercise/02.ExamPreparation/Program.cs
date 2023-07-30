using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPoorGrades = int.Parse(Console.ReadLine());
            string nameOfTask = Console.ReadLine();

            int poorGrades = 0;
            double countProblems = 0;
            int sumallGrades = 0;
            string lastTask = "";
            
            while (nameOfTask != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    poorGrades++;
                    if (poorGrades == countPoorGrades)
                    {
                        break;
                    }
                }
                sumallGrades += grade;
                countProblems++;
                
                lastTask= nameOfTask;
                nameOfTask = Console.ReadLine();
            }
            double average = sumallGrades/ countProblems;
            if (poorGrades == countPoorGrades)
            {
                Console.WriteLine($"You need a break, {poorGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {countProblems}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
