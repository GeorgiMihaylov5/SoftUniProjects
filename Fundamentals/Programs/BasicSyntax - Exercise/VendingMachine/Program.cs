using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal machineWallet = 0m;

            while (input != "Start")
            {
                decimal inputMoney = decimal.Parse(input);

                if (inputMoney != 0.1m && inputMoney != 0.2m && inputMoney != 0.5m && inputMoney != 1m && inputMoney != 2m)
                {
                    Console.WriteLine($"Cannot accept {inputMoney}");
                }
                else
                    machineWallet += inputMoney;

                input = Console.ReadLine();
            }

            string product = Console.ReadLine();
            while (product != "End")
            {
                if(product == "Nuts")
                {
                    if(machineWallet >= 2.0m)
                    {
                        machineWallet -= 2.0m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if(product == "Water")
                {
                    if (machineWallet >= 0.7m)
                    {
                        machineWallet -= 0.7m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (machineWallet >= 1.5m)
                    {
                        machineWallet -= 1.5m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if(product == "Soda")
                {
                    if (machineWallet >= 0.8m)
                    {
                        machineWallet -= 0.8m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if(product == "Coke")
                {
                    if (machineWallet >= 1.0m)
                    {
                        machineWallet -= 1.0m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {machineWallet:f2}");
        }
    }
}
