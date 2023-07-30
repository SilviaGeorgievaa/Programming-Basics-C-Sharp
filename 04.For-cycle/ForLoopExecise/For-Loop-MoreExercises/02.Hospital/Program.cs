using System;

namespace _02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            double treatened = 0;
            double untreatened = 0;
            double ostatyk = 0;
            double doctors = 7;
            for (int i = 1; i <= period; i++)
            {
                int countOfPatience = int.Parse(Console.ReadLine());
               
                if (countOfPatience < doctors)
                {
                    treatened += countOfPatience;
                }
                else if (countOfPatience >= doctors)
                {
                    treatened += 7;
                }

                if (countOfPatience > doctors)
                {
                    ostatyk = countOfPatience - doctors;
                    untreatened += ostatyk;
                }
                
            }
            for (int i = 3; i < 4; i++)
            {
                if (untreatened > treatened)
                {
                    doctors++;
                }
            }
            Console.WriteLine(treatened);
            Console.WriteLine(untreatened);
        }
    }
}
