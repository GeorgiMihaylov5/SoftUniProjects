using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int countOfFlowers=int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0;

            if(flowers=="Roses")
            {
                sum = countOfFlowers * 5;
                if(countOfFlowers>80)
                {
                    sum -= sum * 10 / 100;
                }
            }
            else if (flowers == "Dahlias")
            {
                sum = countOfFlowers * 3.80;
                if (countOfFlowers > 90)
                {
                    sum -= sum * 15 / 100;
                }
            }
            else if (flowers == "Tulips")
            {
                sum = countOfFlowers * 2.80;
                if (countOfFlowers > 80)
                {
                    sum -= sum * 15 / 100;
                }
            }
            else if (flowers == "Narcissus")
            {
                sum = countOfFlowers * 3;
                if (countOfFlowers < 120)
                {
                    sum += sum * 15 / 100;
                }
            }
            else if (flowers == "Gladiolus")
            {
                sum = countOfFlowers * 2.5;
                if (countOfFlowers < 80)
                {
                    sum += sum * 20 / 100;
                }
            }

            if(sum<=budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {flowers} and {budget-sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum-budget:f2} leva more.");
            }
        }
    }
}
