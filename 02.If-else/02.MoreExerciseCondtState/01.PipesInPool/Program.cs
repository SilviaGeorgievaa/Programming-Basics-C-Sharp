using System;

namespace _01.PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poolV = int.Parse(Console.ReadLine());
            int debitP1 = int.Parse(Console.ReadLine());
            int debitP2 = int.Parse(Console.ReadLine());
            double hoursAbsence =double.Parse(Console.ReadLine());
            //calc
            double allDebitP1 = debitP1 * hoursAbsence;
            double allDebitP2 = debitP2 * hoursAbsence;
            double allP1P2 = allDebitP1 + allDebitP2;
            double fillingPool = allP1P2 / poolV;
            double percentFillingPool = fillingPool * 100;
            //calc separate
            double fillingAllDebitP1 = allDebitP1 / allP1P2;
            double percentageAlldebitP1 = fillingAllDebitP1 * 100;
            double fillingAllDebitp2 = allDebitP2 / allP1P2;
            double percentageAlldebitP2 = fillingAllDebitp2 * 100;
            if (allP1P2 <= poolV)
            {
                Console.WriteLine($"The pool is {percentFillingPool}% full. Pipe 1: {percentageAlldebitP1:f2}%. Pipe 2: {percentageAlldebitP2:f2}%.");
            }
            else
            {
                double overfloat = allP1P2 - poolV;
                Console.WriteLine($"For {hoursAbsence:f2} hours the pool overflows with {overfloat:f2} liters.");
            }
        }
    }
}
