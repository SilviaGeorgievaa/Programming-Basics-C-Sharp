using System;

namespace _05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //град / продукт  coffee  water   beer   sweets  peanuts
                   // Sofia   0.50    0.80    1.20    1.45    1.60
                   // Plovdiv 0.40    0.70    1.15    1.30    1.50
                    //Varna   0.45    0.70    1.10    1.35    1.55

            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double priceOfProduct = 0;
            switch (product)
            {
                case "coffee":
                    if (town == "Sofia")
                    {
                        priceOfProduct = 0.5;
                    }
                    else if (town == "Plovdiv")
                    {
                        priceOfProduct = 0.4;
                    }
                    else if (town == "Varna")
                    {
                        priceOfProduct = 0.45;
                    }
                    break;
                case "water":
                    if (town == "Sofia")
                    {
                        priceOfProduct = 0.8;
                    }
                    else if (town == "Plovdiv")
                    {
                        priceOfProduct = 0.7;
                    }
                    else if (town == "Varna")
                    {
                        priceOfProduct = 0.7;
                    }
                    break;
                case "beer":
                    if (town == "Sofia")
                    {
                        priceOfProduct = 1.2;
                    }
                    else if (town == "Plovdiv")
                    {
                        priceOfProduct = 1.15;
                    }
                    else if (town == "Varna")
                    {
                        priceOfProduct = 1.1;
                    }
                    break;
                case "sweets":
                    if (town == "Sofia")
                    {
                        priceOfProduct = 1.45;
                    }
                    else if (town == "Plovdiv")
                    {
                        priceOfProduct = 1.3;
                    }
                    else if (town == "Varna")
                    {
                        priceOfProduct = 1.35;
                    }
                    break;
                case "peanuts":
                    if (town == "Sofia")
                    {
                        priceOfProduct = 1.60;
                    }
                    else if (town == "Plovdiv")
                    {
                        priceOfProduct = 1.50;
                    }
                    else if (town == "Varna")
                    {
                        priceOfProduct = 1.55;
                    }
                    break;
            }
            double finalPrice = quantity * priceOfProduct;
            Console.WriteLine(finalPrice);
        }
    }
}
