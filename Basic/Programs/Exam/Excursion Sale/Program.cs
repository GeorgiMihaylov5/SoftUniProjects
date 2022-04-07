using System;

namespace Excursion_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaExcursion = int.Parse(Console.ReadLine());
            int mountainExcursion = int.Parse(Console.ReadLine());
            double money = 0;

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                if (input == "sea" && seaExcursion > 0)
                {
                    money += 680;
                    seaExcursion--;
                }
                else if(input == "mountain" && mountainExcursion > 0)
                {
                    money += 499;
                    mountainExcursion--;
                }
                if (seaExcursion == 0 && mountainExcursion == 0)
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Profit: {money} leva.");
        }
    }
}
