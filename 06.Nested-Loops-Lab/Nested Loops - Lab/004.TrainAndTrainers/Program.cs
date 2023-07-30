using System;

namespace _004.TrainAndTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            
            double sumGrades = 0;
            int allprezcount = 0;
            while (presentationName != "Finish")
            {
                
                //for (int i = 1; i <= n; i++)
                //{
                    //int currentNum = n;
                    int currentPresentcount = 0;
                    double currentSumGrades = 0;
                    double grade = double.Parse(Console.ReadLine());
                    for (int i1 = 1; i1 <= n; i1++)
                    {
                        currentSumGrades += grade;
                        currentPresentcount++;
                        if (currentPresentcount == n)
                        {
                            break;
                        }
                        grade = double.Parse(Console.ReadLine());
                    }
                    allprezcount += currentPresentcount;
                    sumGrades += currentSumGrades;
                    decimal currentPrezAverage = (decimal)currentSumGrades / currentPresentcount;
                    Console.WriteLine($"{presentationName} - {currentPrezAverage:f2}.");

                    presentationName = Console.ReadLine();

                //}
                
            }

            double average = sumGrades / allprezcount;
            Console.WriteLine($"Student's final assessment is {average:f2}.");
        }
    }
}
