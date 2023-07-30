using System;

namespace _04.Steps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int neededSteps = 10000;

            bool shouldFinished = false;
            int sumOfSteps= 0;
            while (!shouldFinished && sumOfSteps < neededSteps)
            {
                string input = Console.ReadLine();

                int currentSteps = 0;
                if (input == "Going home")
                {
                    currentSteps = int.Parse(Console.ReadLine());
                    shouldFinished= true;
                }
                else
                {
                    currentSteps= int.Parse(input);
                }
                sumOfSteps += currentSteps;
            }
            if (sumOfSteps >= neededSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sumOfSteps - neededSteps} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{neededSteps - sumOfSteps} more steps to reach goal.");
            }
        }
    }
}
