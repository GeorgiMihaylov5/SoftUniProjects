using System;

namespace MoviePorfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int dayCount = int.Parse(Console.ReadLine());
            int ticketCount = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int cinemaPercent = int.Parse(Console.ReadLine());

            double sum = dayCount * ticketCount * ticketPrice;
            sum -= sum * cinemaPercent / 100;
            Console.WriteLine($"The profit from the movie {name} is {sum:f2} lv.");

        }
    }
}
