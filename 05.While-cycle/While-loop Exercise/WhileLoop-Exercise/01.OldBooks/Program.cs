using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int bookNumber = 0;
            bool isFound = false;
            string currentBook = Console.ReadLine();
            while (currentBook != "No More Books" )
            { 
                if (currentBook == bookName)
                {
                    isFound= true;
                    break;
                    
                }
                bookNumber++;
                currentBook = Console.ReadLine();
                
            }
            if (isFound)
            {
                Console.WriteLine($"You checked {bookNumber} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {bookNumber} books.");
            }
            
        }
    }
}
