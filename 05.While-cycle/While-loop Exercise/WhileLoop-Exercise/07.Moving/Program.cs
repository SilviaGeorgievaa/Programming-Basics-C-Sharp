using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shirina = int.Parse(Console.ReadLine());
            int dyljina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            int obem = shirina * dyljina * visochina;
            
            string input = Console.ReadLine();
            while (input != "Done")
            {
                int kashoni = int.Parse(input);
                if (obem > 0)
                {
                    obem -= kashoni;  
                }
                if (obem <= 0)
                {
                    break;
                }
                input = Console.ReadLine();
               
            }
            if (input == "Done")
            {
                Console.WriteLine($"{obem} Cubic meters left.");
            }
            else if (obem <= 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(obem)} Cubic meters more."); 
            }
            
        }
    }
}
