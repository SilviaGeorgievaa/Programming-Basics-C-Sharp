using System;

namespace _08.FuelTank2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            double litres = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine().ToLower();
            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;
            
            if (fuel == "gasoline")
            {
                if (clubCard == "yes")
                {
                    double litWithDiscount = litres * gasoline - (litres * 0.18);
                    if (litres >= 20 && litres <= 25)
                    {
                        double totalPrice = litWithDiscount - (litWithDiscount * 0.08);
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else if (litres > 25)
                    {
                        double totalPrice = litWithDiscount - (litWithDiscount * 0.10);
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{litWithDiscount:f2} lv.");
                    }
                }
                else
                {
                    double withoutDiscount = litres * gasoline;
                    if (litres >= 20 && litres <= 25)
                    {
                        double totalPrice = withoutDiscount - (withoutDiscount * 0.08);
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else if (litres > 25)
                    {
                        double totalPrice = withoutDiscount - (withoutDiscount * 0.1);
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{withoutDiscount:f2} lv.");
                    }
                }
            }
            if (fuel == "diesel")
            {
                if (clubCard == "yes")
                {
                    double litWithDiscount = litres * diesel - (litres * 0.12);
                    if (litres >= 20 && litres <= 25)
                    {
                        double totalPrice = litWithDiscount - (litWithDiscount * 0.08);
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else if (litres > 25)
                    {
                        double totalPrice = litWithDiscount - (litWithDiscount * 0.10);
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{litWithDiscount:f2} lv.");
                    }
                }
                else
                {
                    double withoutDiscount = litres * diesel;

                    if (litres >= 20 && litres <= 25)
                    {
                        double totalPrice = withoutDiscount - (withoutDiscount * 0.08);
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else if (litres > 25)
                    {
                        double totalPrice = withoutDiscount - (withoutDiscount * 0.1);
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{withoutDiscount:f2} lv.");
                    }
                }
            }
            if (fuel == "gas")
            {
                if (clubCard == "yes")
                {
                    double litWithDiscount = litres * gas - (litres * 0.08);
                    if (litres >= 20 && litres <= 25)
                    {
                        double totalPrice = litWithDiscount - (litWithDiscount * 0.08);
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else if (litres > 25)
                    {
                        double totalPrice = litWithDiscount - (litWithDiscount * 0.10);
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{litWithDiscount:f2} lv.");
                    }
                }
                else
                {
                    double withoutDiscount = litres * gas;
                    if (litres >= 20 && litres <= 25)
                    {
                        double totalPrice = withoutDiscount - (withoutDiscount * 0.08);
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else if (litres > 25)
                    {
                        double totalPrice = withoutDiscount - (withoutDiscount * 0.1);
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{withoutDiscount:f2} lv.");
                    }
                }
            }
        }
    }
}
