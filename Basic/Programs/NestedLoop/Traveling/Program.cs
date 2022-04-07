using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            while (country != "End")
            {
                //if (country == "End")
                //    break;

                double price = int.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < price)
                {
                    string current = Console.ReadLine();
                    if (current == "End")
                        return;
                    double currentMoney = int.Parse(current);
                    savedMoney += currentMoney;
                }

                Console.WriteLine($"Going to {country}!");
                country = Console.ReadLine();
            }

            //string line = string.Empty;
            //while ((line = Console.ReadLine()) != "End")
            //{
            //    string destination = line;
            //    double neededMoney = double.Parse(Console.ReadLine());

            //    double money = 0;
            //    string savings = string.Empty;
            //    while (true)
            //    {
            //        savings = Console.ReadLine();
            //        if (savings == "End")
            //        {
            //            return;
            //        }

            //        money += double.Parse(savings);

            //        if (money >= neededMoney)
            //        {
            //            Console.WriteLine($"Going to {destination}!");
            //            break;
            //        }
            //    }
            //}
        }
    }
}