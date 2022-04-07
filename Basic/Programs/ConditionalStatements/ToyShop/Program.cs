using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzleQuantity = int.Parse(Console.ReadLine());
            int dollsQuantity = int.Parse(Console.ReadLine());
            int tedyBearsQuantity = int.Parse(Console.ReadLine());
            int minionsQuantity = int.Parse(Console.ReadLine());
            int truckQuantity = int.Parse(Console.ReadLine());

            double sum = puzzleQuantity * 2.60 + dollsQuantity * 3 + tedyBearsQuantity * 4.10 + minionsQuantity * 8.20 + truckQuantity * 2;
            double allQuantity = puzzleQuantity + dollsQuantity + tedyBearsQuantity + minionsQuantity + truckQuantity;

            if(allQuantity>=50)
            {
                sum = sum - sum * 25 / 100;
            }
            sum = sum - sum * 10 / 100;

            if (excursionPrice > sum)
            {
                Console.WriteLine($"Not enough money! {excursionPrice - sum:f2} lv needed.");
            }
            else
            {
                Console.WriteLine($"Yes! {sum - excursionPrice:f2} lv left.");
            }
        }
    }
}
