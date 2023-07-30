using System;

namespace _003.Leters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int countN = 0;
            int countO = 0;
            int countC = 0;

            string word = "";
            string wholePhrase = "";
            string letter = Console.ReadLine();
            while (letter != "End")
            {
                bool isLetter = (letter[0] >= 'a' && letter[0] <= 'z') || (letter[0] >= 'A' && letter[0] <= 'Z');
                if (!isLetter)
                {
                    letter = Console.ReadLine();
                    continue;
                }

                if (letter == "n" && countN > 0)
                {
                    word += letter;
                }
                else if (letter == "n" && countN == 0)
                {
                    countN++;
                }

                if (letter == "o" && countO > 0)
                {
                    word += letter;
                }
                else if (letter == "o" && countO == 0)
                {
                    countO++;
                }

                if (letter == "c" && countC > 0)
                {
                    word += letter;
                }
                else if (letter == "c" && countC == 0)
                {
                    countC++;
                }
                else if (letter != "n" && letter != "o" && letter != "c")
                {
                    word += letter;
                }
                if (countC == 1 && countN == 1 && countO == 1)
                {
                    word += " ";
                    countO = 0;
                    countN = 0;
                    countC = 0;

                    wholePhrase += word;
                    word = "";
                }

                letter = Console.ReadLine();
            }

            Console.WriteLine(wholePhrase);
        }
    }
}
