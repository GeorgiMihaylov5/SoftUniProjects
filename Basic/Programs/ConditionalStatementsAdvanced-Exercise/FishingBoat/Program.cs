using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget=int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());
            double sum = 0;

            if(season=="Spring")
            {
                sum = 3000;
                if(fishermanCount<=6)
                {
                    sum -= sum * 10 / 100;
                }
                else if(fishermanCount<=11)
                {
                    sum -= sum * 15 / 100;
                }
                else
                {
                    sum -= sum * 25 / 100;
                }

                if(fishermanCount%2==0)
                {
                    sum -= sum * 5 / 100;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                sum = 4200;
                if (fishermanCount <= 6)
                {
                    sum -= sum * 10 / 100;
                }
                else if (fishermanCount <= 11)
                {
                    sum -= sum * 15 / 100;
                }
                else
                {
                    sum -= sum * 25 / 100;
                }

                if (fishermanCount % 2 == 0 && season == "Summer")
                {
                    sum -= sum * 5 / 100;
                }
            }
            else if (season == "Winter")
            {
                sum = 2600;
                if (fishermanCount <= 6)
                {
                    sum -= sum * 10 / 100;
                }
                else if (fishermanCount <= 11)
                {
                    sum -= sum * 15 / 100;
                }
                else
                {
                    sum -= sum * 25 / 100;
                }

                if (fishermanCount % 2 == 0)
                {
                    sum -= sum * 5 / 100;
                }
            }
            
            if(budget>=sum)
            {
                Console.WriteLine($"Yes! You have {budget-sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {sum-budget:f2} leva.");
            }
        }
    }
}
