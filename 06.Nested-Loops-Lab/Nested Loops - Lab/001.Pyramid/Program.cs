﻿using System;

namespace _001.Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1;
            int numberPrint = 1;
            while (numberPrint <= n)
            {
                
                for (int i = 0; i < row; i++)
                {
                    Console.Write($"{numberPrint} ");
                    numberPrint++;
                    if (numberPrint >n)
                    {
                        break;
                    }
                    
                }
                row++;
                Console.WriteLine();
            }





            //int row = 1;
            //int countOfWrittNum = 0;
            //for (int i = 1 ; i <= n; i++)
            //{
            //    Console.Write($"{i} ");

            //    countOfWrittNum++;
            //    if (countOfWrittNum == row)
            //    {
            //        Console.WriteLine();
            //        countOfWrittNum = 0;
            //        row++;
            //    }
            //}
        }
    }
}
