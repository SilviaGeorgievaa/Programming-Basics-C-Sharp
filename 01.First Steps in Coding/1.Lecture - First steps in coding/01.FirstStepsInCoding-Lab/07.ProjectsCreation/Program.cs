﻿using System;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int result = numberOfProjects * 3;

            Console.WriteLine($"The architect {name} will need {result} hours to complete {numberOfProjects} project/s.");
        }
    }
}
