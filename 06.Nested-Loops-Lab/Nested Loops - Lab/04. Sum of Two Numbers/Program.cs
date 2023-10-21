using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int conbinations = 0;
            bool isFound = false;
            for (int i = b; i <= e; i++)
            {
                for (int i1 = b ; i1 <= e; i1++)
                {
                    conbinations++;
                    if (i1 + i == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{conbinations} ({i} + {i1} = {magicNumber})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{conbinations} combinations - neither equals {magicNumber}");
            }
        }
    }
}
