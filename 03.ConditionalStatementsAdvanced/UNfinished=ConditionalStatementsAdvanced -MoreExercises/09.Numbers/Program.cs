using System;

namespace _09.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (true)
            {
                if (a > 10) {
                    break;
                }
                Console.WriteLine(a);
                a++;
            }
        }
    }
}
