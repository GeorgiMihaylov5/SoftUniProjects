using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product=Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    if(town=="Sofia")
                    {
                        Console.WriteLine(quantity*0.50);
                    }
                    else if(town=="Plovdiv")
                    {
                        Console.WriteLine(quantity * 0.40);
                    }
                    else
                    {
                        Console.WriteLine(quantity * 0.45);
                    }
                    break;
                case "water":
                    if (town == "Sofia")
                    {
                        Console.WriteLine(quantity * 0.80);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(quantity * 0.70);
                    }
                    else
                    {
                        Console.WriteLine(quantity * 0.70);
                    }
                    break;
                case "beer":
                    if (town == "Sofia")
                    {
                        Console.WriteLine(quantity * 1.20);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(quantity * 1.15);
                    }
                    else
                    {
                        Console.WriteLine(quantity * 1.10);
                    }
                    break;
                case "sweets":
                    if (town == "Sofia")
                    {
                        Console.WriteLine(quantity * 1.45);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(quantity * 1.30);
                    }
                    else
                    {
                        Console.WriteLine(quantity * 1.35);
                    }
                    break;
                case "peanuts":
                    if (town == "Sofia")
                    {
                        Console.WriteLine(quantity * 1.60);
                    }
                    else if (town == "Plovdiv")
                    {
                        Console.WriteLine(quantity * 1.50);
                    }
                    else
                    {
                        Console.WriteLine(quantity * 1.55);
                    }
                    break;
            }

        }
    }
}
