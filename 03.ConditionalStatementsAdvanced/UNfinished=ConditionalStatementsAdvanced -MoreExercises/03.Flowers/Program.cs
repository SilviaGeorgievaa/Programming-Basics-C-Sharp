using System;

namespace _03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hrizantemiCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();
            double buquet = 0;
            double increase = 1.15;
            int allFlowers = hrizantemiCount + rosesCount + tulipsCount;
            int cons= 2;
            if (season == "Spring" || season == "Summer")
            {
                if (holiday == "Y")
                {
                    buquet = hrizantemiCount * (2 * increase) + rosesCount * (4.10 * increase) + tulipsCount * (2.50 * increase);
                }
                else
                {
                    buquet = hrizantemiCount * 2 + rosesCount * 4.10 + tulipsCount * 2.50;
                } 
            }
            else if (season == "Autumn" || season == "Winter")
            {
                if (holiday == "Y")
                {
                    buquet = hrizantemiCount * (3.75 * increase) + rosesCount * (4.50 * increase) + tulipsCount * (4.15 * increase);
                }
                else
                {
                    buquet = hrizantemiCount * 3.75 + rosesCount * 4.50 + tulipsCount * 4.15;
                }
            }
            if (tulipsCount > 7 && season == "Spring")
            {
                buquet = buquet * 0.95;
            }
            else if (rosesCount >= 10 && season == "Winter")
            {
                buquet = buquet * 0.9;
            }
            if (allFlowers > 20 && (season == "Summer" || season == "Winter" || season == "Autumn" || season == "Spring"))
            {
                buquet = buquet * 0.8;
            }
            double final = buquet + cons;
            Console.WriteLine($"{final:f2}");
        }
    }
}
