using System;

namespace _04.TextAndNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inputs
            Console.WriteLine("Write your First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Write your Last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Write your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Write your town:");
            string town = Console.ReadLine();
            //whole sent
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
