using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double berriesPrice = double.Parse(Console.ReadLine());
            double quantityOfBanana = double.Parse(Console.ReadLine());
            double quantityOfOranges = double.Parse(Console.ReadLine());
            double quantityOfRaspberries = double.Parse(Console.ReadLine());
            double quantityOfBerries = double.Parse(Console.ReadLine());

            double raspberriesPrice = berriesPrice / 2;
            double orangesPrice = raspberriesPrice-(raspberriesPrice * 40 / 100);
            double bananaPrice= raspberriesPrice - (raspberriesPrice * 80 / 100);
            double sum = raspberriesPrice * quantityOfRaspberries + orangesPrice * quantityOfOranges + bananaPrice * quantityOfBanana + berriesPrice * quantityOfBerries;

            Console.WriteLine($"{sum:f2}");
        }
    }
    
}
