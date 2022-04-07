using System;

namespace TradeCommissions
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            if (sales < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                switch (town)
                {
                    case "Sofia":
                        if(sales<=500)
                        {
                            Console.WriteLine($"{sales*5/100:F2}");
                        }
                        else if(sales<=1000)
                        {
                            Console.WriteLine($"{sales * 7 / 100:F2}");
                        }
                        else if(sales<=10000)
                        {
                            Console.WriteLine($"{sales * 8 / 100:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"{sales * 12 / 100:F2}");
                        }
                        break;
                    case "Varna":
                        if (sales <= 500)
                        {
                            Console.WriteLine($"{sales * 4.5 / 100:F2}");
                        }
                        else if (sales <= 1000)
                        {
                            Console.WriteLine($"{sales * 7.5 / 100:F2}");
                        }
                        else if (sales <= 10000)
                        {
                            Console.WriteLine($"{sales * 10 / 100:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"{sales * 13 / 100:F2}");
                        }
                        break;
                    case "Plovdiv":
                        if (sales <= 500)
                        {
                            Console.WriteLine($"{sales * 5.5 / 100:F2}");
                        }
                        else if (sales <= 1000)
                        {
                            Console.WriteLine($"{sales * 8 / 100:F2}");
                        }
                        else if (sales <= 10000)
                        {
                            Console.WriteLine($"{sales * 12 / 100:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"{sales * 14.5 / 100:F2}");
                        }
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
        }
    }
}
