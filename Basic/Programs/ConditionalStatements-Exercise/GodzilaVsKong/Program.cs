using System;

namespace GodzilaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistCount = int.Parse(Console.ReadLine());
            double clothesPricePerStatist = double.Parse(Console.ReadLine());

            double decor = budget * 10 / 100;
            double statist = statistCount * clothesPricePerStatist;

            if (statistCount > 150)
            {
                statist = statist - statist * 10 / 100;
            }

            double sum = statist + decor;

            if (budget >= sum)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {sum - budget:f2} leva more.");
            }
        }
    }
}
