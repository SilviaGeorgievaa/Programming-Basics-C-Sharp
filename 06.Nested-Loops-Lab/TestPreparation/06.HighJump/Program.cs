using System;

namespace _06.HighJump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wantedHeight = int.Parse(Console.ReadLine());
            int letva = wantedHeight - 30;
            
            int countfail = 0;
            int allCount = 0;
            while (true)
            {
               
                int currentJumpedHeight = int.Parse(Console.ReadLine());


                allCount++;
                if (letva < currentJumpedHeight)
                {
                    if (letva >= wantedHeight)
                    {
                        Console.WriteLine($"Tihomir succeeded, he jumped over {letva}cm after {allCount} jumps.");
                        break;
                    }
                    letva += 5;
                    countfail = 0;
                    continue;
                }
                else if (letva >= currentJumpedHeight)
                {
                    countfail++;

                }
                if (countfail == 3)
                {
                    
                    Console.WriteLine($"Tihomir failed at {letva}cm after {allCount} jumps.");
                    break;
                }
            }
        }
    }
}
